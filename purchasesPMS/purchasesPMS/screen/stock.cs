using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using purchasesPMS.DB;
namespace purchasesPMS.screen
{
    public partial class stock : Form
    {
        public stock()
        {
            InitializeComponent();
        }

        purchasesEntities1 DB = new purchasesEntities1();

        private void stock_Load(object sender, EventArgs e)
        {
            storeslist.DataSource = DB.TB_STOCKS.ToList();
            
            itemslist.DataSource = DB.TB_PRODUCTS.ToList();
            storeListDGV.DataSource = DB.TB_STORES.ToList();
            stocklists.DataSource = DB.TB_STOCKS.ToList();
            
        }

        private void stockTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            try
            {

                DB.TB_STORES store = new TB_STORES { Store_name = storename.Text, store_location = location.Text };
                DB.TB_STORES.Add(store);

                DB.SaveChanges();
                storeListDGV.DataSource = DB.TB_STORES.ToList();
                hidenid.Text = "";
                storename.Text = "";
                location.Text = "";
                ADD.Enabled = true;

            }
            catch
            {

            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {

                var store = new TB_STORES
                {


                };


                int store_id = int.Parse(hidenid.Text);
                var result = DB.TB_STORES.Where(p => p.store_Id == store_id).SingleOrDefault();
                if (result != null)
                {

                    result.Store_name = storename.Text;
                    result.store_location = location.Text;                  
                    DB.SaveChanges();
                    storeListDGV.DataSource = DB.TB_STORES.ToList();
                    hidenid.Text = "";
                    storename.Text = "";
                    location.Text = "";
                    ADD.Enabled = true;


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            hidenid.Text = "";
            storename.Text = "";
            location.Text = "";           
            ADD.Enabled = true;
        }

        private void storeListDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void storeListDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ADD.Enabled = false;

                if (e.RowIndex >= 0)
                {
                    // Get the ID from the clicked row in the first DataGridView
                    hidenid.Text = Convert.ToString(storeListDGV.Rows[e.RowIndex].Cells["store_id"].Value);
                    storename.Text = Convert.ToString(storeListDGV.Rows[e.RowIndex].Cells["store_name"].Value);
                    location.Text = Convert.ToString(storeListDGV.Rows[e.RowIndex].Cells["store_location"].Value);

                }

            }
            catch
            {

            }
        }
    }
}
