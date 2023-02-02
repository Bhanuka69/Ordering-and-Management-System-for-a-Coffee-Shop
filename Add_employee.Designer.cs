
namespace user_interface
{
    partial class Add_employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_employee));
            this.employee_grid = new System.Windows.Forms.DataGridView();
            this.btn_back = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btn_new = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_address = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_salary = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_role = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txt_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_insert = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_update = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_delete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_clear = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.employee_grid)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // employee_grid
            // 
            this.employee_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_grid.Location = new System.Drawing.Point(323, 54);
            this.employee_grid.Name = "employee_grid";
            this.employee_grid.Size = new System.Drawing.Size(455, 281);
            this.employee_grid.TabIndex = 26;
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
            this.btn_back.Location = new System.Drawing.Point(723, 1);
            this.btn_back.Name = "btn_back";
            this.btn_back.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_back.ShadowDecoration.Parent = this.btn_back;
            this.btn_back.Size = new System.Drawing.Size(65, 58);
            this.btn_back.TabIndex = 39;
            this.btn_back.Text = "Back";
            // 
            // btn_new
            // 
            this.btn_new.Animated = true;
            this.btn_new.BackColor = System.Drawing.Color.Transparent;
            this.btn_new.CheckedState.Parent = this.btn_new;
            this.btn_new.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("Btn_food.CustomImages.Image")));
            this.btn_new.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_new.CustomImages.Parent = this.btn_new;
            this.btn_new.FillColor = System.Drawing.Color.Empty;
            this.btn_new.FillColor2 = System.Drawing.Color.Empty;
            this.btn_new.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(64)))), ((int)(((byte)(7)))));
            this.btn_new.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btn_new.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_new.HoverState.Parent = this.btn_new;
            this.btn_new.Location = new System.Drawing.Point(24, 359);
            this.btn_new.Name = "btn_new";
            this.btn_new.ShadowDecoration.Parent = this.btn_new;
            this.btn_new.Size = new System.Drawing.Size(107, 49);
            this.btn_new.TabIndex = 38;
            this.btn_new.Text = "NEW";
            this.btn_new.UseTransparentBackground = true;
            // 
            // txt_name
            // 
            this.txt_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(86)))), ((int)(((byte)(52)))));
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.DefaultText = "";
            this.txt_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.DisabledState.Parent = this.txt_name;
            this.txt_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.txt_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.FocusedState.Parent = this.txt_name;
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(86)))), ((int)(((byte)(52)))));
            this.txt_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.HoverState.Parent = this.txt_name;
            this.txt_name.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_name.IconLeft")));
            this.txt_name.Location = new System.Drawing.Point(146, 119);
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PlaceholderText = "";
            this.txt_name.SelectedText = "";
            this.txt_name.ShadowDecoration.Parent = this.txt_name;
            this.txt_name.Size = new System.Drawing.Size(149, 23);
            this.txt_name.TabIndex = 37;
            // 
            // txt_address
            // 
            this.txt_address.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(86)))), ((int)(((byte)(52)))));
            this.txt_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_address.DefaultText = "";
            this.txt_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address.DisabledState.Parent = this.txt_address;
            this.txt_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.txt_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address.FocusedState.Parent = this.txt_address;
            this.txt_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(86)))), ((int)(((byte)(52)))));
            this.txt_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address.HoverState.Parent = this.txt_address;
            this.txt_address.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_address.IconLeft")));
            this.txt_address.Location = new System.Drawing.Point(146, 180);
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.PlaceholderText = "";
            this.txt_address.SelectedText = "";
            this.txt_address.ShadowDecoration.Parent = this.txt_address;
            this.txt_address.Size = new System.Drawing.Size(149, 23);
            this.txt_address.TabIndex = 36;
            // 
            // txt_salary
            // 
            this.txt_salary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(86)))), ((int)(((byte)(52)))));
            this.txt_salary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_salary.DefaultText = "";
            this.txt_salary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_salary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_salary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_salary.DisabledState.Parent = this.txt_salary;
            this.txt_salary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_salary.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.txt_salary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_salary.FocusedState.Parent = this.txt_salary;
            this.txt_salary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(86)))), ((int)(((byte)(52)))));
            this.txt_salary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_salary.HoverState.Parent = this.txt_salary;
            this.txt_salary.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_salary.IconLeft")));
            this.txt_salary.Location = new System.Drawing.Point(146, 232);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.PasswordChar = '\0';
            this.txt_salary.PlaceholderText = "";
            this.txt_salary.SelectedText = "";
            this.txt_salary.ShadowDecoration.Parent = this.txt_salary;
            this.txt_salary.Size = new System.Drawing.Size(149, 23);
            this.txt_salary.TabIndex = 35;
            // 
            // txt_role
            // 
            this.txt_role.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(86)))), ((int)(((byte)(52)))));
            this.txt_role.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_role.DefaultText = "";
            this.txt_role.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_role.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_role.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_role.DisabledState.Parent = this.txt_role;
            this.txt_role.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_role.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.txt_role.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_role.FocusedState.Parent = this.txt_role;
            this.txt_role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(86)))), ((int)(((byte)(52)))));
            this.txt_role.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_role.HoverState.Parent = this.txt_role;
            this.txt_role.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_role.IconLeft")));
            this.txt_role.Location = new System.Drawing.Point(146, 278);
            this.txt_role.Name = "txt_role";
            this.txt_role.PasswordChar = '\0';
            this.txt_role.PlaceholderText = "";
            this.txt_role.SelectedText = "";
            this.txt_role.ShadowDecoration.Parent = this.txt_role;
            this.txt_role.Size = new System.Drawing.Size(149, 23);
            this.txt_role.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 26);
            this.label5.TabIndex = 33;
            this.label5.Text = "Employee name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 26);
            this.label4.TabIndex = 32;
            this.label4.Text = "Address";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(12, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "Salary";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 15;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 15;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(140)))), ((int)(((byte)(52)))));
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.Parent = this.guna2CustomGradientPanel2;
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(800, 23);
            this.guna2CustomGradientPanel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.guna2CustomGradientPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 427);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 23);
            this.panel3.TabIndex = 27;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.txt_id;
            // 
            // txt_id
            // 
            this.txt_id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(86)))), ((int)(((byte)(52)))));
            this.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.DefaultText = "";
            this.txt_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.DisabledState.Parent = this.txt_id;
            this.txt_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.txt_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.FocusedState.Parent = this.txt_id;
            this.txt_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(86)))), ((int)(((byte)(52)))));
            this.txt_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.HoverState.Parent = this.txt_id;
            this.txt_id.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_id.IconLeft")));
            this.txt_id.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.txt_id.Location = new System.Drawing.Point(146, 57);
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.PlaceholderText = "";
            this.txt_id.SelectedText = "";
            this.txt_id.ShadowDecoration.Parent = this.txt_id;
            this.txt_id.Size = new System.Drawing.Size(149, 23);
            this.txt_id.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "Role";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 26);
            this.label3.TabIndex = 29;
            this.label3.Text = "Employee ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_insert
            // 
            this.btn_insert.Animated = true;
            this.btn_insert.BackColor = System.Drawing.Color.Transparent;
            this.btn_insert.CheckedState.Parent = this.btn_insert;
            this.btn_insert.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton1.CustomImages.Image")));
            this.btn_insert.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_insert.CustomImages.Parent = this.btn_insert;
            this.btn_insert.FillColor = System.Drawing.Color.Empty;
            this.btn_insert.FillColor2 = System.Drawing.Color.Empty;
            this.btn_insert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_insert.ForeColor = System.Drawing.Color.White;
            this.btn_insert.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(64)))), ((int)(((byte)(7)))));
            this.btn_insert.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btn_insert.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_insert.HoverState.Parent = this.btn_insert;
            this.btn_insert.Location = new System.Drawing.Point(123, 359);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.ShadowDecoration.Parent = this.btn_insert;
            this.btn_insert.Size = new System.Drawing.Size(107, 49);
            this.btn_insert.TabIndex = 40;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.UseTransparentBackground = true;
            // 
            // btn_update
            // 
            this.btn_update.Animated = true;
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.CheckedState.Parent = this.btn_update;
            this.btn_update.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton2.CustomImages.Image")));
            this.btn_update.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_update.CustomImages.Parent = this.btn_update;
            this.btn_update.FillColor = System.Drawing.Color.Empty;
            this.btn_update.FillColor2 = System.Drawing.Color.Empty;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(64)))), ((int)(((byte)(7)))));
            this.btn_update.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btn_update.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_update.HoverState.Parent = this.btn_update;
            this.btn_update.Location = new System.Drawing.Point(236, 359);
            this.btn_update.Name = "btn_update";
            this.btn_update.ShadowDecoration.Parent = this.btn_update;
            this.btn_update.Size = new System.Drawing.Size(107, 49);
            this.btn_update.TabIndex = 41;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseTransparentBackground = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Animated = true;
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.CheckedState.Parent = this.btn_delete;
            this.btn_delete.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton3.CustomImages.Image")));
            this.btn_delete.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_delete.CustomImages.Parent = this.btn_delete;
            this.btn_delete.FillColor = System.Drawing.Color.Empty;
            this.btn_delete.FillColor2 = System.Drawing.Color.Empty;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(64)))), ((int)(((byte)(7)))));
            this.btn_delete.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btn_delete.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_delete.HoverState.Parent = this.btn_delete;
            this.btn_delete.Location = new System.Drawing.Point(359, 359);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShadowDecoration.Parent = this.btn_delete;
            this.btn_delete.Size = new System.Drawing.Size(107, 49);
            this.btn_delete.TabIndex = 42;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseTransparentBackground = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Animated = true;
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.CheckedState.Parent = this.btn_clear;
            this.btn_clear.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton4.CustomImages.Image")));
            this.btn_clear.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_clear.CustomImages.Parent = this.btn_clear;
            this.btn_clear.FillColor = System.Drawing.Color.Empty;
            this.btn_clear.FillColor2 = System.Drawing.Color.Empty;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(64)))), ((int)(((byte)(7)))));
            this.btn_clear.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btn_clear.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_clear.HoverState.Parent = this.btn_clear;
            this.btn_clear.Location = new System.Drawing.Point(504, 359);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.ShadowDecoration.Parent = this.btn_clear;
            this.btn_clear.Size = new System.Drawing.Size(107, 49);
            this.btn_clear.TabIndex = 43;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseTransparentBackground = true;
            // 
            // Add_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.employee_grid);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.txt_role);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_employee";
            this.Text = "Add_employee";
            ((System.ComponentModel.ISupportInitialize)(this.employee_grid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employee_grid;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btn_back;
        private Guna.UI2.WinForms.Guna2GradientButton btn_new;
        private Guna.UI2.WinForms.Guna2TextBox txt_name;
        private Guna.UI2.WinForms.Guna2TextBox txt_address;
        private Guna.UI2.WinForms.Guna2TextBox txt_salary;
        private Guna.UI2.WinForms.Guna2TextBox txt_role;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton btn_insert;
        private Guna.UI2.WinForms.Guna2GradientButton btn_update;
        private Guna.UI2.WinForms.Guna2GradientButton btn_delete;
        private Guna.UI2.WinForms.Guna2GradientButton btn_clear;
    }
}