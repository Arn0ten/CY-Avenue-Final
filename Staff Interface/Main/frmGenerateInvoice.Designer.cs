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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            button1 = new Button();
            label1 = new Label();
            FormDesign = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2HtmlLabel16 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dtInvoiceDate = new DateTimePicker();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblItemTotalAmount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtInvoiceID = new Guna.UI2.WinForms.Guna2TextBox();
            btnGenerate = new Guna.UI2.WinForms.Guna2Button();
            guna2ShadowPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Nirmala UI", 11.25F);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel1.Location = new Point(17, 152);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(110, 22);
            guna2HtmlLabel1.TabIndex = 193;
            guna2HtmlLabel1.Text = "Member Name :";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(41, 50, 113);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources._10758949_x_icon2;
            button1.Location = new Point(342, 8);
            button1.Name = "button1";
            button1.Size = new Size(34, 30);
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
            label1.Location = new Point(115, 13);
            label1.Name = "label1";
            label1.Size = new Size(159, 21);
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
            // guna2HtmlLabel16
            // 
            guna2HtmlLabel16.BackColor = Color.Transparent;
            guna2HtmlLabel16.Font = new Font("Nirmala UI", 11.25F);
            guna2HtmlLabel16.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel16.Location = new Point(19, 115);
            guna2HtmlLabel16.Name = "guna2HtmlLabel16";
            guna2HtmlLabel16.Size = new Size(93, 22);
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
            dtInvoiceDate.Location = new Point(128, 116);
            dtInvoiceDate.Name = "dtInvoiceDate";
            dtInvoiceDate.Size = new Size(203, 23);
            dtInvoiceDate.TabIndex = 191;
            // 
            // txtName
            // 
            txtName.BorderColor = Color.Silver;
            txtName.BorderRadius = 5;
            txtName.CustomizableEdges = customizableEdges1;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FillColor = Color.FromArgb(219, 219, 219);
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(128, 148);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            txtName.PlaceholderText = "1234567";
            txtName.ReadOnly = true;
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtName.Size = new Size(203, 29);
            txtName.TabIndex = 190;
            // 
            // guna2HtmlLabel13
            // 
            guna2HtmlLabel13.BackColor = Color.Transparent;
            guna2HtmlLabel13.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel13.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel13.Location = new Point(220, 315);
            guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            guna2HtmlLabel13.Size = new Size(23, 47);
            guna2HtmlLabel13.TabIndex = 189;
            guna2HtmlLabel13.Text = "₱";
            // 
            // lblItemTotalAmount
            // 
            lblItemTotalAmount.BackColor = Color.Transparent;
            lblItemTotalAmount.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemTotalAmount.ForeColor = Color.FromArgb(64, 64, 64);
            lblItemTotalAmount.Location = new Point(247, 314);
            lblItemTotalAmount.Name = "lblItemTotalAmount";
            lblItemTotalAmount.Size = new Size(84, 47);
            lblItemTotalAmount.TabIndex = 188;
            lblItemTotalAmount.Text = "50.00";
            // 
            // guna2HtmlLabel10
            // 
            guna2HtmlLabel10.BackColor = Color.Transparent;
            guna2HtmlLabel10.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel10.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel10.Location = new Point(140, 330);
            guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            guna2HtmlLabel10.Size = new Size(74, 19);
            guna2HtmlLabel10.TabIndex = 187;
            guna2HtmlLabel10.Text = "Fixed Price:";
            // 
            // guna2ShadowPanel2
            // 
            guna2ShadowPanel2.BackColor = Color.Transparent;
            guna2ShadowPanel2.Controls.Add(button1);
            guna2ShadowPanel2.Controls.Add(label1);
            guna2ShadowPanel2.Dock = DockStyle.Top;
            guna2ShadowPanel2.FillColor = Color.FromArgb(41, 50, 113);
            guna2ShadowPanel2.Location = new Point(0, 0);
            guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            guna2ShadowPanel2.Radius = 4;
            guna2ShadowPanel2.ShadowColor = Color.Transparent;
            guna2ShadowPanel2.ShadowDepth = 1;
            guna2ShadowPanel2.ShadowShift = 1;
            guna2ShadowPanel2.Size = new Size(381, 47);
            guna2ShadowPanel2.TabIndex = 180;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Nirmala UI", 11.25F);
            guna2HtmlLabel2.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel2.Location = new Point(19, 81);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(76, 22);
            guna2HtmlLabel2.TabIndex = 183;
            guna2HtmlLabel2.Text = "Invoice ID :";
            // 
            // txtInvoiceID
            // 
            txtInvoiceID.BorderColor = Color.Silver;
            txtInvoiceID.BorderRadius = 5;
            txtInvoiceID.CustomizableEdges = customizableEdges3;
            txtInvoiceID.DefaultText = "";
            txtInvoiceID.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtInvoiceID.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtInvoiceID.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtInvoiceID.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtInvoiceID.Enabled = false;
            txtInvoiceID.FillColor = Color.FromArgb(219, 219, 219);
            txtInvoiceID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtInvoiceID.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInvoiceID.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtInvoiceID.Location = new Point(128, 78);
            txtInvoiceID.Name = "txtInvoiceID";
            txtInvoiceID.PasswordChar = '\0';
            txtInvoiceID.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            txtInvoiceID.PlaceholderText = "1234567";
            txtInvoiceID.ReadOnly = true;
            txtInvoiceID.SelectedText = "";
            txtInvoiceID.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtInvoiceID.Size = new Size(203, 29);
            txtInvoiceID.TabIndex = 182;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Transparent;
            btnGenerate.BorderRadius = 5;
            btnGenerate.CustomizableEdges = customizableEdges5;
            btnGenerate.DisabledState.BorderColor = Color.DarkGray;
            btnGenerate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGenerate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGenerate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGenerate.FillColor = Color.FromArgb(67, 154, 71);
            btnGenerate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.HoverState.CustomBorderColor = Color.FromArgb(125, 183, 127);
            btnGenerate.HoverState.ForeColor = Color.White;
            btnGenerate.Location = new Point(52, 501);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.PressedColor = Color.FromArgb(67, 154, 71);
            btnGenerate.ShadowDecoration.BorderRadius = 9;
            btnGenerate.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnGenerate.Size = new Size(285, 34);
            btnGenerate.TabIndex = 181;
            btnGenerate.Text = "Generate";
            // 
            // frmGenerateInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 548);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2HtmlLabel16);
            Controls.Add(dtInvoiceDate);
            Controls.Add(txtName);
            Controls.Add(guna2HtmlLabel13);
            Controls.Add(lblItemTotalAmount);
            Controls.Add(guna2HtmlLabel10);
            Controls.Add(guna2ShadowPanel2);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(txtInvoiceID);
            Controls.Add(btnGenerate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmGenerateInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGenerateInvoice";
            guna2ShadowPanel2.ResumeLayout(false);
            guna2ShadowPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Button button1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm FormDesign;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel16;
        private DateTimePicker dtInvoiceDate;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblItemTotalAmount;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtInvoiceID;
        private Guna.UI2.WinForms.Guna2Button btnGenerate;
    }
}