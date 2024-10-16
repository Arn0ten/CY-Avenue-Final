namespace csCY_Avenue.Admin_Interface.Main
{
    partial class frmNotifications
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            pnlDisplay = new Panel();
            dgvNotification = new DataGridView();
            pnlDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNotification).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 1;
            label1.Text = "NOTIFICATIONS";
            // 
            // pnlDisplay
            // 
            pnlDisplay.Controls.Add(dgvNotification);
            pnlDisplay.Dock = DockStyle.Fill;
            pnlDisplay.Location = new Point(0, 0);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(1173, 721);
            pnlDisplay.TabIndex = 2;
            // 
            // dgvNotification
            // 
            dgvNotification.AllowUserToAddRows = false;
            dgvNotification.AllowUserToDeleteRows = false;
            dgvNotification.AllowUserToResizeRows = false;
            dgvNotification.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNotification.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNotification.BackgroundColor = Color.White;
            dgvNotification.BorderStyle = BorderStyle.None;
            dgvNotification.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvNotification.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNotification.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNotification.ColumnHeadersHeight = 35;
            dgvNotification.EnableHeadersVisualStyles = false;
            dgvNotification.GridColor = SystemColors.ScrollBar;
            dgvNotification.Location = new Point(12, 68);
            dgvNotification.Name = "dgvNotification";
            dgvNotification.ReadOnly = true;
            dgvNotification.RowHeadersVisible = false;
            dgvNotification.RowHeadersWidth = 35;
            dgvNotification.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotification.Size = new Size(1149, 641);
            dgvNotification.TabIndex = 7;
            dgvNotification.CellClick += dgvNotification_CellClick;
            // 
            // frmNotifications
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 721);
            Controls.Add(label1);
            Controls.Add(pnlDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNotifications";
            Text = "frmNotifications";
            Load += frmNotifications_Load;
            pnlDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNotification).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel pnlDisplay;
        private DataGridView dgvNotification;
    }
}