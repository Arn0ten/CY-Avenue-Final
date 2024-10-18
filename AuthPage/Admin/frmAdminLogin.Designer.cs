namespace csCY_Avenue.AuthPage
{
    partial class frmAdminLogin
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            btnLogin = new Button();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            btnExit = new Button();
            chkShowPassword = new CheckBox();
            lblLogin = new Label();
            label2 = new Label();
            label3 = new Label();
            pnlDisplay = new Panel();
            label5 = new Label();
            guna2ShadowPanel1.SuspendLayout();
            pnlDisplay.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(btnLogin);
            guna2ShadowPanel1.Controls.Add(txtPassword);
            guna2ShadowPanel1.Controls.Add(txtEmail);
            guna2ShadowPanel1.Controls.Add(btnExit);
            guna2ShadowPanel1.Controls.Add(chkShowPassword);
            guna2ShadowPanel1.Controls.Add(lblLogin);
            guna2ShadowPanel1.Controls.Add(label2);
            guna2ShadowPanel1.Controls.Add(label3);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(54, 118);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.ShadowDepth = 200;
            guna2ShadowPanel1.ShadowShift = 3;
            guna2ShadowPanel1.Size = new Size(393, 445);
            guna2ShadowPanel1.TabIndex = 8;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(62, 71, 127);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(51, 293);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(302, 48);
            btnLogin.TabIndex = 20;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderRadius = 5;
            txtPassword.CustomizableEdges = customizableEdges1;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Location = new Point(51, 178);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.PlaceholderText = "Password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtPassword.Size = new Size(302, 39);
            txtPassword.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.BorderRadius = 5;
            txtEmail.CustomizableEdges = customizableEdges3;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.Black;
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(51, 109);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderText = "Email";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtEmail.Size = new Size(302, 39);
            txtEmail.TabIndex = 17;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(62, 71, 127);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(62, 71, 127);
            btnExit.Location = new Point(51, 347);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(302, 48);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            chkShowPassword.ForeColor = Color.DimGray;
            chkShowPassword.Location = new Point(51, 224);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(122, 21);
            chkShowPassword.TabIndex = 16;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(62, 71, 127);
            lblLogin.Location = new Point(145, 7);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(104, 45);
            lblLogin.TabIndex = 10;
            lblLogin.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(51, 88);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 11;
            label2.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(51, 157);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 12;
            label3.Text = "Password :";
            // 
            // pnlDisplay
            // 
            pnlDisplay.Controls.Add(label5);
            pnlDisplay.Controls.Add(guna2ShadowPanel1);
            pnlDisplay.Dock = DockStyle.Fill;
            pnlDisplay.Location = new Point(0, 0);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(500, 650);
            pnlDisplay.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(224, 9);
            label5.Name = "label5";
            label5.Size = new Size(53, 17);
            label5.TabIndex = 21;
            label5.Text = "ADMIN";
            // 
            // frmAdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 650);
            Controls.Add(pnlDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdminLogin";
            Text = "frmAdminLogin";
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            pnlDisplay.ResumeLayout(false);
            pnlDisplay.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtEmailAddress;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Button btnLogin;
        private Button btnExit;
        private CheckBox chkShowPassword;
        private Label label1;
        private Label lblLogin;
        private Label label2;
        private Label label3;
        private Panel pnlDisplay;
        private Label label5;
    }
}