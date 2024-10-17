namespace csCY_Avenue.AuthPage
{
    partial class frmStart
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
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            pictureBox1 = new PictureBox();
            pnlDisplay = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // pnlDisplay
            // 
            pnlDisplay.BackColor = Color.White;
            pnlDisplay.Dock = DockStyle.Right;
            pnlDisplay.Location = new Point(501, 0);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(499, 650);
            pnlDisplay.TabIndex = 6;
            // 
            // frmStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 78, 129);
            ClientSize = new Size(1000, 650);
            Controls.Add(pictureBox1);
            Controls.Add(pnlDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmStart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        public PictureBox pictureBox1;
        public Panel pnlDisplay;
    }
}