
namespace user_interface
{
    partial class Add_items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_items));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pimageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffee_ShopDataSet = new user_interface.Coffee_ShopDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pid = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_pdec = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_pname = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_add = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_back = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btn_browse = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btn_save = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientCircleButton1 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton2 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.productTableAdapter = new user_interface.Coffee_ShopDataSetTableAdapters.ProductTableAdapter();
            this.coffee_ShopDataSet3 = new user_interface.Coffee_ShopDataSet3();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter1 = new user_interface.Coffee_ShopDataSet3TableAdapters.ProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffee_ShopDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffee_ShopDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIDDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.pimageDataGridViewImageColumn,
            this.pnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(172, 334);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(723, 288);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "P_ID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "P_ID";
            this.pIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            this.pIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // pimageDataGridViewImageColumn
            // 
            this.pimageDataGridViewImageColumn.DataPropertyName = "pimage";
            this.pimageDataGridViewImageColumn.HeaderText = "pimage";
            this.pimageDataGridViewImageColumn.MinimumWidth = 6;
            this.pimageDataGridViewImageColumn.Name = "pimageDataGridViewImageColumn";
            this.pimageDataGridViewImageColumn.Width = 125;
            // 
            // pnameDataGridViewTextBoxColumn
            // 
            this.pnameDataGridViewTextBoxColumn.DataPropertyName = "pname";
            this.pnameDataGridViewTextBoxColumn.HeaderText = "pname";
            this.pnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pnameDataGridViewTextBoxColumn.Name = "pnameDataGridViewTextBoxColumn";
            this.pnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.coffee_ShopDataSet;
            // 
            // coffee_ShopDataSet
            // 
            this.coffee_ShopDataSet.DataSetName = "Coffee_ShopDataSet";
            this.coffee_ShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(129, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "Product Id";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_pid
            // 
            this.txt_pid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(86)))), ((int)(((byte)(52)))));
            this.txt_pid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pid.DefaultText = "";
            this.txt_pid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pid.DisabledState.Parent = this.txt_pid;
            this.txt_pid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.txt_pid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pid.FocusedState.Parent = this.txt_pid;
            this.txt_pid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(86)))), ((int)(((byte)(52)))));
            this.txt_pid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pid.HoverState.Parent = this.txt_pid;
            this.txt_pid.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_pid.IconLeft")));
            this.txt_pid.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.txt_pid.Location = new System.Drawing.Point(320, 107);
            this.txt_pid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_pid.Name = "txt_pid";
            this.txt_pid.PasswordChar = '\0';
            this.txt_pid.PlaceholderText = "";
            this.txt_pid.SelectedText = "";
            this.txt_pid.ShadowDecoration.Parent = this.txt_pid;
            this.txt_pid.Size = new System.Drawing.Size(199, 28);
            this.txt_pid.TabIndex = 14;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.txt_pid;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.guna2CustomGradientPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 661);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1013, 28);
            this.panel3.TabIndex = 10;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(140)))), ((int)(((byte)(52)))));
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.Parent = this.guna2CustomGradientPanel2;
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(1013, 28);
            this.guna2CustomGradientPanel2.TabIndex = 7;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 15;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 15;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(129, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Product Price";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(129, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "Product Description";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(129, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "Product Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_price
            // 
            this.txt_price.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(86)))), ((int)(((byte)(52)))));
            this.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_price.DefaultText = "";
            this.txt_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_price.DisabledState.Parent = this.txt_price;
            this.txt_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_price.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.txt_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price.FocusedState.Parent = this.txt_price;
            this.txt_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(86)))), ((int)(((byte)(52)))));
            this.txt_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price.HoverState.Parent = this.txt_price;
            this.txt_price.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_price.IconLeft")));
            this.txt_price.Location = new System.Drawing.Point(320, 225);
            this.txt_price.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_price.Name = "txt_price";
            this.txt_price.PasswordChar = '\0';
            this.txt_price.PlaceholderText = "";
            this.txt_price.SelectedText = "";
            this.txt_price.ShadowDecoration.Parent = this.txt_price;
            this.txt_price.Size = new System.Drawing.Size(199, 28);
            this.txt_price.TabIndex = 20;
            // 
            // txt_pdec
            // 
            this.txt_pdec.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(86)))), ((int)(((byte)(52)))));
            this.txt_pdec.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pdec.DefaultText = "";
            this.txt_pdec.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pdec.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pdec.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pdec.DisabledState.Parent = this.txt_pdec;
            this.txt_pdec.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pdec.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.txt_pdec.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pdec.FocusedState.Parent = this.txt_pdec;
            this.txt_pdec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(86)))), ((int)(((byte)(52)))));
            this.txt_pdec.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pdec.HoverState.Parent = this.txt_pdec;
            this.txt_pdec.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_pdec.IconLeft")));
            this.txt_pdec.Location = new System.Drawing.Point(320, 178);
            this.txt_pdec.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_pdec.Name = "txt_pdec";
            this.txt_pdec.PasswordChar = '\0';
            this.txt_pdec.PlaceholderText = "";
            this.txt_pdec.SelectedText = "";
            this.txt_pdec.ShadowDecoration.Parent = this.txt_pdec;
            this.txt_pdec.Size = new System.Drawing.Size(199, 28);
            this.txt_pdec.TabIndex = 22;
            // 
            // txt_pname
            // 
            this.txt_pname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(86)))), ((int)(((byte)(52)))));
            this.txt_pname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pname.DefaultText = "";
            this.txt_pname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pname.DisabledState.Parent = this.txt_pname;
            this.txt_pname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.txt_pname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pname.FocusedState.Parent = this.txt_pname;
            this.txt_pname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(86)))), ((int)(((byte)(52)))));
            this.txt_pname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pname.HoverState.Parent = this.txt_pname;
            this.txt_pname.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_pname.IconLeft")));
            this.txt_pname.Location = new System.Drawing.Point(320, 143);
            this.txt_pname.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_pname.Name = "txt_pname";
            this.txt_pname.PasswordChar = '\0';
            this.txt_pname.PlaceholderText = "";
            this.txt_pname.SelectedText = "";
            this.txt_pname.ShadowDecoration.Parent = this.txt_pname;
            this.txt_pname.Size = new System.Drawing.Size(199, 28);
            this.txt_pname.TabIndex = 23;
            // 
            // btn_add
            // 
            this.btn_add.Animated = true;
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.CheckedState.Parent = this.btn_add;
            this.btn_add.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.CustomImages.Image")));
            this.btn_add.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_add.CustomImages.Parent = this.btn_add;
            this.btn_add.FillColor = System.Drawing.Color.Empty;
            this.btn_add.FillColor2 = System.Drawing.Color.Empty;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(64)))), ((int)(((byte)(7)))));
            this.btn_add.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btn_add.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_add.HoverState.Parent = this.btn_add;
            this.btn_add.Location = new System.Drawing.Point(864, 114);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.ShadowDecoration.Parent = this.btn_add;
            this.btn_add.Size = new System.Drawing.Size(143, 60);
            this.btn_add.TabIndex = 24;
            this.btn_add.Text = "ADD";
            this.btn_add.UseTransparentBackground = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.CheckedState.Parent = this.btn_back;
            this.btn_back.CustomImages.Parent = this.btn_back;
            this.btn_back.FillColor = System.Drawing.Color.Transparent;
            this.btn_back.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.HoverState.Parent = this.btn_back;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.Location = new System.Drawing.Point(911, 2);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_back.ShadowDecoration.Parent = this.btn_back;
            this.btn_back.Size = new System.Drawing.Size(87, 71);
            this.btn_back.TabIndex = 25;
            this.btn_back.Text = "Back";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.Animated = true;
            this.btn_browse.BackColor = System.Drawing.Color.Transparent;
            this.btn_browse.CheckedState.Parent = this.btn_browse;
            this.btn_browse.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("btn_browse.CustomImages.Image")));
            this.btn_browse.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_browse.CustomImages.Parent = this.btn_browse;
            this.btn_browse.FillColor = System.Drawing.Color.Empty;
            this.btn_browse.FillColor2 = System.Drawing.Color.Empty;
            this.btn_browse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_browse.ForeColor = System.Drawing.Color.White;
            this.btn_browse.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(64)))), ((int)(((byte)(7)))));
            this.btn_browse.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btn_browse.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_browse.HoverState.Parent = this.btn_browse;
            this.btn_browse.Location = new System.Drawing.Point(864, 193);
            this.btn_browse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.ShadowDecoration.Parent = this.btn_browse;
            this.btn_browse.Size = new System.Drawing.Size(143, 60);
            this.btn_browse.TabIndex = 26;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseTransparentBackground = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(555, 85);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 196);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(140)))), ((int)(((byte)(52)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 28);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(963, 6);
            this.guna2CustomGradientPanel1.TabIndex = 28;
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(140)))), ((int)(((byte)(52)))));
            this.guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel3.FillColor3 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(0, 330);
            this.guna2CustomGradientPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.ShadowDecoration.Parent = this.guna2CustomGradientPanel3;
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(963, 6);
            this.guna2CustomGradientPanel3.TabIndex = 29;
            // 
            // btn_save
            // 
            this.btn_save.Animated = true;
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.CheckedState.Parent = this.btn_save;
            this.btn_save.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.CustomImages.Image")));
            this.btn_save.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_save.CustomImages.Parent = this.btn_save;
            this.btn_save.FillColor = System.Drawing.Color.Empty;
            this.btn_save.FillColor2 = System.Drawing.Color.Empty;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(64)))), ((int)(((byte)(7)))));
            this.btn_save.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btn_save.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_save.HoverState.Parent = this.btn_save;
            this.btn_save.Location = new System.Drawing.Point(864, 447);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.ShadowDecoration.Parent = this.btn_save;
            this.btn_save.Size = new System.Drawing.Size(143, 60);
            this.btn_save.TabIndex = 30;
            this.btn_save.Text = "Save";
            this.btn_save.UseTransparentBackground = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // guna2GradientCircleButton1
            // 
            this.guna2GradientCircleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2GradientCircleButton1.CheckedState.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.CustomImages.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientCircleButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2GradientCircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton1.HoverState.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientCircleButton1.Image")));
            this.guna2GradientCircleButton1.Location = new System.Drawing.Point(16, 139);
            this.guna2GradientCircleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2GradientCircleButton1.Name = "guna2GradientCircleButton1";
            this.guna2GradientCircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton1.ShadowDecoration.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.Size = new System.Drawing.Size(87, 71);
            this.guna2GradientCircleButton1.TabIndex = 31;
            this.guna2GradientCircleButton1.Text = "Back";
            // 
            // guna2GradientCircleButton2
            // 
            this.guna2GradientCircleButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2GradientCircleButton2.CheckedState.Parent = this.guna2GradientCircleButton2;
            this.guna2GradientCircleButton2.CustomImages.Parent = this.guna2GradientCircleButton2;
            this.guna2GradientCircleButton2.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientCircleButton2.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientCircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2GradientCircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton2.HoverState.Parent = this.guna2GradientCircleButton2;
            this.guna2GradientCircleButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientCircleButton2.Image")));
            this.guna2GradientCircleButton2.Location = new System.Drawing.Point(16, 462);
            this.guna2GradientCircleButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2GradientCircleButton2.Name = "guna2GradientCircleButton2";
            this.guna2GradientCircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton2.ShadowDecoration.Parent = this.guna2GradientCircleButton2;
            this.guna2GradientCircleButton2.Size = new System.Drawing.Size(87, 71);
            this.guna2GradientCircleButton2.TabIndex = 32;
            this.guna2GradientCircleButton2.Text = "Back";
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // coffee_ShopDataSet3
            // 
            this.coffee_ShopDataSet3.DataSetName = "Coffee_ShopDataSet3";
            this.coffee_ShopDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.coffee_ShopDataSet3;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // Add_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1013, 689);
            this.Controls.Add(this.guna2GradientCircleButton2);
            this.Controls.Add(this.guna2GradientCircleButton1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.guna2CustomGradientPanel3);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_pname);
            this.Controls.Add(this.txt_pdec);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_pid);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Add_items";
            this.Text = "Add_items";
            this.Load += new System.EventHandler(this.Add_items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffee_ShopDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffee_ShopDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_pid;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_price;
        private Guna.UI2.WinForms.Guna2TextBox txt_pdec;
        private Guna.UI2.WinForms.Guna2TextBox txt_pname;
        private Guna.UI2.WinForms.Guna2GradientButton btn_add;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btn_back;
        private Guna.UI2.WinForms.Guna2GradientButton btn_browse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private Guna.UI2.WinForms.Guna2GradientButton btn_save;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton2;
        private Coffee_ShopDataSet coffee_ShopDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Coffee_ShopDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pimageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private Coffee_ShopDataSet3 coffee_ShopDataSet3;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private Coffee_ShopDataSet3TableAdapters.ProductTableAdapter productTableAdapter1;
    }
}