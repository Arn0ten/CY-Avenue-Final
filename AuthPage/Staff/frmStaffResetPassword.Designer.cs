namespace csCY_Avenue.AuthPage.Admin
{
    partial class frmStaffResetPassword
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlDisplay = new Panel();
            lblLogin = new Label();
            label5 = new Label();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            btnSubmit = new Button();
            txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            btnExit = new Button();
            chkShowPassword = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            pnlDisplay.SuspendLayout();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDisplay
            // 
            pnlDisplay.Controls.Add(lblLogin);
            pnlDisplay.Controls.Add(label5);
            pnlDisplay.Controls.Add(guna2ShadowPanel1);
            pnlDisplay.Dock = DockStyle.Fill;
            pnlDisplay.Location = new Point(0, 0);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(500, 650);
            pnlDisplay.TabIndex = 11;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(62, 71, 127);
            lblLogin.Location = new Point(50, 78);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(281, 37);
            lblLogin.TabIndex = 22;
            lblLogin.Text = "Reset Your Password";
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
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(btnSubmit);
            guna2ShadowPanel1.Controls.Add(txtConfirmPassword);
            guna2ShadowPanel1.Controls.Add(txtNewPassword);
            guna2ShadowPanel1.Controls.Add(btnExit);
            guna2ShadowPanel1.Controls.Add(chkShowPassword);
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
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(62, 71, 127);
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(51, 293);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(302, 48);
            btnSubmit.TabIndex = 20;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderRadius = 5;
            txtConfirmPassword.CustomizableEdges = customizableEdges5;
            txtConfirmPassword.DefaultText = "";
            txtConfirmPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtConfirmPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtConfirmPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.ForeColor = Color.Black;
            txtConfirmPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmPassword.Location = new Point(51, 178);
            txtConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '•';
            txtConfirmPassword.PlaceholderText = "Confirm Password";
            txtConfirmPassword.SelectedText = "";
            txtConfirmPassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtConfirmPassword.Size = new Size(302, 39);
            txtConfirmPassword.TabIndex = 18;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BorderRadius = 5;
            txtNewPassword.CustomizableEdges = customizableEdges7;
            txtNewPassword.DefaultText = "";
            txtNewPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNewPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNewPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNewPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNewPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNewPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.ForeColor = Color.Black;
            txtNewPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNewPassword.Location = new Point(51, 109);
            txtNewPassword.Margin = new Padding(3, 4, 3, 4);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '•';
            txtNewPassword.PlaceholderText = "New Password";
            txtNewPassword.SelectedText = "";
            txtNewPassword.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtNewPassword.Size = new Size(302, 39);
            txtNewPassword.TabIndex = 17;
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
            btnExit.Text = "Back to login";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(51, 88);
            label2.Name = "label2";
            label2.Size = new Size(105, 17);
            label2.TabIndex = 11;
            label2.Text = "New Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(51, 157);
            label3.Name = "label3";
            label3.Size = new Size(128, 17);
            label3.TabIndex = 12;
            label3.Text = "Confirm Password :";
            // 
            // frmStaffResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 650);
            Controls.Add(pnlDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmStaffResetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdminResetPassword";
            pnlDisplay.ResumeLayout(false);
            pnlDisplay.PerformLayout();
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDisplay;
        private Label label5;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Button btnSubmit;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        private Button btnExit;
        private CheckBox chkShowPassword;
        private Label label2;
        private Label label3;
        private Label lblLogin;
    }
}