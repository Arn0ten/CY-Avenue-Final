namespace csCY_Avenue.Staff_Interface.Main
{
    partial class frmTrainerMainForm
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
            pnl = new Panel();
            pnlDisplay = new Panel();
            cmbTrainerMainFormGridViewFilter = new ComboBox();
            label3 = new Label();
            pnl.SuspendLayout();
            SuspendLayout();
            // 
            // pnl
            // 
            pnl.Controls.Add(pnlDisplay);
            pnl.Controls.Add(cmbTrainerMainFormGridViewFilter);
            pnl.Controls.Add(label3);
            pnl.Dock = DockStyle.Fill;
            pnl.Location = new Point(0, 0);
            pnl.Margin = new Padding(3, 4, 3, 4);
            pnl.Name = "pnl";
            pnl.Size = new Size(1341, 961);
            pnl.TabIndex = 4;
            // 
            // pnlDisplay
            // 
            pnlDisplay.Location = new Point(30, 120);
            pnlDisplay.Margin = new Padding(3, 4, 3, 4);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(1269, 803);
            pnlDisplay.TabIndex = 19;
            // 
            // cmbTrainerMainFormGridViewFilter
            // 
            cmbTrainerMainFormGridViewFilter.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTrainerMainFormGridViewFilter.FormattingEnabled = true;
            cmbTrainerMainFormGridViewFilter.Items.AddRange(new object[] { "Fixed Trainers", "Personal Trainers" });
            cmbTrainerMainFormGridViewFilter.Location = new Point(30, 77);
            cmbTrainerMainFormGridViewFilter.Margin = new Padding(3, 4, 3, 4);
            cmbTrainerMainFormGridViewFilter.Name = "cmbTrainerMainFormGridViewFilter";
            cmbTrainerMainFormGridViewFilter.Size = new Size(133, 33);
            cmbTrainerMainFormGridViewFilter.TabIndex = 17;
            cmbTrainerMainFormGridViewFilter.Tag = "";
            cmbTrainerMainFormGridViewFilter.Text = "Filter";
            cmbTrainerMainFormGridViewFilter.SelectedIndexChanged += cmbTrainerMainFormGridViewFilter_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(183, 46);
            label3.TabIndex = 15;
            label3.Text = "TRAINERS";
            // 
            // frmTrainerMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 961);
            Controls.Add(pnl);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTrainerMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTrainerMainForm";
            pnl.ResumeLayout(false);
            pnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl;
        private Panel pnlDisplay;
        private ComboBox cmbTrainerMainFormGridViewFilter;
        private Label label3;
    }
}