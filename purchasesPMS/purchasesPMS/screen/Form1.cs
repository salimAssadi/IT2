using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using purchasesPMS.DB;
using purchasesPMS.login;

using purchasesPMS.screen;
namespace purchasesPMS.screen
{
    public partial class Form1 : Form
    {
        purchasesEntities1 DB = new purchasesEntities1();
        static public string _username ="salim";

        public Form1(string username)
        {
            InitializeComponent();
            _username = username;
           
        }

        mainMenuFrm mainFrm = new mainMenuFrm();
        private void Form1_Load(object sender, EventArgs e)
        {
            mainFrm.MdiParent = this;
            mainFrm.Show();
        }


        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainFrm.MdiParent = this;
            mainFrm.Show();
        }


        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void المشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* PurchasesManagementFrm purchasesFrm = new PurchasesManagementFrm();
            purchasesFrm.MdiParent = this;
            purchasesFrm.Show();*/
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
