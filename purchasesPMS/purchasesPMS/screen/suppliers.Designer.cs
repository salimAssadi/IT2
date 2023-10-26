namespace purchasesPMS.screen
{
    partial class suppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(suppliers));
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.supplierlist = new System.Windows.Forms.DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.hidenid = new System.Windows.Forms.TextBox();
            this.remove = new Guna.UI2.WinForms.Guna2Button();
            this.suppliername = new Guna.UI2.WinForms.Guna2TextBox();
            this.edit = new Guna.UI2.WinForms.Guna2Button();
            this.ADD = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phoenNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.productcodeSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.supplieridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplieremailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBSUPPLIERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBPRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierlist)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBSUPPLIERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPRODUCTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(-5, 34);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(96, 49);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 10;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.supplierlist);
            this.guna2Panel2.Controls.Add(this.guna2Panel1);
            this.guna2Panel2.Location = new System.Drawing.Point(-5, 93);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(823, 251);
            this.guna2Panel2.TabIndex = 9;
            // 
            // supplierlist
            // 
            this.supplierlist.AutoGenerateColumns = false;
            this.supplierlist.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.supplierlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplieridDataGridViewTextBoxColumn,
            this.suppliernameDataGridViewTextBoxColumn,
            this.supplierphoneDataGridViewTextBoxColumn,
            this.supplieremailDataGridViewTextBoxColumn});
            this.supplierlist.DataSource = this.tBSUPPLIERSBindingSource;
            this.supplierlist.Location = new System.Drawing.Point(5, 2);
            this.supplierlist.Name = "supplierlist";
            this.supplierlist.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.supplierlist.Size = new System.Drawing.Size(444, 245);
            this.supplierlist.TabIndex = 0;
            this.supplierlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplierlist_CellContentClick);
            this.supplierlist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplierlist_CellDoubleClick);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.guna2Panel1.Controls.Add(this.hidenid);
            this.guna2Panel1.Controls.Add(this.remove);
            this.guna2Panel1.Controls.Add(this.suppliername);
            this.guna2Panel1.Controls.Add(this.edit);
            this.guna2Panel1.Controls.Add(this.ADD);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.phoenNumber);
            this.guna2Panel1.Controls.Add(this.email);
            this.guna2Panel1.Location = new System.Drawing.Point(451, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2Panel1.Size = new System.Drawing.Size(369, 244);
            this.guna2Panel1.TabIndex = 3;
            // 
            // hidenid
            // 
            this.hidenid.Location = new System.Drawing.Point(218, 41);
            this.hidenid.Name = "hidenid";
            this.hidenid.Size = new System.Drawing.Size(38, 20);
            this.hidenid.TabIndex = 5;
            this.hidenid.Visible = false;
            this.hidenid.TextChanged += new System.EventHandler(this.hidenid_TextChanged);
            // 
            // remove
            // 
            this.remove.AutoRoundedCorners = true;
            this.remove.BackColor = System.Drawing.Color.Transparent;
            this.remove.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.remove.BorderRadius = 15;
            this.remove.BorderThickness = 2;
            this.remove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.remove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.remove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.remove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.remove.FillColor = System.Drawing.Color.Red;
            this.remove.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.remove.ForeColor = System.Drawing.Color.White;
            this.remove.Location = new System.Drawing.Point(65, 196);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(86, 33);
            this.remove.TabIndex = 4;
            this.remove.Text = "تراجع";
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // suppliername
            // 
            this.suppliername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.suppliername.DefaultText = "";
            this.suppliername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.suppliername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.suppliername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.suppliername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.suppliername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.suppliername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.suppliername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.suppliername.Location = new System.Drawing.Point(81, 64);
            this.suppliername.Name = "suppliername";
            this.suppliername.PasswordChar = '\0';
            this.suppliername.PlaceholderText = "اسم المورد";
            this.suppliername.SelectedText = "";
            this.suppliername.Size = new System.Drawing.Size(175, 31);
            this.suppliername.TabIndex = 0;
            this.suppliername.TextChanged += new System.EventHandler(this.suppname_TextChanged);
            // 
            // edit
            // 
            this.edit.AutoRoundedCorners = true;
            this.edit.BackColor = System.Drawing.Color.Transparent;
            this.edit.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.edit.BorderRadius = 15;
            this.edit.BorderThickness = 2;
            this.edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.edit.FillColor = System.Drawing.Color.Lime;
            this.edit.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.Location = new System.Drawing.Point(170, 196);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(86, 33);
            this.edit.TabIndex = 4;
            this.edit.Text = "تعديل";
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // ADD
            // 
            this.ADD.AutoRoundedCorners = true;
            this.ADD.BackColor = System.Drawing.Color.Transparent;
            this.ADD.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.ADD.BorderRadius = 15;
            this.ADD.BorderThickness = 2;
            this.ADD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ADD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ADD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ADD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ADD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD.ForeColor = System.Drawing.Color.White;
            this.ADD.Location = new System.Drawing.Point(264, 196);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(86, 33);
            this.ADD.TabIndex = 4;
            this.ADD.Text = "إضافة";
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(271, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "رقم الهاتف";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(138, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "إضافة مورد";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(271, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "اسم المورد";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(271, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "البريد الالكتروني";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // phoenNumber
            // 
            this.phoenNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoenNumber.DefaultText = "رقم الهاتف";
            this.phoenNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoenNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoenNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoenNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoenNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoenNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phoenNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoenNumber.Location = new System.Drawing.Point(82, 137);
            this.phoenNumber.Name = "phoenNumber";
            this.phoenNumber.PasswordChar = '\0';
            this.phoenNumber.PlaceholderText = "سعر المنتج";
            this.phoenNumber.SelectedText = "";
            this.phoenNumber.Size = new System.Drawing.Size(174, 31);
            this.phoenNumber.TabIndex = 0;
            this.phoenNumber.TextChanged += new System.EventHandler(this.phoenNumber_TextChanged);
            // 
            // email
            // 
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.DefaultText = "البريد الالكتروني";
            this.email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.Location = new System.Drawing.Point(82, 100);
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.PlaceholderText = "اسم المنتج";
            this.email.SelectedText = "";
            this.email.Size = new System.Drawing.Size(174, 31);
            this.email.TabIndex = 0;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(632, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "بحث";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(366, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "ادارة الموردين";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // productcodeSearch
            // 
            this.productcodeSearch.BorderRadius = 10;
            this.productcodeSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productcodeSearch.DefaultText = "اسم المورد";
            this.productcodeSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productcodeSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productcodeSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productcodeSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productcodeSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productcodeSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productcodeSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productcodeSearch.Location = new System.Drawing.Point(668, 67);
            this.productcodeSearch.Name = "productcodeSearch";
            this.productcodeSearch.PasswordChar = '\0';
            this.productcodeSearch.PlaceholderText = "كود المنتج";
            this.productcodeSearch.SelectedText = "";
            this.productcodeSearch.Size = new System.Drawing.Size(145, 23);
            this.productcodeSearch.TabIndex = 6;
            // 
            // supplieridDataGridViewTextBoxColumn
            // 
            this.supplieridDataGridViewTextBoxColumn.DataPropertyName = "supplier_id";
            this.supplieridDataGridViewTextBoxColumn.HeaderText = "رقم المورد";
            this.supplieridDataGridViewTextBoxColumn.Name = "supplieridDataGridViewTextBoxColumn";
            // 
            // suppliernameDataGridViewTextBoxColumn
            // 
            this.suppliernameDataGridViewTextBoxColumn.DataPropertyName = "supplier_name";
            this.suppliernameDataGridViewTextBoxColumn.HeaderText = "اسم المورد";
            this.suppliernameDataGridViewTextBoxColumn.Name = "suppliernameDataGridViewTextBoxColumn";
            // 
            // supplierphoneDataGridViewTextBoxColumn
            // 
            this.supplierphoneDataGridViewTextBoxColumn.DataPropertyName = "supplier_phone";
            this.supplierphoneDataGridViewTextBoxColumn.HeaderText = "رقم الهاتف";
            this.supplierphoneDataGridViewTextBoxColumn.Name = "supplierphoneDataGridViewTextBoxColumn";
            // 
            // supplieremailDataGridViewTextBoxColumn
            // 
            this.supplieremailDataGridViewTextBoxColumn.DataPropertyName = "supplier_email";
            this.supplieremailDataGridViewTextBoxColumn.HeaderText = "البريد الالكتروني";
            this.supplieremailDataGridViewTextBoxColumn.Name = "supplieremailDataGridViewTextBoxColumn";
            // 
            // tBSUPPLIERSBindingSource
            // 
            this.tBSUPPLIERSBindingSource.DataSource = typeof(purchasesPMS.DB.TB_SUPPLIERS);
            // 
            // tBPRODUCTSBindingSource
            // 
            this.tBPRODUCTSBindingSource.DataSource = typeof(purchasesPMS.DB.TB_PRODUCTS);
            // 
            // suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 341);
            this.ControlBox = false;
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.productcodeSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "suppliers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supplierlist)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBSUPPLIERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPRODUCTSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.DataGridView supplierlist;
        private System.Windows.Forms.BindingSource tBPRODUCTSBindingSource;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button remove;
        private Guna.UI2.WinForms.Guna2TextBox suppliername;
        private Guna.UI2.WinForms.Guna2Button edit;
        private Guna.UI2.WinForms.Guna2Button ADD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox phoenNumber;
        private Guna.UI2.WinForms.Guna2TextBox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private Guna.UI2.WinForms.Guna2TextBox productcodeSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplieridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplieremailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tBSUPPLIERSBindingSource;
        private System.Windows.Forms.TextBox hidenid;
    }
}