using purchasesPMS.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;

namespace purchasesPMS.screen
{
    public partial class PoructForm : Form
    {
        purchasesEntities1 DB = new purchasesEntities1();
        public PoructForm()
        {
            InitializeComponent();
            productList.DataSource = DB.TB_PRODUCTS.ToList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void PoructForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            DB.TB_PRODUCTS products = new TB_PRODUCTS { Prod_id =int.Parse(prod_code.Text), Prod_name = productName.Text, Unite_price =decimal.Parse(productPrice.Text), SN =productsSN.Text};

            DB.TB_PRODUCTS.Add(products);
            DB.SaveChanges();
            productList.DataSource = DB.TB_PRODUCTS.ToList();

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {

                var product = new TB_PRODUCTS 
                        {   Prod_id = int.Parse(prod_code.Text),
                            Prod_name = productName.Text, 
                            Unite_price = decimal.Parse(productPrice.Text),
                            SN = productsSN.Text 
                        };
                int prodid = int.Parse(prod_code.Text);
                var result = DB.TB_PRODUCTS.SingleOrDefault(p => p.Prod_id == prodid);
                    if ( result != null )
                    {
                        DB.TB_PRODUCTS.AddOrUpdate(product);
                        // DB.TB_PRODUCTS.Attach(product);
                        // DB.Entry(product).State = System.Data.Entity.EntityState.Modified;   
                        DB.SaveChanges();
                        productList.DataSource = DB.TB_PRODUCTS.ToList();
                    }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void productList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ADD.Enabled = false;
                if (e.RowIndex >= 0)
                {
                    // Get the ID from the clicked row in the first DataGridView
                    prod_code.Text = Convert.ToString(productList.Rows[e.RowIndex].Cells["prodidDataGridViewTextBoxColumn"].Value);
                    productName.Text = Convert.ToString(productList.Rows[e.RowIndex].Cells["prodnameDataGridViewTextBoxColumn"].Value);
                    productPrice.Text = Convert.ToString(productList.Rows[e.RowIndex].Cells["unitepriceDataGridViewTextBoxColumn"].Value);
                    productsSN.Text = Convert.ToString(productList.Rows[e.RowIndex].Cells["sNDataGridViewTextBoxColumn"].Value);
                   
                }
                

            }
            catch
            {

            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
             prod_code.Text ="";
            productName.Text="";
           productPrice.Text="";
            productsSN.Text ="";
            ADD.Enabled = true;

        }

        private void productList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
