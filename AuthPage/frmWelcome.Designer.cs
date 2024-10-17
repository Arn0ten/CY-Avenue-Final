namespace csCY_Avenue.AuthPage
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            btnLoginForm = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            btnSignupForm = new Guna.UI2.WinForms.Guna2Button();
            pnlDisplay = new Panel();
            pnlDisplay.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(62, 71, 127);
            label1.Location = new Point(26, 153);
            label1.Name = "label1";
            label1.Size = new Size(253, 65);
            label1.TabIndex = 4;
            label1.Text = "Welcome!";
            // 
            // btnLoginForm
            // 
            btnLoginForm.BackColor = Color.White;
            btnLoginForm.BorderRadius = 8;
            btnLoginForm.CustomizableEdges = customizableEdges1;
            btnLoginForm.DisabledState.BorderColor = Color.DarkGray;
            btnLoginForm.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLoginForm.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLoginForm.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLoginForm.FillColor = Color.FromArgb(62, 71, 127);
            btnLoginForm.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnLoginForm.ForeColor = Color.White;
            btnLoginForm.Location = new Point(56, 405);
            btnLoginForm.Name = "btnLoginForm";
            btnLoginForm.PressedColor = Color.FromArgb(114, 124, 178);
            btnLoginForm.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLoginForm.Size = new Size(181, 42);
            btnLoginForm.TabIndex = 6;
            btnLoginForm.Text = "Login";
            btnLoginForm.Click += btnLoginForm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 287);
            label2.Name = "label2";
            label2.Size = new Size(492, 75);
            label2.TabIndex = 5;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSignupForm
            // 
            btnSignupForm.BackColor = Color.White;
            btnSignupForm.BorderRadius = 8;
            btnSignupForm.CustomizableEdges = customizableEdges3;
            btnSignupForm.DisabledState.BorderColor = Color.DarkGray;
            btnSignupForm.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSignupForm.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSignupForm.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSignupForm.FillColor = Color.FromArgb(62, 71, 127);
            btnSignupForm.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnSignupForm.ForeColor = Color.White;
            btnSignupForm.Location = new Point(266, 405);
            btnSignupForm.Name = "btnSignupForm";
            btnSignupForm.PressedColor = Color.FromArgb(114, 124, 178);
            btnSignupForm.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSignupForm.Size = new Size(181, 42);
            btnSignupForm.TabIndex = 7;
            btnSignupForm.Text = "Signup";
            btnSignupForm.Click += btnSignupForm_Click;
            // 
            // pnlDisplay
            // 
            pnlDisplay.Controls.Add(btnSignupForm);
            pnlDisplay.Controls.Add(label2);
            pnlDisplay.Controls.Add(btnLoginForm);
            pnlDisplay.Controls.Add(label1);
            pnlDisplay.Dock = DockStyle.Fill;
            pnlDisplay.Location = new Point(0, 0);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(499, 650);
            pnlDisplay.TabIndex = 8;
            // 
            // frmWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 650);
            Controls.Add(pnlDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmWelcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmWelcome";
            pnlDisplay.ResumeLayout(false);
            pnlDisplay.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Label label1;
        public Guna.UI2.WinForms.Guna2Button btnLoginForm;
        public Label label2;
        public Guna.UI2.WinForms.Guna2Button btnSignupForm;
        private Panel pnlDisplay;
    }
}