using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using purchasesPMS.screen;
using purchasesPMS.DB;

namespace purchasesPMS.login
{
 
    public partial class loginFrm : Form
    {
        static public string username;
        private const string DateFormat = "dd/MM/yyyy";
        private const string CurrencySymbol = "$";
        public loginFrm()
        {
            InitializeComponent();
        }
        
        purchasesEntities1 DB = new purchasesEntities1();
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        void openeForm()
        {

            Application.Run(new purchasesPMS.screen.Form1(username));
        }
        private void button2_Click(object sender, EventArgs e)
        {
          Application.Exit();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                   var result =  DB.TB_USERS.Where(x => x.user_name == textBox1.Text && x.password == textBox2.Text).FirstOrDefault();

                   if(result !=null)
                   
                    {
                     username = result.user_name;
                    // this.Close();
                    Thread th = new Thread(openeForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                    purchasesPMS.screen.Form1 Form1 = new purchasesPMS.screen.Form1(username);
                     this.Hide();
                      Form1.ShowDialog();

                          
                    }
                    else
                    {
                        MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيحة ");
                    }
            }
            catch
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PRINT_Click(object sender, EventArgs e)
        {
           
         if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }
//SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            // Define the invoice details
            string invoiceNo = "INV001";
            DateTime invoiceDate = DateTime.Now;
            string cashierName = "John Doe";

            // Define the items in the invoice
            string[] itemNames = { "Item 1", "Item 2", "Item 3" };
            decimal[] itemPrices = { 10.50m, 20.00m, 5.75m };

            // Define the total price calculation
            decimal totalPrice = 0;
            foreach (var price in itemPrices)
            {
                totalPrice += price;
            }

            // Define the page layout
            float startX = 10;
            float startY = 10;
            float lineHeight = 20;
            float invoiceHeaderY = startY;
            float invoiceBodyY = invoiceHeaderY + 3 * lineHeight;
            float invoiceFooterY = invoiceBodyY + itemNames.Length * lineHeight + 3 * lineHeight;

            // Create a font for the invoice
            Font invoiceFont = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);

            // Draw the invoice header
            e.Graphics.DrawString("Invoice No: " + invoiceNo, invoiceFont, Brushes.Black, startX, invoiceHeaderY);
            e.Graphics.DrawString("Invoice Date: " + invoiceDate.ToString(DateFormat), invoiceFont, Brushes.Black, startX, invoiceHeaderY + lineHeight);
            e.Graphics.DrawString("Cashier: " + cashierName, invoiceFont, Brushes.Black, startX, invoiceHeaderY + 2 * lineHeight);

            // Draw the invoice body
            for (int i = 0; i < itemNames.Length; i++)
            {
                float itemY = invoiceBodyY + i * lineHeight;
                e.Graphics.DrawString(itemNames[i], invoiceFont, Brushes.Black, startX, itemY);
                e.Graphics.DrawString(CurrencySymbol + itemPrices[i].ToString(), invoiceFont, Brushes.Black, e.PageBounds.Right - 100, itemY);
            }

            // Draw the invoice footer
            e.Graphics.DrawString("Total: " + CurrencySymbol + totalPrice.ToString(), invoiceFont, Brushes.Black, startX, invoiceFooterY);
            e.Graphics.DrawString("Cashier: " + cashierName, invoiceFont, Brushes.Black, startX, invoiceFooterY + lineHeight);

            // Dispose of the font object
            invoiceFont.Dispose();
        }
    }
}
