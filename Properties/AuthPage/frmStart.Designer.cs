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
            components = new System.ComponentModel.Container();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            pictureBox1 = new PictureBox();
            pnlDisplay = new Panel();
            FormDesign = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
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
            pictureBox1.Location = new Point(-258, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(833, 867);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pnlDisplay
            // 
            pnlDisplay.BackColor = Color.White;
            pnlDisplay.Dock = DockStyle.Right;
            pnlDisplay.Location = new Point(573, 0);
            pnlDisplay.Margin = new Padding(3, 4, 3, 4);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(570, 867);
            pnlDisplay.TabIndex = 6;
            pnlDisplay.Paint += pnlDisplay_Paint;
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
            // frmStart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 78, 129);
            ClientSize = new Size(1143, 867);
            Controls.Add(pictureBox1);
            Controls.Add(pnlDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private Guna.UI2.WinForms.Guna2BorderlessForm FormDesign;
    }
}