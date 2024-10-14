namespace csCY_Avenue.Admin_Interface.Main
{
    partial class frmRevenue
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
            pnlDisplay = new Panel();
            label1 = new Label();
            bindingSource1 = new BindingSource(components);
            pnlDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // pnlDisplay
            // 
            pnlDisplay.Controls.Add(label1);
            pnlDisplay.Dock = DockStyle.Fill;
            pnlDisplay.Location = new Point(0, 0);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(1173, 721);
            pnlDisplay.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 32);
            label1.TabIndex = 2;
            label1.Text = "GYM REVENUE";
            // 
            // bindingSource1
            // 
            bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // frmRevenue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 721);
            Controls.Add(pnlDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRevenue";
            Text = "frmRevenue";
            pnlDisplay.ResumeLayout(false);
            pnlDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlDisplay;
        private Label label1;
        private BindingSource bindingSource1;
    }
}