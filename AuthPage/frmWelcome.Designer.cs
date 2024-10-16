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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnLoginForm = new Guna.UI2.WinForms.Guna2Button();
            btnSignupForm = new Guna.UI2.WinForms.Guna2Button();
            pnlDisplay = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlDisplay.SuspendLayout();
            SuspendLayout();
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.carlos_yulo_vault_november_6_2022__1_;
            pictureBox1.Location = new Point(-226, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(729, 650);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(62, 71, 127);
            label1.Location = new Point(31, 138);
            label1.Name = "label1";
            label1.Size = new Size(253, 65);
            label1.TabIndex = 0;
            label1.Text = "Welcome!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 272);
            label2.Name = "label2";
            label2.Size = new Size(492, 75);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLoginForm
            // 
            btnLoginForm.BackColor = Color.White;
            btnLoginForm.BorderRadius = 8;
            btnLoginForm.CustomizableEdges = customizableEdges5;
            btnLoginForm.DisabledState.BorderColor = Color.DarkGray;
            btnLoginForm.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLoginForm.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLoginForm.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLoginForm.FillColor = Color.FromArgb(62, 71, 127);
            btnLoginForm.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnLoginForm.ForeColor = Color.White;
            btnLoginForm.Location = new Point(61, 390);
            btnLoginForm.Name = "btnLoginForm";
            btnLoginForm.PressedColor = Color.FromArgb(114, 124, 178);
            btnLoginForm.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnLoginForm.Size = new Size(181, 42);
            btnLoginForm.TabIndex = 2;
            btnLoginForm.Text = "Login";
            btnLoginForm.Click += guna2Button1_Click;
            // 
            // btnSignupForm
            // 
            btnSignupForm.BackColor = Color.White;
            btnSignupForm.BorderRadius = 8;
            btnSignupForm.CustomizableEdges = customizableEdges7;
            btnSignupForm.DisabledState.BorderColor = Color.DarkGray;
            btnSignupForm.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSignupForm.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSignupForm.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSignupForm.FillColor = Color.FromArgb(62, 71, 127);
            btnSignupForm.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            btnSignupForm.ForeColor = Color.White;
            btnSignupForm.Location = new Point(271, 390);
            btnSignupForm.Name = "btnSignupForm";
            btnSignupForm.PressedColor = Color.FromArgb(114, 124, 178);
            btnSignupForm.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSignupForm.Size = new Size(181, 42);
            btnSignupForm.TabIndex = 3;
            btnSignupForm.Text = "Signup";
            btnSignupForm.Click += guna2Button2_Click;
            // 
            // pnlDisplay
            // 
            pnlDisplay.BackColor = Color.White;
            pnlDisplay.Controls.Add(btnSignupForm);
            pnlDisplay.Controls.Add(btnLoginForm);
            pnlDisplay.Controls.Add(label2);
            pnlDisplay.Controls.Add(label1);
            pnlDisplay.Dock = DockStyle.Right;
            pnlDisplay.Location = new Point(501, 0);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(499, 650);
            pnlDisplay.TabIndex = 6;
            // 
            // frmWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 78, 129);
            ClientSize = new Size(1000, 650);
            Controls.Add(pictureBox1);
            Controls.Add(pnlDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmWelcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlDisplay.ResumeLayout(false);
            pnlDisplay.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        public PictureBox pictureBox1;
        public Label label1;
        public Label label2;
        public Guna.UI2.WinForms.Guna2Button btnLoginForm;
        public Guna.UI2.WinForms.Guna2Button btnSignupForm;
        public Panel pnlDisplay;
    }
}