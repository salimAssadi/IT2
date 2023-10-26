using purchasesPMS.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace purchasesPMS.screen
{
    public partial class suppliers : Form
    {
        purchasesEntities1 DB = new purchasesEntities1();

        public suppliers()
        {   
            InitializeComponent();
            suppliername.KeyPress += STRINGVAlidation;
            phoenNumber.KeyPress += NUmberVAlidation;
            supplierlist.DataSource = DB.TB_SUPPLIERS.ToList();
        }

        private void suppliers_Load(object sender, EventArgs e)
        {

        }

        private void phoenNumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void suppname_TextChanged(object sender, EventArgs e)
        {

        }

        private void NUmberVAlidation(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void STRINGVAlidation(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (char.IsWhiteSpace(e.KeyChar))))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void supplierlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            try
            {
               
                DB.TB_SUPPLIERS supplier = new TB_SUPPLIERS{ supplier_name = suppliername.Text, supplier_email = email.Text, supplier_phone =int.Parse(phoenNumber.Text)};
                 DB.TB_SUPPLIERS.Add(supplier);
               
                DB.SaveChanges();
                 supplierlist.DataSource =DB.TB_SUPPLIERS.ToList();
               
                
            }
            catch
            {

            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {

                var supplier = new TB_SUPPLIERS {
                   
                  
                };
        
                
                int supplier_id = int.Parse(hidenid.Text);
                var result = DB.TB_SUPPLIERS.Where(p => p.supplier_id ==supplier_id).SingleOrDefault();
                if (result != null)
                {

                    result.supplier_name = suppliername.Text;
                    result.supplier_email = email.Text;
                    result.supplier_phone = int.Parse(phoenNumber.Text);
                    DB.SaveChanges();
                    supplierlist.DataSource = DB.TB_SUPPLIERS.ToList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void supplierlist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ADD.Enabled = false;

                if (e.RowIndex >= 0)
                {
                    // Get the ID from the clicked row in the first DataGridView
                    hidenid.Text = Convert.ToString(supplierlist.Rows[e.RowIndex].Cells["supplieridDataGridViewTextBoxColumn"].Value);
                    suppliername.Text = Convert.ToString( supplierlist.Rows[e.RowIndex].Cells["suppliernameDataGridViewTextBoxColumn"].Value);
                    email.Text = Convert.ToString(supplierlist.Rows[e.RowIndex].Cells["supplieremailDataGridViewTextBoxColumn"].Value);
                    phoenNumber.Text = Convert.ToString(supplierlist.Rows[e.RowIndex].Cells["supplierphoneDataGridViewTextBoxColumn"].Value);

                }

            }
            catch
            {

            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            hidenid.Text = "";
            suppliername.Text = "";
            email.Text = "";
            phoenNumber.Text="";
            ADD.Enabled = true;

        }

        private void hidenid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
