namespace csCY_Avenue.Staff_Interface.Main
{
    partial class frmGenerateInvoice
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            button1 = new Button();
            label1 = new Label();
            FormDesign = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            btnGenerate = new Guna.UI2.WinForms.Guna2Button();
            cmbGender = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel16 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dtInvoiceDate = new DateTimePicker();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblItemTotalAmount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2ShadowPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(41, 50, 113);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources._10758949_x_icon2;
            button1.Location = new Point(391, 11);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(39, 40);
            button1.TabIndex = 84;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(131, 17);
            label1.Name = "label1";
            label1.Size = new Size(198, 28);
            label1.TabIndex = 2;
            label1.Text = "GENERATE INVOICE";
            // 
            // FormDesign
            // 
            FormDesign.AnimateWindow = true;
            FormDesign.AnimationInterval = 24;
            FormDesign.BorderRadius = 20;
            FormDesign.ContainerControl = this;
            FormDesign.DockIndicatorTransparencyValue = 0.6D;
            FormDesign.TransparentWhileDrag = true;
            // 
            // guna2ShadowPanel2
            // 
            guna2ShadowPanel2.BackColor = Color.Transparent;
            guna2ShadowPanel2.Controls.Add(button1);
            guna2ShadowPanel2.Controls.Add(label1);
            guna2ShadowPanel2.Dock = DockStyle.Top;
            guna2ShadowPanel2.FillColor = Color.FromArgb(41, 50, 113);
            guna2ShadowPanel2.Location = new Point(0, 0);
            guna2ShadowPanel2.Margin = new Padding(3, 4, 3, 4);
            guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            guna2ShadowPanel2.Radius = 4;
            guna2ShadowPanel2.ShadowColor = Color.Transparent;
            guna2ShadowPanel2.ShadowDepth = 1;
            guna2ShadowPanel2.ShadowShift = 1;
            guna2ShadowPanel2.Size = new Size(435, 63);
            guna2ShadowPanel2.TabIndex = 180;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Transparent;
            btnGenerate.BorderRadius = 5;
            btnGenerate.CustomizableEdges = customizableEdges9;
            btnGenerate.DisabledState.BorderColor = Color.DarkGray;
            btnGenerate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGenerate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGenerate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGenerate.FillColor = Color.FromArgb(67, 154, 71);
            btnGenerate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.HoverState.CustomBorderColor = Color.FromArgb(125, 183, 127);
            btnGenerate.HoverState.ForeColor = Color.White;
            btnGenerate.Location = new Point(59, 668);
            btnGenerate.Margin = new Padding(3, 4, 3, 4);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.PressedColor = Color.FromArgb(67, 154, 71);
            btnGenerate.ShadowDecoration.BorderRadius = 9;
            btnGenerate.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnGenerate.Size = new Size(326, 45);
            btnGenerate.TabIndex = 181;
            btnGenerate.Text = "Generate";
            btnGenerate.Click += btnGenerate_Click;
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.Transparent;
            cmbGender.CustomizableEdges = customizableEdges1;
            cmbGender.DrawMode = DrawMode.OwnerDrawFixed;
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbGender.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbGender.Font = new Font("Segoe UI", 10F);
            cmbGender.ForeColor = Color.FromArgb(68, 88, 112);
            cmbGender.ItemHeight = 30;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Bayot" });
            cmbGender.Location = new Point(196, 366);
            cmbGender.Name = "cmbGender";
            cmbGender.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cmbGender.Size = new Size(105, 36);
            cmbGender.TabIndex = 199;
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Nirmala UI", 11.25F);
            guna2HtmlLabel4.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel4.Location = new Point(74, 366);
            guna2HtmlLabel4.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(74, 27);
            guna2HtmlLabel4.TabIndex = 198;
            guna2HtmlLabel4.Text = "Gender :";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Nirmala UI", 11.25F);
            guna2HtmlLabel3.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel3.Location = new Point(8, 294);
            guna2HtmlLabel3.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(140, 27);
            guna2HtmlLabel3.TabIndex = 197;
            guna2HtmlLabel3.Text = "Phone Number :";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderColor = Color.Silver;
            txtPhoneNumber.BorderRadius = 5;
            txtPhoneNumber.CustomizableEdges = customizableEdges3;
            txtPhoneNumber.DefaultText = "";
            txtPhoneNumber.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPhoneNumber.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPhoneNumber.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPhoneNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPhoneNumber.FillColor = Color.FromArgb(219, 219, 219);
            txtPhoneNumber.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPhoneNumber.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhoneNumber.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPhoneNumber.Location = new Point(196, 288);
            txtPhoneNumber.Margin = new Padding(3, 5, 3, 5);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PasswordChar = '\0';
            txtPhoneNumber.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            txtPhoneNumber.PlaceholderText = "1234567";
            txtPhoneNumber.SelectedText = "";
            txtPhoneNumber.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtPhoneNumber.Size = new Size(215, 39);
            txtPhoneNumber.TabIndex = 196;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Nirmala UI", 11.25F);
            guna2HtmlLabel2.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel2.Location = new Point(81, 224);
            guna2HtmlLabel2.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(58, 27);
            guna2HtmlLabel2.TabIndex = 195;
            guna2HtmlLabel2.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.BorderColor = Color.Silver;
            txtEmail.BorderRadius = 5;
            txtEmail.CustomizableEdges = customizableEdges5;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FillColor = Color.FromArgb(219, 219, 219);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(196, 224);
            txtEmail.Margin = new Padding(3, 5, 3, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            txtEmail.PlaceholderText = "wick@dmgail";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtEmail.Size = new Size(215, 39);
            txtEmail.TabIndex = 194;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Nirmala UI", 11.25F);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel1.Location = new Point(23, 163);
            guna2HtmlLabel1.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(116, 27);
            guna2HtmlLabel1.TabIndex = 193;
            guna2HtmlLabel1.Text = "Client Name :";
            // 
            // guna2HtmlLabel16
            // 
            guna2HtmlLabel16.BackColor = Color.Transparent;
            guna2HtmlLabel16.Font = new Font("Nirmala UI", 11.25F);
            guna2HtmlLabel16.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel16.Location = new Point(22, 96);
            guna2HtmlLabel16.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel16.Name = "guna2HtmlLabel16";
            guna2HtmlLabel16.Size = new Size(116, 27);
            guna2HtmlLabel16.TabIndex = 192;
            guna2HtmlLabel16.Text = "Invoice Date :";
            // 
            // dtInvoiceDate
            // 
            dtInvoiceDate.CalendarFont = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            dtInvoiceDate.CalendarMonthBackground = Color.FromArgb(41, 50, 113);
            dtInvoiceDate.CalendarTitleBackColor = Color.FromArgb(41, 50, 113);
            dtInvoiceDate.CalendarTitleForeColor = Color.White;
            dtInvoiceDate.CalendarTrailingForeColor = Color.FromArgb(192, 0, 0);
            dtInvoiceDate.Location = new Point(196, 96);
            dtInvoiceDate.Margin = new Padding(3, 4, 3, 4);
            dtInvoiceDate.Name = "dtInvoiceDate";
            dtInvoiceDate.Size = new Size(231, 27);
            dtInvoiceDate.TabIndex = 191;
            // 
            // txtName
            // 
            txtName.BorderColor = Color.Silver;
            txtName.BorderRadius = 5;
            txtName.CustomizableEdges = customizableEdges7;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FillColor = Color.FromArgb(219, 219, 219);
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(197, 163);
            txtName.Margin = new Padding(3, 5, 3, 5);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            txtName.PlaceholderText = "John Wick";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtName.Size = new Size(214, 39);
            txtName.TabIndex = 190;
            // 
            // guna2HtmlLabel13
            // 
            guna2HtmlLabel13.BackColor = Color.Transparent;
            guna2HtmlLabel13.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel13.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel13.Location = new Point(163, 578);
            guna2HtmlLabel13.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            guna2HtmlLabel13.Size = new Size(28, 56);
            guna2HtmlLabel13.TabIndex = 189;
            guna2HtmlLabel13.Text = "₱";
            // 
            // lblItemTotalAmount
            // 
            lblItemTotalAmount.BackColor = Color.Transparent;
            lblItemTotalAmount.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemTotalAmount.ForeColor = Color.FromArgb(0, 192, 0);
            lblItemTotalAmount.Location = new Point(254, 578);
            lblItemTotalAmount.Margin = new Padding(3, 4, 3, 4);
            lblItemTotalAmount.Name = "lblItemTotalAmount";
            lblItemTotalAmount.Size = new Size(106, 56);
            lblItemTotalAmount.TabIndex = 188;
            lblItemTotalAmount.Text = "75.00";
            // 
            // guna2HtmlLabel10
            // 
            guna2HtmlLabel10.BackColor = Color.Transparent;
            guna2HtmlLabel10.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel10.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel10.Location = new Point(58, 599);
            guna2HtmlLabel10.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            guna2HtmlLabel10.Size = new Size(90, 23);
            guna2HtmlLabel10.TabIndex = 187;
            guna2HtmlLabel10.Text = "Fixed Price:";
            // 
            // frmGenerateInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 731);
            Controls.Add(cmbGender);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(txtPhoneNumber);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(txtEmail);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2HtmlLabel16);
            Controls.Add(dtInvoiceDate);
            Controls.Add(txtName);
            Controls.Add(guna2HtmlLabel13);
            Controls.Add(lblItemTotalAmount);
            Controls.Add(guna2HtmlLabel10);
            Controls.Add(guna2ShadowPanel2);
            Controls.Add(btnGenerate);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmGenerateInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGenerateInvoice";
            guna2ShadowPanel2.ResumeLayout(false);
            guna2ShadowPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm FormDesign;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2Button btnGenerate;
        private Guna.UI2.WinForms.Guna2ComboBox cmbGender;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel16;
        private DateTimePicker dtInvoiceDate;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblItemTotalAmount;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
    }
}