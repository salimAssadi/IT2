namespace purchasesPMS.screen
{
    partial class PoructForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoructForm));
            this.productList = new System.Windows.Forms.DataGridView();
            this.productcodeSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.remove = new Guna.UI2.WinForms.Guna2Button();
            this.prod_code = new Guna.UI2.WinForms.Guna2TextBox();
            this.edit = new Guna.UI2.WinForms.Guna2Button();
            this.ADD = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productsSN = new Guna.UI2.WinForms.Guna2TextBox();
            this.productPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.productName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.prodidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBPRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productList)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPRODUCTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productList
            // 
            this.productList.AutoGenerateColumns = false;
            this.productList.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.productList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodidDataGridViewTextBoxColumn,
            this.prodnameDataGridViewTextBoxColumn,
            this.unitepriceDataGridViewTextBoxColumn,
            this.sNDataGridViewTextBoxColumn});
            this.productList.DataSource = this.tBPRODUCTSBindingSource;
            this.productList.Location = new System.Drawing.Point(5, 2);
            this.productList.Name = "productList";
            this.productList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.productList.Size = new System.Drawing.Size(444, 245);
            this.productList.TabIndex = 0;
            this.productList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productList_CellContentClick);
            this.productList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productList_CellDoubleClick);
            // 
            // productcodeSearch
            // 
            this.productcodeSearch.BorderRadius = 10;
            this.productcodeSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productcodeSearch.DefaultText = "";
            this.productcodeSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productcodeSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productcodeSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productcodeSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productcodeSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productcodeSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productcodeSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productcodeSearch.Location = new System.Drawing.Point(677, 42);
            this.productcodeSearch.Name = "productcodeSearch";
            this.productcodeSearch.PasswordChar = '\0';
            this.productcodeSearch.PlaceholderText = "كود المنتج";
            this.productcodeSearch.SelectedText = "";
            this.productcodeSearch.Size = new System.Drawing.Size(145, 23);
            this.productcodeSearch.TabIndex = 0;
            this.productcodeSearch.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.guna2Panel1.Controls.Add(this.remove);
            this.guna2Panel1.Controls.Add(this.prod_code);
            this.guna2Panel1.Controls.Add(this.edit);
            this.guna2Panel1.Controls.Add(this.ADD);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.productsSN);
            this.guna2Panel1.Controls.Add(this.productPrice);
            this.guna2Panel1.Controls.Add(this.productName);
            this.guna2Panel1.Location = new System.Drawing.Point(451, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2Panel1.Size = new System.Drawing.Size(369, 244);
            this.guna2Panel1.TabIndex = 3;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
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
            // prod_code
            // 
            this.prod_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prod_code.DefaultText = "";
            this.prod_code.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prod_code.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prod_code.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prod_code.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prod_code.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prod_code.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prod_code.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prod_code.Location = new System.Drawing.Point(94, 33);
            this.prod_code.Name = "prod_code";
            this.prod_code.PasswordChar = '\0';
            this.prod_code.PlaceholderText = "كود المنتج";
            this.prod_code.SelectedText = "";
            this.prod_code.Size = new System.Drawing.Size(175, 31);
            this.prod_code.TabIndex = 0;
            this.prod_code.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
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
            this.edit.Location = new System.Drawing.Point(157, 196);
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
            this.ADD.Location = new System.Drawing.Point(249, 196);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(86, 33);
            this.ADD.TabIndex = 4;
            this.ADD.Text = "إضافة";
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(284, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "الرقم التسلسلي";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(284, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "سعر المنتج";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(157, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "إضافة منتج";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(284, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "كود المنتح";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(284, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم المنتح";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productsSN
            // 
            this.productsSN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productsSN.DefaultText = "";
            this.productsSN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productsSN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productsSN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productsSN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productsSN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productsSN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productsSN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productsSN.Location = new System.Drawing.Point(95, 143);
            this.productsSN.Name = "productsSN";
            this.productsSN.PasswordChar = '\0';
            this.productsSN.PlaceholderText = "الرقم التسلسلي";
            this.productsSN.SelectedText = "";
            this.productsSN.Size = new System.Drawing.Size(174, 31);
            this.productsSN.TabIndex = 0;
            this.productsSN.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // productPrice
            // 
            this.productPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productPrice.DefaultText = "";
            this.productPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productPrice.Location = new System.Drawing.Point(95, 106);
            this.productPrice.Name = "productPrice";
            this.productPrice.PasswordChar = '\0';
            this.productPrice.PlaceholderText = "سعر المنتج";
            this.productPrice.SelectedText = "";
            this.productPrice.Size = new System.Drawing.Size(174, 31);
            this.productPrice.TabIndex = 0;
            this.productPrice.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // productName
            // 
            this.productName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productName.DefaultText = "";
            this.productName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productName.Location = new System.Drawing.Point(95, 69);
            this.productName.Name = "productName";
            this.productName.PasswordChar = '\0';
            this.productName.PlaceholderText = "اسم المنتج";
            this.productName.SelectedText = "";
            this.productName.Size = new System.Drawing.Size(174, 31);
            this.productName.TabIndex = 0;
            this.productName.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(641, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "بحث";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.productList);
            this.guna2Panel2.Controls.Add(this.guna2Panel1);
            this.guna2Panel2.Location = new System.Drawing.Point(4, 68);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(823, 251);
            this.guna2Panel2.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(375, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "ادارة المنتجات";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(4, 9);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(96, 49);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 5;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // prodidDataGridViewTextBoxColumn
            // 
            this.prodidDataGridViewTextBoxColumn.DataPropertyName = "Prod_id";
            this.prodidDataGridViewTextBoxColumn.HeaderText = "كود المنتج";
            this.prodidDataGridViewTextBoxColumn.Name = "prodidDataGridViewTextBoxColumn";
            // 
            // prodnameDataGridViewTextBoxColumn
            // 
            this.prodnameDataGridViewTextBoxColumn.DataPropertyName = "Prod_name";
            this.prodnameDataGridViewTextBoxColumn.HeaderText = "اسم المنتج";
            this.prodnameDataGridViewTextBoxColumn.Name = "prodnameDataGridViewTextBoxColumn";
            // 
            // unitepriceDataGridViewTextBoxColumn
            // 
            this.unitepriceDataGridViewTextBoxColumn.DataPropertyName = "Unite_price";
            this.unitepriceDataGridViewTextBoxColumn.HeaderText = "سعر المنتج";
            this.unitepriceDataGridViewTextBoxColumn.Name = "unitepriceDataGridViewTextBoxColumn";
            // 
            // sNDataGridViewTextBoxColumn
            // 
            this.sNDataGridViewTextBoxColumn.DataPropertyName = "SN";
            this.sNDataGridViewTextBoxColumn.HeaderText = "الرقم التسلسلي";
            this.sNDataGridViewTextBoxColumn.Name = "sNDataGridViewTextBoxColumn";
            // 
            // tBPRODUCTSBindingSource
            // 
            this.tBPRODUCTSBindingSource.DataSource = typeof(purchasesPMS.DB.TB_PRODUCTS);
            // 
            // PoructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 324);
            this.ControlBox = false;
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.productcodeSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PoructForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PoructForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productList)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPRODUCTSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView productList;
        private System.Windows.Forms.BindingSource tBPRODUCTSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2TextBox productcodeSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox productsSN;
        private Guna.UI2.WinForms.Guna2TextBox productPrice;
        private Guna.UI2.WinForms.Guna2TextBox productName;
        private Guna.UI2.WinForms.Guna2Button ADD;
        private Guna.UI2.WinForms.Guna2Button remove;
        private Guna.UI2.WinForms.Guna2Button edit;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox prod_code;
        private System.Windows.Forms.Label label7;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}