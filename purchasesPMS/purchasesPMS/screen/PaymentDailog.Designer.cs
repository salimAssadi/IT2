namespace purchasesPMS.screen
{
    partial class PaymentDailog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PaymentPanel = new System.Windows.Forms.GroupBox();
            this.billprint = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cache = new System.Windows.Forms.RadioButton();
            this.credit = new System.Windows.Forms.RadioButton();
            this.cancelbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.currency_List = new System.Windows.Forms.ComboBox();
            this.tBCURRENCIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentMethod = new System.Windows.Forms.ComboBox();
            this.reference_no = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.shippCost = new System.Windows.Forms.TextBox();
            this.remianPrice = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.payedPrice = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.neededprice = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.PaymentPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBCURRENCIESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentPanel
            // 
            this.PaymentPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.PaymentPanel.Controls.Add(this.billprint);
            this.PaymentPanel.Controls.Add(this.groupBox1);
            this.PaymentPanel.Controls.Add(this.cancelbtn);
            this.PaymentPanel.Controls.Add(this.guna2Button1);
            this.PaymentPanel.Controls.Add(this.currency_List);
            this.PaymentPanel.Controls.Add(this.paymentMethod);
            this.PaymentPanel.Controls.Add(this.reference_no);
            this.PaymentPanel.Controls.Add(this.label2);
            this.PaymentPanel.Controls.Add(this.label3);
            this.PaymentPanel.Controls.Add(this.label1);
            this.PaymentPanel.Controls.Add(this.label26);
            this.PaymentPanel.Controls.Add(this.shippCost);
            this.PaymentPanel.Controls.Add(this.remianPrice);
            this.PaymentPanel.Controls.Add(this.label24);
            this.PaymentPanel.Controls.Add(this.payedPrice);
            this.PaymentPanel.Controls.Add(this.label23);
            this.PaymentPanel.Controls.Add(this.neededprice);
            this.PaymentPanel.Controls.Add(this.label22);
            this.PaymentPanel.Location = new System.Drawing.Point(2, 2);
            this.PaymentPanel.Name = "PaymentPanel";
            this.PaymentPanel.Size = new System.Drawing.Size(659, 214);
            this.PaymentPanel.TabIndex = 13;
            this.PaymentPanel.TabStop = false;
            this.PaymentPanel.Text = "الدفع";
            this.PaymentPanel.Enter += new System.EventHandler(this.PaymentPanel_Enter);
            // 
            // billprint
            // 
            this.billprint.AutoSize = true;
            this.billprint.Checked = true;
            this.billprint.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.billprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.billprint.ForeColor = System.Drawing.Color.Transparent;
            this.billprint.Location = new System.Drawing.Point(6, 186);
            this.billprint.Name = "billprint";
            this.billprint.Size = new System.Drawing.Size(118, 22);
            this.billprint.TabIndex = 8;
            this.billprint.Text = "طباعة الفاتورة ";
            this.billprint.UseVisualStyleBackColor = true;
            this.billprint.CheckedChanged += new System.EventHandler(this.billprint_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cache);
            this.groupBox1.Controls.Add(this.credit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(13, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 40);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // cache
            // 
            this.cache.AutoSize = true;
            this.cache.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cache.ForeColor = System.Drawing.SystemColors.Control;
            this.cache.Location = new System.Drawing.Point(100, 12);
            this.cache.Name = "cache";
            this.cache.Size = new System.Drawing.Size(45, 24);
            this.cache.TabIndex = 1;
            this.cache.TabStop = true;
            this.cache.Text = "نقداً";
            this.cache.UseVisualStyleBackColor = true;
            this.cache.CheckedChanged += new System.EventHandler(this.cache_CheckedChanged);
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit.ForeColor = System.Drawing.SystemColors.Control;
            this.credit.Location = new System.Drawing.Point(6, 11);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(47, 24);
            this.credit.TabIndex = 0;
            this.credit.TabStop = true;
            this.credit.Text = "آجل";
            this.credit.UseVisualStyleBackColor = true;
            this.credit.CheckedChanged += new System.EventHandler(this.credit_CheckedChanged);
            // 
            // cancelbtn
            // 
            this.cancelbtn.AutoRoundedCorners = true;
            this.cancelbtn.BorderRadius = 14;
            this.cancelbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelbtn.FillColor = System.Drawing.Color.DarkViolet;
            this.cancelbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cancelbtn.ForeColor = System.Drawing.Color.White;
            this.cancelbtn.Location = new System.Drawing.Point(323, 165);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(82, 31);
            this.cancelbtn.TabIndex = 6;
            this.cancelbtn.Text = "إلغاء";
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 14;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Lime;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(226, 165);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(82, 31);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Text = "دفع";
            this.guna2Button1.Click += new System.EventHandler(this.paybtn_Click);
            // 
            // currency_List
            // 
            this.currency_List.DataSource = this.tBCURRENCIESBindingSource;
            this.currency_List.DisplayMember = "cur_name";
            this.currency_List.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currency_List.FormattingEnabled = true;
            this.currency_List.Location = new System.Drawing.Point(434, 85);
            this.currency_List.Name = "currency_List";
            this.currency_List.Size = new System.Drawing.Size(121, 21);
            this.currency_List.TabIndex = 5;
            this.currency_List.ValueMember = "cur_id";
            this.currency_List.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tBCURRENCIESBindingSource
            // 
            this.tBCURRENCIESBindingSource.DataSource = typeof(purchasesPMS.DB.TB_CURRENCIES);
            // 
            // paymentMethod
            // 
            this.paymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentMethod.FormattingEnabled = true;
            this.paymentMethod.Items.AddRange(new object[] {
            "نقدا",
            "شبكات"});
            this.paymentMethod.Location = new System.Drawing.Point(14, 85);
            this.paymentMethod.Name = "paymentMethod";
            this.paymentMethod.Size = new System.Drawing.Size(121, 21);
            this.paymentMethod.TabIndex = 4;
            // 
            // reference_no
            // 
            this.reference_no.BackColor = System.Drawing.SystemColors.Control;
            this.reference_no.Enabled = false;
            this.reference_no.Location = new System.Drawing.Point(307, 17);
            this.reference_no.Multiline = true;
            this.reference_no.Name = "reference_no";
            this.reference_no.Size = new System.Drawing.Size(75, 31);
            this.reference_no.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(389, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "دفع  فاتورة مشتريات ذات الرقم المرجعي";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(561, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "العملة";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(151, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "طريقة الدفع";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label26.Location = new System.Drawing.Point(336, 88);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(45, 18);
            this.label26.TabIndex = 1;
            this.label26.Text = "الشحن";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // shippCost
            // 
            this.shippCost.Location = new System.Drawing.Point(233, 85);
            this.shippCost.Multiline = true;
            this.shippCost.Name = "shippCost";
            this.shippCost.Size = new System.Drawing.Size(97, 30);
            this.shippCost.TabIndex = 0;
            // 
            // remianPrice
            // 
            this.remianPrice.Location = new System.Drawing.Point(14, 122);
            this.remianPrice.Multiline = true;
            this.remianPrice.Name = "remianPrice";
            this.remianPrice.Size = new System.Drawing.Size(106, 24);
            this.remianPrice.TabIndex = 0;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label24.Location = new System.Drawing.Point(126, 128);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 18);
            this.label24.TabIndex = 1;
            this.label24.Text = "المتبقي";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // payedPrice
            // 
            this.payedPrice.Location = new System.Drawing.Point(207, 124);
            this.payedPrice.Multiline = true;
            this.payedPrice.Name = "payedPrice";
            this.payedPrice.Size = new System.Drawing.Size(101, 26);
            this.payedPrice.TabIndex = 0;
            this.payedPrice.TextChanged += new System.EventHandler(this.payedPrice_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label23.Location = new System.Drawing.Point(314, 128);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(94, 18);
            this.label23.TabIndex = 1;
            this.label23.Text = "المبلغ االمدفوع";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // neededprice
            // 
            this.neededprice.Location = new System.Drawing.Point(418, 122);
            this.neededprice.Multiline = true;
            this.neededprice.Name = "neededprice";
            this.neededprice.Size = new System.Drawing.Size(117, 27);
            this.neededprice.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label22.Location = new System.Drawing.Point(541, 125);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 18);
            this.label22.TabIndex = 1;
            this.label22.Text = "المبلغ المطلوب";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // PaymentDailog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(659, 219);
            this.Controls.Add(this.PaymentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentDailog";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عملية الدفع";
            this.Load += new System.EventHandler(this.PaymentDailog_Load);
            this.PaymentPanel.ResumeLayout(false);
            this.PaymentPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBCURRENCIESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PaymentPanel;
        private System.Windows.Forms.TextBox reference_no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox shippCost;
        private System.Windows.Forms.TextBox remianPrice;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox payedPrice;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox neededprice;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox paymentMethod;
        private System.Windows.Forms.ComboBox currency_List;
        private System.Windows.Forms.BindingSource tBCURRENCIESBindingSource;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button cancelbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cache;
        private System.Windows.Forms.RadioButton credit;
        private System.Windows.Forms.CheckBox billprint;
    }
}