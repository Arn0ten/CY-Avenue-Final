namespace csCY_Avenue.Admin_Interface.Main
{
    partial class frmRenewMember
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            button1 = new Button();
            FormDesign = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            btnGenerate = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources._10758949_x_icon2;
            button1.Location = new Point(577, 2);
            button1.Name = "button1";
            button1.Size = new Size(34, 30);
            button1.TabIndex = 84;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Transparent;
            btnGenerate.BorderRadius = 5;
            btnGenerate.CustomizableEdges = customizableEdges3;
            btnGenerate.DisabledState.BorderColor = Color.DarkGray;
            btnGenerate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGenerate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGenerate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGenerate.FillColor = Color.FromArgb(67, 154, 71);
            btnGenerate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.HoverState.CustomBorderColor = Color.FromArgb(125, 183, 127);
            btnGenerate.HoverState.ForeColor = Color.White;
            btnGenerate.Location = new Point(321, 34);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.PressedColor = Color.FromArgb(67, 154, 71);
            btnGenerate.ShadowDecoration.BorderRadius = 9;
            btnGenerate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnGenerate.Size = new Size(285, 76);
            btnGenerate.TabIndex = 148;
            btnGenerate.Text = "Regular";
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderRadius = 5;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(192, 0, 0);
            guna2Button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.HoverState.CustomBorderColor = Color.FromArgb(125, 183, 127);
            guna2Button1.HoverState.ForeColor = Color.White;
            guna2Button1.Location = new Point(12, 34);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = Color.Maroon;
            guna2Button1.ShadowDecoration.BorderRadius = 9;
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(285, 76);
            guna2Button1.TabIndex = 149;
            guna2Button1.Text = "V I P";
            // 
            // frmRenewMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 144);
            Controls.Add(guna2Button1);
            Controls.Add(button1);
            Controls.Add(btnGenerate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRenewMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTransactionHistory";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Guna.UI2.WinForms.Guna2BorderlessForm FormDesign;
        private Guna.UI2.WinForms.Guna2Button btnGenerate;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}