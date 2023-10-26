using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using purchasesPMS.DB;
using purchasesPMS.reports;
namespace purchasesPMS.screen
{
    public partial class PuchasesManagementFRM : Form
    {
        PaymentDailog paydaialog;
        public PuchasesManagementFRM()
        {
            InitializeComponent();
            StyleDatagridview(purchases_List1);
            StyleDatagridview(PurchasesItemsList1);
            purchases_List1.CellFormatting += DataGridView_CellFormatting;

        }

        purchasesEntities1 DB = new purchasesEntities1();
        private void PuchasesManagementFRM_Load(object sender, EventArgs e)
        {
            supplierSearch.DataSource = DB.TB_SUPPLIERS.ToList();
        }

        void StyleDatagridview( DataGridView DaGridView)
        {
            //DaGridView.BorderStyle = BorderStyle.None;
            DaGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            DaGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DaGridView.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            DaGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            DaGridView.ForeColor = Color.MidnightBlue;
            DaGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            DaGridView.EnableHeadersVisualStyles = false;
            DaGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DaGridView.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10,FontStyle.Bold);
            DaGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            DaGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void purchasesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            purchases_List1.DataSource = null;
            purchases_List1.DataSource = DB.purchases_view.ToList();
            
            //PurchasesItemsList1.DataSource = DB.Purchase_Items.ToList();
        }



        public int purchaseId;


        private void purchases_List1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            if (e.RowIndex >= 0)
            {
                // Get the ID from the clicked row in the first DataGridView
                 purchaseId = Convert.ToInt32(purchases_List1.Rows[e.RowIndex].Cells["purchase_id"].Value);
                 PurchasesItemsList1.DataSource = DB.Purchase_Items.Where(x=>x.purchase_id== purchaseId).ToList();
                 
            }
            }
            catch
            {

            }
        }

        private void purchasesList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PurchasesItemsList1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (seachFiled.Text.Length > 0)
                {
                    int s = int.Parse(seachFiled.Text);
                      var result = DB.purchases_view.Where(x => (x.reference_No ==s) || (x.supplier_name == seachFiled.Text)).ToList();
                           
                        purchases_List1.DataSource = result;
                
                }
                else
                {
                    purchases_List1.DataSource = DB.purchases_view.ToList();
                }
            }
            catch
            {

            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void purchases_List1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex ==14 ) // Replace with the actual index of your value column
            {
                var value = (string)e.Value; // Assuming the value is an integer
                if (value == "مدفوع")
                {              
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if(value == "جزئي")
                {
                    e.CellStyle.ForeColor = Color.Orange;
                }
                else if (value == "عير مدفوع")
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }
        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int purchases_id;
        private void purchases_List1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {
                    purchases_id = Convert.ToInt32(purchases_List1.Rows[e.RowIndex].Cells["purchaseidDataGridViewTextBoxColumn"].Value);
                    givenBill.Enabled = true;
                    
                }
                else
                {
                    givenBill.Enabled = false;
                }
            }
            catch
            {

            }
        }

        private void givenBill_Click(object sender, EventArgs e)
        {
            try
            {

                var result = DB.TB_PURCHASES.Where(x =>( x.payment_status == "جزئي" || x.payment_status == "أجل" ) &&( x.purchase_id == purchases_id)).SingleOrDefault();

                if(result!=null)
                {

                paydaialog = new PaymentDailog(result.purchase_id);
                paydaialog.ShowDialog();
                result = null;
                purchases_List1.DataSource = DB.TB_PURCHASES.ToList();
                }
                else
                {
                    MessageBox.Show("هذه الفاتورة مدفوعه");


                }
            }
            catch(Exception re)
            {
                MessageBox.Show(re.Message);
            }
        }

        private void pay_Click(object sender, EventArgs e)
        {

            XtraReport1 report1 = new XtraReport1();
            Panel panel5 = new Panel();
            report1.DetailReport.DataSource = DB.purchases_view.Where(x=>x.purchase_id==purchaseId).ToList();
           //report1.DetailReport.DataMember = DB.purchases_view.ToList();

            report1.DetailReport1.DataSource = DB.Purchase_Items.Where(x => x.purchase_id == purchaseId).ToList();

            report1.CreateDocument();
            // Display the report in a viewer control
            using (ReportPrintTool printTool = new ReportPrintTool(report1))
            {
                printTool.ShowPreviewDialog();
            }



        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int supplier_id=0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if(supplierSearch.SelectedIndex>0)
                {
                    int s = int.Parse(seachFiled.Text);
                    var result = DB.purchases_view.Where(x =>(x.supplier_name ==supplierSearch.Text)).ToList();

                    purchases_List1.DataSource = result;
                    supplier_id = int.Parse(supplierSearch.SelectedValue.ToString());
                }
                else
                {
                    purchases_List1.DataSource = DB.purchases_view.ToList();
                }
            }
            catch
            {

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {

            XtraReport3 report3 = new XtraReport3();
           
            report3.DataSource = DB.purchases_view.Where(x => x.supplier_name == supplierSearch.Text).ToList();
           // report3.DataSource = DB.purchases_view.ToList();

            //report3.DataSource = DB.Purchase_Items.Where(x => x.purchase_id == purchaseId).ToList();

            report3.CreateDocument();
            // Display the report in a viewer control
            using (ReportPrintTool printTool = new ReportPrintTool(report3))
            {
                printTool.ShowPreviewDialog();
            }
            }
            catch
            {

            }
        }
    }
}
