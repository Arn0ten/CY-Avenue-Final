namespace csCY_Avenue.Admin_Interface.Main
{
    partial class frmAttendanceGridView
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvAttendance = new DataGridView();
            pnlDgvBack = new csLaundrySystem.CustomizableCornerPanel();
            txtSearchAttendance = new Guna.UI2.WinForms.Guna2TextBox();
            lblChange = new Label();
            btnSearchAttendance = new Guna.UI2.WinForms.Guna2Button();
            pnlDgvDisplay = new Panel();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            pnlDgvBack.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToDeleteRows = false;
            dgvAttendance.AllowUserToResizeRows = false;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAttendance.BackgroundColor = Color.White;
            dgvAttendance.BorderStyle = BorderStyle.None;
            dgvAttendance.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvAttendance.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAttendance.ColumnHeadersHeight = 35;
            dgvAttendance.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column8 });
            dgvAttendance.EnableHeadersVisualStyles = false;
            dgvAttendance.GridColor = SystemColors.ScrollBar;
            dgvAttendance.Location = new Point(0, 2);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.ReadOnly = true;
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.RowHeadersWidth = 35;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.Size = new Size(759, 428);
            dgvAttendance.TabIndex = 6;
            // 
            // pnlDgvBack
            // 
            pnlDgvBack.BackColor = Color.FromArgb(41, 50, 113);
            pnlDgvBack.BorderColor = Color.Black;
            pnlDgvBack.BorderWidth = 1F;
            pnlDgvBack.Controls.Add(dgvAttendance);
            pnlDgvBack.CornerRadius = 20;
            pnlDgvBack.Location = new Point(14, 39);
            pnlDgvBack.Name = "pnlDgvBack";
            pnlDgvBack.Size = new Size(758, 424);
            pnlDgvBack.TabIndex = 26;
            // 
            // txtSearchAttendance
            // 
            txtSearchAttendance.CustomizableEdges = customizableEdges1;
            txtSearchAttendance.DefaultText = "";
            txtSearchAttendance.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchAttendance.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchAttendance.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchAttendance.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchAttendance.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchAttendance.Font = new Font("Segoe UI", 9F);
            txtSearchAttendance.ForeColor = Color.Black;
            txtSearchAttendance.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchAttendance.Location = new Point(398, 9);
            txtSearchAttendance.Name = "txtSearchAttendance";
            txtSearchAttendance.PasswordChar = '\0';
            txtSearchAttendance.PlaceholderForeColor = Color.FromArgb(112, 112, 112);
            txtSearchAttendance.PlaceholderText = "⌕ Search Attendance";
            txtSearchAttendance.SelectedText = "";
            txtSearchAttendance.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearchAttendance.Size = new Size(301, 25);
            txtSearchAttendance.TabIndex = 25;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.ForeColor = Color.Black;
            lblChange.Location = new Point(14, 9);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(65, 20);
            lblChange.TabIndex = 24;
            lblChange.Text = "Attendance";
            // 
            // btnSearchAttendance
            // 
            btnSearchAttendance.BackColor = Color.FromArgb(67, 154, 71);
            btnSearchAttendance.CustomizableEdges = customizableEdges3;
            btnSearchAttendance.DisabledState.BorderColor = Color.DarkGray;
            btnSearchAttendance.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearchAttendance.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearchAttendance.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearchAttendance.FillColor = Color.FromArgb(67, 154, 71);
            btnSearchAttendance.Font = new Font("Segoe UI", 9F);
            btnSearchAttendance.ForeColor = Color.White;
            btnSearchAttendance.Location = new Point(705, 9);
            btnSearchAttendance.Name = "btnSearchAttendance";
            btnSearchAttendance.ShadowDecoration.BorderRadius = 9;
            btnSearchAttendance.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSearchAttendance.Size = new Size(67, 25);
            btnSearchAttendance.TabIndex = 23;
            btnSearchAttendance.Text = "Search";
            // 
            // pnlDgvDisplay
            // 
            pnlDgvDisplay.Dock = DockStyle.Fill;
            pnlDgvDisplay.Location = new Point(0, 0);
            pnlDgvDisplay.Name = "pnlDgvDisplay";
            pnlDgvDisplay.Size = new Size(785, 469);
            pnlDgvDisplay.TabIndex = 27;
            // 
            // Column2
            // 
            Column2.HeaderText = "Fullname";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Membership Type";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Status";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // frmAttendanceGridView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 469);
            Controls.Add(pnlDgvBack);
            Controls.Add(txtSearchAttendance);
            Controls.Add(lblChange);
            Controls.Add(btnSearchAttendance);
            Controls.Add(pnlDgvDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAttendanceGridView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAttendanceGridView";
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            pnlDgvBack.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAttendance;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column8;
        private csLaundrySystem.CustomizableCornerPanel pnlDgvBack;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchAttendance;
        private Label lblChange;
        private Guna.UI2.WinForms.Guna2Button btnSearchAttendance;
        private Panel pnlDgvDisplay;
    }
}