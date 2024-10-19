namespace csCY_Avenue.AuthPage
{
    partial class frmLoadingScreen
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
            FormDesign = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            picYulo = new PictureBox();
            lblText = new Label();
            lblText1 = new Label();
            lblText2 = new Label();
            prgBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            lblLoading = new Guna.UI2.WinForms.Guna2HtmlLabel();
            tmrLoading = new System.Windows.Forms.Timer(components);
            lblPercent = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)picYulo).BeginInit();
            SuspendLayout();
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
            // picYulo
            // 
            picYulo.Dock = DockStyle.Fill;
            picYulo.Image = Properties.Resources.output_onlinetools1;
            picYulo.Location = new Point(0, 0);
            picYulo.Name = "picYulo";
            picYulo.Size = new Size(654, 409);
            picYulo.SizeMode = PictureBoxSizeMode.StretchImage;
            picYulo.TabIndex = 7;
            picYulo.TabStop = false;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.BackColor = Color.Transparent;
            lblText.Font = new Font("Nirmala UI", 39.75F, FontStyle.Bold);
            lblText.ForeColor = Color.FromArgb(59, 75, 168);
            lblText.Location = new Point(235, 263);
            lblText.Name = "lblText";
            lblText.Size = new Size(249, 71);
            lblText.TabIndex = 9;
            lblText.Text = "ATHLETE";
            // 
            // lblText1
            // 
            lblText1.AutoSize = true;
            lblText1.BackColor = Color.Transparent;
            lblText1.Font = new Font("Nirmala UI", 39.75F, FontStyle.Bold);
            lblText1.ForeColor = Color.White;
            lblText1.Location = new Point(23, 198);
            lblText1.Name = "lblText1";
            lblText1.Size = new Size(207, 71);
            lblText1.TabIndex = 10;
            lblText1.Text = "TRAIN ";
            // 
            // lblText2
            // 
            lblText2.AutoSize = true;
            lblText2.BackColor = Color.Transparent;
            lblText2.Font = new Font("Nirmala UI", 39.75F, FontStyle.Bold);
            lblText2.ForeColor = Color.White;
            lblText2.Location = new Point(23, 263);
            lblText2.Name = "lblText2";
            lblText2.Size = new Size(230, 71);
            lblText2.TabIndex = 11;
            lblText2.Text = "LIKE AN";
            // 
            // prgBar
            // 
            prgBar.CustomizableEdges = customizableEdges1;
            prgBar.Location = new Point(45, 385);
            prgBar.Name = "prgBar";
            prgBar.ProgressColor = Color.FromArgb(65, 83, 181);
            prgBar.ProgressColor2 = Color.FromArgb(65, 83, 181);
            prgBar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            prgBar.Size = new Size(564, 12);
            prgBar.TabIndex = 12;
            prgBar.Text = "guna2ProgressBar1";
            prgBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // lblLoading
            // 
            lblLoading.BackColor = Color.Transparent;
            lblLoading.ForeColor = Color.White;
            lblLoading.Location = new Point(45, 366);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(61, 17);
            lblLoading.TabIndex = 13;
            lblLoading.Text = "Loading. . . ";
            // 
            // tmrLoading
            // 
            // 
            // lblPercent
            // 
            lblPercent.BackColor = Color.Transparent;
            lblPercent.ForeColor = Color.White;
            lblPercent.Location = new Point(615, 387);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(3, 2);
            lblPercent.TabIndex = 14;
            lblPercent.Text = " ";
            // 
            // frmLoadingScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 409);
            Controls.Add(lblPercent);
            Controls.Add(lblLoading);
            Controls.Add(prgBar);
            Controls.Add(lblText2);
            Controls.Add(lblText1);
            Controls.Add(lblText);
            Controls.Add(picYulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLoadingScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLoadingScreen";
            Load += frmLoadingScreen_Load;
            ((System.ComponentModel.ISupportInitialize)picYulo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm FormDesign;
        public Label lblText;
        private PictureBox picYulo;
        private Guna.UI2.WinForms.Guna2ProgressBar prgBar;
        public Label lblText2;
        public Label lblText1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLoading;
        private System.Windows.Forms.Timer tmrLoading;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPercent;
    }
}