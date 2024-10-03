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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnLoginForm = new Guna.UI2.WinForms.Guna2Button();
            btnSignupForm = new Guna.UI2.WinForms.Guna2Button();
            pnl = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnl.SuspendLayout();
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
            btnLoginForm.CustomizableEdges = customizableEdges1;
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
            btnLoginForm.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLoginForm.Size = new Size(181, 42);
            btnLoginForm.TabIndex = 2;
            btnLoginForm.Text = "Login";
            btnLoginForm.Click += guna2Button1_Click;
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
            btnSignupForm.Location = new Point(271, 390);
            btnSignupForm.Name = "btnSignupForm";
            btnSignupForm.PressedColor = Color.FromArgb(114, 124, 178);
            btnSignupForm.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSignupForm.Size = new Size(181, 42);
            btnSignupForm.TabIndex = 3;
            btnSignupForm.Text = "Signup";
            btnSignupForm.Click += guna2Button2_Click;
            // 
            // pnl
            // 
            pnl.BackColor = Color.White;
            pnl.Controls.Add(btnSignupForm);
            pnl.Controls.Add(btnLoginForm);
            pnl.Controls.Add(label2);
            pnl.Controls.Add(label1);
            pnl.Dock = DockStyle.Right;
            pnl.Location = new Point(501, 0);
            pnl.Name = "pnl";
            pnl.Size = new Size(499, 650);
            pnl.TabIndex = 6;
            // 
            // frmWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 78, 129);
            ClientSize = new Size(1000, 650);
            Controls.Add(pictureBox1);
            Controls.Add(pnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmWelcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnl.ResumeLayout(false);
            pnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button btnLoginForm;
        private Guna.UI2.WinForms.Guna2Button btnSignupForm;
        private Panel pnl;
    }
}