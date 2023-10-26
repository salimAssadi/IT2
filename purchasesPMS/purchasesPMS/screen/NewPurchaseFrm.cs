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
    public partial class NewPurchaseFrm : Form
    {
        purchasesEntities1 DB =new purchasesEntities1();
     //  public PayDailog;
        public NewPurchaseFrm()
        {
            InitializeComponent();
            supplierList.DataSource = DB.TB_SUPPLIERS.ToList();
            StoresList.DataSource= DB.TB_STORES.ToList();
            productList.DataSource=DB.TB_PRODUCTS.ToList();
            UnitList.DataSource=DB.TB_UNITES.ToList();
            PurchasesProductList.RowsAdded += rowCountChange;
            PurchasesProductList.RowsRemoved += rowCountChange;
            references_no.KeyPress += NUmberVAlidation;
            productCode.KeyPress += NUmberVAlidation;
            qauntity.KeyPress += NUmberVAlidation;
            costPrice.KeyPress += NUmberVAlidation;
            tax.KeyPress += NUmberVAlidation;
            PerProDiscount.KeyPress += NUmberVAlidation;
            totalDiscount.KeyPress += NUmberVAlidation;
            totalPrice.KeyPress += NUmberVAlidation;
            totalTax.KeyPress += NUmberVAlidation;
            BatchNo.KeyPress += NUmberVAlidation;
            totalpurchaseprice.KeyPress += NUmberVAlidation;
            StyleDatagridview(PurchasesProductList);
            UserName.Text = Form1._username;

        }

        /*  private void InitializeComponent()
          {
              throw new NotImplementedException();
          }*/
        int listItemes = 0;
        private void rowCountChange(object sender, EventArgs e)
        {
            try
            {
                ProductsCount.Text = PurchasesProductList.Rows.Count.ToString();
                listItemes = int.Parse(ProductsCount.Text);
               // ProductsCount.Text = "0";
                totalpurchaseprice.Text = "0";
                totalDiscount.Text = "0";
                totalTax.Text= "0";
           
                for (int i = 0; i < PurchasesProductList.Rows.Count; i++)
                {
                    
                    double sum = PurchasesProductList.Rows[i].Cells[10].Value != null ? sum = double.Parse(PurchasesProductList.Rows[i].Cells[10].Value.ToString()) :0 ;
                    totalpurchaseprice.Text = Convert.ToString(double.Parse(totalpurchaseprice.Text) + sum);
                                      
                    double tax = PurchasesProductList.Rows[i].Cells[9].Value != null ? tax = double.Parse(PurchasesProductList.Rows[i].Cells[9].Value.ToString()) :0 ;
                    totalTax.Text = Convert.ToString(double.Parse(totalTax.Text) + tax);

                    double dicount = PurchasesProductList.Rows[i].Cells[8].Value != null ? dicount = double.Parse(PurchasesProductList.Rows[i].Cells[8].Value.ToString()) :0 ;
                    totalDiscount.Text = Convert.ToString(double.Parse(totalDiscount.Text) + dicount);
                }
            }
            catch
            {

            }

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NewPurchaseFrm_Load(object sender, EventArgs e)
        {

        }

        void StyleDatagridview(DataGridView DaGridView)
        {
            DaGridView.BorderStyle = BorderStyle.None;
            DaGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            DaGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DaGridView.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            DaGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            DaGridView.BackgroundColor = Color.MidnightBlue;
            DaGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            DaGridView.EnableHeadersVisualStyles = false;
            DaGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DaGridView.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            DaGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            DaGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void PurchasesProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        bool isempty = false;
        private void Additemsbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (references_no.Text != null && supplierList.SelectedItem!=null &&StoresList.SelectedItem!=null && PurchaseState.SelectedItem!=null)
                {   
                    int refNo= int.Parse(references_no.Text);
                    var ref_rsult = DB.TB_PURCHASES.Where(z => z.reference_No == refNo).FirstOrDefault();
                    if (ref_rsult == null)
                    {

                    if (productCode.Text != null && costPrice.Text != null && qauntity.Text != null)
                    {
                        DateTime date = ProdExpireDate.Value;

                        string prod_id = productCode.Text;
                        string unit_id = UnitList.SelectedValue.ToString();
                        string expDate = date.ToShortDateString();

                        string proname = productList.Text;
                        string unitname = UnitList.Text;
                        bool isfound = false ;
                       
                        foreach(DataGridViewRow prod_idCheckExists in PurchasesProductList.Rows)
                        {
                            if (!prod_idCheckExists.IsNewRow)
                            {
                                if(prod_id == prod_idCheckExists.Cells["HidenProductId"].Value.ToString())                              
                                     isfound = true;
                                isfound = false;
                            }
                            else
                            {
                                isempty = true;
                            }
                           
                        }
                        if (!isfound)
                        {
                            
                            PurchasesProductList.Rows.Add(prod_id, unit_id, proname, unitname, BatchNo.Text, expDate, costPrice.Text, qauntity.Text, PerProDiscount.Text, tax.Text, totalPrice.Text);
                            productCode.Text = "";
                            BatchNo.Text = "";
                            costPrice.Text = "";
                            qauntity.Text = "";
                            totalPrice.Text = "";
                            tax.Text = "";
                            PerProDiscount.Text = "";
                            ProdExpireDate.Value = DateTime.Now;

                        }
                        else
                        {
                            return;
                        }
                    }
                    else{
                        MessageBox.Show("لديك بعض الحقول الفارغة");
                    }
                    }
                    else
                    {
                        MessageBox.Show("الرقم المرجعي موجود من قبل");
                    }
                }
                else
                {
                    MessageBox.Show("لديك بعض الحقول الفارغة");
                }
            }
            catch
            {

            }
        }
      
        private void productCode_TextChanged(object sender, EventArgs e)
        {
            string parcode = productCode.Text;
             if(!(int.TryParse(parcode, out int barcode1)))
            {
                return;
            }
             if(parcode.Length==0)
            {
                productList.DataSource = DB.TB_PRODUCTS.ToList();
               
            }
                productList.DataSource = DB.TB_PRODUCTS.Where(x => x.Prod_id== barcode1).ToList();

        }

        private void productList_SelectedIndexChanged(object sender, EventArgs e)
        {

           /* var parcode = DB.TB_PRODUCTS.Where(x => x.Prod_id == Convert.ToInt32(productList.SelectedValue)).Select(x => x.barcode).ToList();
            MessageBox.Show(parcode.ToString());*/
        }

        private void costPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {

            decimal taxv = 0, discountv = 0;
            decimal costpriceV;
            int qaunti;

                if (costPrice.Text!=null && qauntity.Text!=null)
                {
                costpriceV = Convert.ToDecimal(costPrice.Text = costPrice.Text != null ? costPrice.Text : "0");
                qaunti = int.Parse(qauntity.Text = qauntity.Text != null ? qauntity.Text : "0");
                taxv = Convert.ToDecimal(tax.Text = tax.Text != null ? tax.Text :"0");
                discountv = Convert.ToDecimal(PerProDiscount.Text = PerProDiscount.Text != null ? PerProDiscount.Text : "0");
                totalPrice.Text =Convert.ToString(costpriceV * qaunti + taxv - discountv);
                }
                else
                {
                    return;
                }
            }catch
            {
                
            }
        }

        private void PaymentPanel_Enter(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delrow_Click(object sender, EventArgs e)
        {
            try
            {

                if(!PurchasesProductList.Rows[PurchasesProductList.CurrentCell.RowIndex].IsNewRow)
                    PurchasesProductList.Rows.RemoveAt(PurchasesProductList.CurrentCell.RowIndex);
                    return;        
            }
            catch
            {

            }
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
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }


        private void shippmentCost_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void neededprice_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                MessageBox.Show("يوجد لديك بعض الحقول الفارغة");

            
            }
        }
        public void gotoPaybtn_Click(object sender, EventArgs e)
        {
            if (listItemes!=0)
            {
                PaymentDailog PayDailog = new PaymentDailog(this);
                PayDailog.ShowDialog();
            }
            else
            {
                MessageBox.Show("لايمكنك التنفيذ السلة فارغة");
            }              
           
        }
        private void StoresList_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(StoresList.SelectedValue.ToString());
        }

        private void PurchaseDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void qauntity_TextChanged(object sender, EventArgs e)
        {
            try
            {

                decimal taxv = 0, discountv = 0;
                decimal costpriceV;
                int qaunti;

                if (costPrice.Text != null && qauntity.Text != null)
                {
                    costpriceV = Convert.ToDecimal(costPrice.Text = costPrice.Text != null ? costPrice.Text : "0");
                    qaunti = int.Parse(qauntity.Text = qauntity.Text != null ? qauntity.Text : "0");
                    taxv = Convert.ToDecimal(tax.Text = tax.Text != null ? tax.Text : "0");
                    discountv = Convert.ToDecimal(PerProDiscount.Text = PerProDiscount.Text != null ? PerProDiscount.Text : "0");
                    totalPrice.Text = Convert.ToString(costpriceV * qaunti + taxv - discountv);
                }
                else
                {
                    return;
                }
            }
            catch
            {

            }
        }

        private void tax_TextChanged(object sender, EventArgs e)
        {
            try
            {

                decimal taxv = 0, discountv = 0;
                decimal costpriceV;
                int qaunti;

                if (costPrice.Text != null && qauntity.Text != null)
                {
                    costpriceV = Convert.ToDecimal(costPrice.Text = costPrice.Text != null ? costPrice.Text : "0");
                    qaunti = int.Parse(qauntity.Text = qauntity.Text != null ? qauntity.Text : "0");
                    taxv = Convert.ToDecimal(tax.Text = tax.Text != null ? tax.Text : "0");
                    discountv = Convert.ToDecimal(PerProDiscount.Text = PerProDiscount.Text != null ? PerProDiscount.Text : "0");
                    totalPrice.Text = Convert.ToString(costpriceV * qaunti + taxv - discountv);
                }
                else
                {
                    return;
                }
            }
            catch
            {

            }
        }

        private void PerProDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {

                decimal taxv = 0, discountv = 0;
                decimal costpriceV;
                int qaunti;

                if (costPrice.Text != null && qauntity.Text != null)
                {
                    costpriceV = Convert.ToDecimal(costPrice.Text = costPrice.Text != null ? costPrice.Text : "0");
                    qaunti = int.Parse(qauntity.Text = qauntity.Text != null ? qauntity.Text : "0");
                    taxv = Convert.ToDecimal(tax.Text = tax.Text != null ? tax.Text : "0");
                    discountv = Convert.ToDecimal(PerProDiscount.Text = PerProDiscount.Text != null ? PerProDiscount.Text : "0");
                    totalPrice.Text = Convert.ToString(costpriceV * qaunti + taxv - discountv);
                }
                else
                {
                    return;
                }
            }
            catch
            {

            }
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void supplierList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
