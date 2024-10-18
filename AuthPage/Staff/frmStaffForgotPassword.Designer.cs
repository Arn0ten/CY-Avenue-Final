namespace csCY_Avenue.AuthPage.Admin
{
    partial class frmStaffForgotPassword
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            btnSubmit = new Button();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            btnExit = new Button();
            label2 = new Label();
            lblLogin = new Label();
            pnlDisplay = new Panel();
            label5 = new Label();
            guna2ShadowPanel1.SuspendLayout();
            pnlDisplay.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(btnSubmit);
            guna2ShadowPanel1.Controls.Add(txtEmail);
            guna2ShadowPanel1.Controls.Add(btnExit);
            guna2ShadowPanel1.Controls.Add(label2);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(20, 205);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.ShadowDepth = 200;
            guna2ShadowPanel1.ShadowShift = 3;
            guna2ShadowPanel1.Size = new Size(461, 187);
            guna2ShadowPanel1.TabIndex = 8;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(62, 71, 127);
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(128, 105);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(204, 30);
            btnSubmit.TabIndex = 20;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtEmail
            // 
            txtEmail.BorderRadius = 5;
            txtEmail.CustomizableEdges = customizableEdges1;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.Black;
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(38, 38);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderText = "Email";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtEmail.Size = new Size(405, 39);
            txtEmail.TabIndex = 17;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(62, 71, 127);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(62, 71, 127);
            btnExit.Location = new Point(128, 141);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(204, 30);
            btnExit.TabIndex = 15;
            btnExit.Text = "Back to login";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(9, 15);
            label2.Name = "label2";
            label2.Size = new Size(282, 17);
            label2.TabIndex = 11;
            label2.Text = "Please enter your registered email address  :";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(62, 71, 127);
            lblLogin.Location = new Point(12, 165);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(233, 37);
            lblLogin.TabIndex = 10;
            lblLogin.Text = "Forgot Password";
            // 
            // pnlDisplay
            // 
            pnlDisplay.Controls.Add(label5);
            pnlDisplay.Controls.Add(guna2ShadowPanel1);
            pnlDisplay.Controls.Add(lblLogin);
            pnlDisplay.Dock = DockStyle.Fill;
            pnlDisplay.Location = new Point(0, 0);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(500, 650);
            pnlDisplay.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(228, 9);
            label5.Name = "label5";
            label5.Size = new Size(45, 17);
            label5.TabIndex = 21;
            label5.Text = "STAFF";
            // 
            // frmStaffForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 650);
            Controls.Add(pnlDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmStaffForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdminForgotPassword";
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            pnlDisplay.ResumeLayout(false);
            pnlDisplay.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Button btnSubmit;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Button btnExit;
        private Label lblLogin;
        private Label label2;
        private Panel pnlDisplay;
        private Label label5;
    }
}