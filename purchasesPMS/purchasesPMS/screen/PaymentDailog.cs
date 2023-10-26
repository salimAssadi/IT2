using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using purchasesPMS.DB;
using System.Data.Entity;
using System.Transactions;
using purchasesPMS.reports;
using DevExpress.XtraReports.UI;

namespace purchasesPMS.screen
{
    public partial class PaymentDailog : Form
    {
        purchasesEntities1 DB = new purchasesEntities1();
        NewPurchaseFrm PFrm;
       public PuchasesManagementFRM PMfrm;
        string processType;
        public PaymentDailog(NewPurchaseFrm PurchaseComponent)
        {
            processType = "intitalpay";
            this.PFrm = PurchaseComponent;
            InitializeComponent();
            currency_List.DataSource = DB.TB_CURRENCIES.ToList();
            neededprice.Text = PFrm.totalpurchaseprice.Text;
            reference_no.Text = PFrm.references_no.Text;

         /*   neededprice.TextChanged += payedPrice_TextChanged;
            shippCost.TextChanged += payedPrice_TextChanged;
            remianPrice.TextChanged += payedPrice_TextChanged;*/

        }

        public int purchaseId;
        public PaymentDailog(int purchId)
        {
            try
            {
                InitializeComponent();
                neededprice.TextChanged += payedPrice_TextChanged;
                /*shippCost.TextChanged += payedPrice_TextChanged;
                remianPrice.TextChanged += payedPrice_TextChanged;
                x.payment_status == "جزئي" || x.payment_status == "أجل" &&
*/
                processType = "payremainedprice";
                var result = DB.TB_PURCHASES.Where(x =>  x.purchase_id== purchId).SingleOrDefault();
                if (result != null)
                {
                    purchaseId = result.purchase_id;
                    currency_List.DataSource = DB.TB_CURRENCIES.Where(x => x.cur_id == result.CURR_ID).Select(p => p).ToList();
                    neededprice.Text = result.REMAIN_PRICE.ToString();
                    reference_no.Text = result.reference_No.ToString();
                    paymentMethod.SelectedItem = result.payment_method.ToString();
                    remianPrice.Text = result.REMAIN_PRICE.ToString();

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

        decimal price = 0;
        decimal shipcost = 0;
        decimal Needprice = 0;
        decimal paiyedPrice;
        decimal rmainPrice;
        int currency;
        private void PaymentPanel_Enter(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void PaymentDailog_Load(object sender, EventArgs e)
        {
            billprint.Checked = true;
        }

        public void updatedateBYpay()
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {

                    string paymentStatus = "";
                    decimal shipmentValue = shipcost;
                    decimal neededprice = price;
                    decimal paiedPrice = paiyedPrice;
                    decimal remainPrice = rmainPrice;
                    //---------------------
                    //determine status of payment
                    if (paiedPrice == neededprice)
                    {

                        paymentStatus = "مدفوع";

                    }
                    else if (paiedPrice < neededprice && paiedPrice !=0)
                    {

                        paymentStatus = "جزئي";
                    }
                    else if (paiedPrice == 0)
                    {
                        paymentStatus = "غير مدفوع";

                    }
                    else
                    {
                        paymentStatus = "غير مدفوع";
                    }


                    var Targitrecord = DB.TB_PURCHASES.Where(p => p.purchase_id == purchaseId).SingleOrDefault();
                    Targitrecord.TOTAL_PAIED += paiedPrice;
                    Targitrecord.REMAIN_PRICE = remainPrice;
                    Targitrecord.payment_status = paymentStatus;
                    DB.SaveChanges();
                    scope.Complete();
                    MessageBox.Show($" تم دفع " + paiedPrice + " المتبقي عليك " + remainPrice);
                    Targitrecord = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void pay()
        {

            try { 

            int supplierId = int.Parse(PFrm.supplierList.SelectedValue.ToString());
            int storeId = int.Parse(PFrm.StoresList.SelectedValue.ToString());
            int referenceNo = int.Parse(PFrm.references_no.Text);
            DateTime purchaseDate = PFrm.PurchaseDateTime.Value;
            string purchaseState = PFrm.PurchaseState.SelectedItem.ToString();
            string purchasenotes = PFrm.PurchaseNotes.Text.ToString();
            string paymentStatus = "";
            // -------------------------------
            // int productCode = 25554;
            int productId;
            int unit_id;
            int batchNo;
            DateTime Expiredate;
            int quantity;
            decimal netprice;
            decimal tax11;
            decimal Discount;
            decimal sumprice;

            //-----------------------
            decimal shipmentValue = shipcost;
            decimal neededprice = price;
            decimal paiedPrice = paiyedPrice;
            decimal remainPrice = rmainPrice;
            decimal totalDiscount = (PFrm.totalDiscount.Text != null) ? decimal.Parse(PFrm.totalDiscount.Text) : 0;
            decimal totalTax = (PFrm.totalTax.Text != null) ? decimal.Parse(PFrm.totalTax.Text) : 0;






            //---------------------
            //determine status of payment
            if (paiedPrice == neededprice)
            {

                paymentStatus = "مدفوع";

            }
            else if (paiedPrice < neededprice)
            {

                paymentStatus = "جزئي";
            }
            else if (paiedPrice == 0)
            {
                paymentStatus = "أجل";

            }
            else
            {
                paymentStatus = "غير مدفوع";
            }


            using (TransactionScope scope = new TransactionScope())
            {

                DB.TB_PURCHASES tB_PURCHASEs = new DB.TB_PURCHASES();
                tB_PURCHASEs.SUPP_ID = supplierId;
                tB_PURCHASEs.store_Id = storeId;
                tB_PURCHASEs.reference_No = referenceNo;
                tB_PURCHASEs.purchase_date = purchaseDate;
                tB_PURCHASEs.purchase_Notes = purchasenotes;
                tB_PURCHASEs.payment_method = this.paymentMethod.SelectedItem.ToString();
                tB_PURCHASEs.DISCOUNT = totalDiscount;
                tB_PURCHASEs.TOTAL_PAIED = paiedPrice;
                tB_PURCHASEs.REMAIN_PRICE = remainPrice;
                tB_PURCHASEs.tax = totalTax;
                tB_PURCHASEs.payment_status = paymentStatus;
                tB_PURCHASEs.ShippmentCost = shipmentValue;
                tB_PURCHASEs.CURR_ID = currency;
                tB_PURCHASEs.purchase_status = purchaseState;
                DB.TB_PURCHASES.Add(tB_PURCHASEs);
                DB.SaveChanges();

                var purchase_ID = DB.TB_PURCHASES.Max(p => p.purchase_id);
                // DB.Purchase_Items purchase_Items = new DB.Purchase_Items();

                foreach (DataGridViewRow row in PFrm.PurchasesProductList.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        DB.Purchase_Items purchase_Items = new DB.Purchase_Items();


                        // Retrieve the data from the DataGridView row

                        productId = row.Cells["HidenProductId"].Value != null ? productId = int.Parse(row.Cells["HidenProductId"].Value.ToString()) : 0;
                        unit_id = row.Cells["HidenUnitId"].Value != null ? unit_id = int.Parse(row.Cells["HidenUnitId"].Value.ToString()) : 0;
                        batchNo = row.Cells["batch_N"].Value != null ? batchNo = int.Parse(row.Cells["batch_N"].Value.ToString()) : 0;
                        Expiredate = DateTime.Parse(row.Cells["expiredate"].Value.ToString());
                        netprice = row.Cells["price"].Value != null ? netprice = decimal.Parse(row.Cells["price"].Value.ToString()) : 0;
                        quantity = row.Cells["countum"].Value != null ? quantity = int.Parse(row.Cells["countum"].Value.ToString()) : 0;
                        Discount = row.Cells["discount"].Value != null ? Discount = decimal.Parse(row.Cells["discount"].Value.ToString()) : 0;
                        tax11 = row.Cells["tax1"].Value != null ? tax11 = decimal.Parse(row.Cells["tax1"].Value.ToString()) : 0;
                        sumprice = row.Cells["sum1"].Value != null ? sumprice = decimal.Parse(row.Cells["sum1"].Value.ToString()) : 0;

                        purchase_Items.purchase_id = purchase_ID;
                        purchase_Items.deliver_qauntity = 0;
                        purchase_Items.prod_id = productId;
                        purchase_Items.Unit_id = unit_id;
                        purchase_Items.Net_price = netprice;
                        purchase_Items.quantity = quantity;
                        purchase_Items.Batch_NO = batchNo;
                        purchase_Items.expire_date = Expiredate;
                        purchase_Items.discount = Discount;
                        purchase_Items.tax = tax11;
                        purchase_Items.totalprice = sumprice;

                        DB.Purchase_Items.Add(purchase_Items);
                        DB.SaveChanges();
                        purchase_Items = null;

                    }

                }

                 scope.Complete();

                    if (billprint.Checked)
                    {

                    XtraReport1 report1 = new XtraReport1();
                    Panel panel5 = new Panel();
                    report1.DetailReport.DataSource = DB.purchases_view.Where(x => x.purchase_id == purchase_ID).ToList();
                    //report1.DetailReport.DataMember = DB.purchases_view.ToList();

                    report1.DetailReport1.DataSource = DB.Purchase_Items.Where(x => x.purchase_id == purchase_ID).ToList();

                    report1.CreateDocument();
                    // Display the report in a viewer control
                    using (ReportPrintTool printTool = new ReportPrintTool(report1))
                    {
                        printTool.ShowPreviewDialog();
                    }

                    }
                    else
                    {
                        MessageBox.Show("تمت العملية بنجاج");
                    }
                    this.Close();
                
            }

            this.Close();
             }
    
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
      public static bool printbill = false;
        private void paybtn_Click(object sender, EventArgs e)
        {
           
            try
            {

                if(processType== "intitalpay")
                {

                    shipcost = (shippCost.Text != null) ? decimal.Parse(shippCost.Text) : 0;
                    Needprice = neededprice.Text != null ? decimal.Parse(neededprice.Text) : 0;
                    price = shipcost + Needprice;
                    neededprice.Text = Convert.ToString(price);
                    
                    if (payedPrice.Text != null)
                    {
                            
                        if (decimal.Parse(payedPrice.Text)  >  price)
                        {
                            MessageBox.Show("المبلغ المطلوب اكثر من المستحق");
                            return;
                        }
                        else
                        {
                            paiyedPrice = (payedPrice.Text != null) ? decimal.Parse(payedPrice.Text) : 0;

                        }
                    }
                    else
                    {
                        MessageBox.Show("يجب ادخل المبلغ الي ستدفعه");
                        return;

                    }
                  //  paiyedPrice = (payedPrice.Text != null) ? decimal.Parse(payedPrice.Text) : 0;
                    remianPrice.Text = (remianPrice.Text != null) ? Convert.ToString(price - paiyedPrice) : "0";
                    rmainPrice = decimal.Parse(remianPrice.Text);


                    Thread.Sleep(3000);
                    
                    this.pay();

                }
                else if(processType == "payremainedprice")
                {

                    shipcost = (shippCost.Text != null) ? decimal.Parse(shippCost.Text) : 0;
                    Needprice = neededprice.Text != null ? decimal.Parse(neededprice.Text) : 0;
                    price = shipcost + Needprice;
                    neededprice.Text = Convert.ToString(price);
                    if(payedPrice.Text != null)
                    {

                        if (Decimal.Parse(payedPrice.Text) > price)
                        {
                            MessageBox.Show("المبلغ المطلوب اكثر من المستحق");
                            return;
                        }
                        else
                        {
                               paiyedPrice = (payedPrice.Text != null) ? decimal.Parse(payedPrice.Text) : 0;

                        }
                    }
                    else
                    {
                        MessageBox.Show("يجب ادخل المبلغ الي ستدفعه");
                        return;

                    }
                    remianPrice.Text = (remianPrice.Text != null) ? Convert.ToString(price - paiyedPrice) : "0";
                    rmainPrice = decimal.Parse(remianPrice.Text);


                    Thread.Sleep(3000);
                    updatedateBYpay();
                    
                 //   PMfrm.purchasesList1.DataSource = DB.TB_PURCHASES.ToList();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 

            }
        }


       

        private void payedPrice_TextChanged(object sender, EventArgs e)
        {
           /*if(int.Parse(payedPrice.Text) > int.Parse(neededprice.Text))
            {
                MessageBox.Show("المبلغ المطلوب اكثر من المستحق");
            }
            else
            {
                rmainPrice= int.Parse(remianPrice.Text) - int.Parse(neededprice.Text);
            }*/

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            currency =int.Parse(currency_List.SelectedValue.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void credit_CheckedChanged(object sender, EventArgs e)
        {
            if (credit.Checked)
            {
                
                MessageBox.Show("تنبية!!!سيتم تحويل البلغ آجل " ,"سداد آجل",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                payedPrice.Text = "0";
                remianPrice.Text = neededprice.Text;
                shippCost.Text = shippCost.Text != null ? shippCost.Text : "0";

            }
        }

        private void cache_CheckedChanged(object sender, EventArgs e)
        {
            if (cache.Checked)
            {
                shippCost.Text = shippCost.Text !=null? shippCost.Text : "0";
                payedPrice.Text = neededprice.Text;
                remianPrice.Text = "0";

            }
        }

        private void billprint_CheckedChanged(object sender, EventArgs e)
        {
            if(billprint.Checked)
            {
                printbill = true;

            }else if(!billprint.Checked)
            {
                printbill = false;
            }
        }
    }
}
