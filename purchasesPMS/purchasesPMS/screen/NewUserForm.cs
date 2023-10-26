using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using purchasesPMS.DB;

namespace purchasesPMS.screen
{
    public partial class NewUserForm : Form
    {
        purchasesEntities1 DB = new purchasesEntities1();
        public NewUserForm()
        {
            InitializeComponent();
            StyleDatagridview(uselist);
            uselist.DataSource = DB.TB_USERS.ToList();
            
        }

        /* private void InitializeComponent()
         {
             throw new NotImplementedException();
         }*/

        void StyleDatagridview(DataGridView DaGridView)
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
            DaGridView.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10, FontStyle.Bold);
            DaGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            DaGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void Addbtn_Click(object sender, EventArgs e)
        { 
            try
            {
                TB_USERS users = new TB_USERS();

                //users.user_name = username.Text;
                //users.password = password.Text;

                //DB.AddToTB_USERS(users);
                DB.SaveChanges();
                MessageBox.Show("Added Successfully");
            }catch
            {
                MessageBox.Show("Failed process");
            }
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uselist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
