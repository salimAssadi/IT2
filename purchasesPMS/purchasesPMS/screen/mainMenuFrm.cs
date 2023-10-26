using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace purchasesPMS.screen
{
    public partial class mainMenuFrm : Form
    {
       public Form1 form1;
        public mainMenuFrm()
        {
            InitializeComponent();
        }

        NewPurchaseFrm newFrm;
        NewUserForm userFrm;
        PuchasesManagementFRM PurchManageFRM;
        PoructForm poructForm;
        suppliers supplierfrm;
        stock stocks;
        private void mainMenuFrm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (PurchManageFRM != null)
            {
                PurchManageFRM = null;
                PurchManageFRM = new PuchasesManagementFRM();
                PurchManageFRM.MdiParent = form1;
                PurchManageFRM.ShowDialog();
            }
            else
            {
                PurchManageFRM = new PuchasesManagementFRM();
                PurchManageFRM.MdiParent = form1;
                PurchManageFRM.ShowDialog();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //if (purchasesManagementFrm != null)
            //{
            //    purchasesManagementFrm = new PurchasesManagementFrm();
            //    purchasesManagementFrm.MdiParent = form1;
            //    purchasesManagementFrm.Show();
            //}
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void mainMenuFrm_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (newFrm != null)
            {
                newFrm = new NewPurchaseFrm();
                newFrm.MdiParent = form1;
                newFrm.ShowDialog();
            }
            else
            {
                newFrm = new NewPurchaseFrm();
                newFrm.MdiParent = form1;
                newFrm.ShowDialog();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void userManage_Click(object sender, EventArgs e)
        {
            if (userFrm != null)
            {
                userFrm = new NewUserForm();
                userFrm.MdiParent = form1;
                userFrm.ShowDialog();
            }
            else
            {
                userFrm = new NewUserForm();
                userFrm.MdiParent = form1;
                userFrm.ShowDialog();
            }
        }

        private void PRODUCT_MENU(object sender, EventArgs e)
        {

            if (poructForm != null)
            {

                poructForm.MdiParent = form1;
                poructForm.ShowDialog();
            }
            else
            {
                poructForm = new PoructForm();
                poructForm.MdiParent = form1;
                poructForm.ShowDialog();
            }
        }

        private void suppliermanage_Click(object sender, EventArgs e)
        {
            if (supplierfrm != null)
            {

                supplierfrm.MdiParent = form1;
                supplierfrm.ShowDialog();
            }
            else
            {
                supplierfrm = new suppliers();
                supplierfrm.MdiParent = form1;
                supplierfrm.ShowDialog();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {   if (stocks != null)
            {
                stocks.MdiParent = form1;
                stocks.ShowDialog();
            }
            else
            {

            stocks = new stock();
            stocks.MdiParent = form1;
            stocks.ShowDialog();
            }
        }
    }
}
