namespace csCY_Avenue.Admin_Interface.Main
{
    partial class frmStaffGridView
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
            dgvStaffs = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            pnlDgvBack = new csLaundrySystem.CustomizableCornerPanel();
            txtSearchStaff = new Guna.UI2.WinForms.Guna2TextBox();
            lblChange = new Label();
            btnSearchStaff = new Guna.UI2.WinForms.Guna2Button();
            pnlDgvDisplay = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvStaffs).BeginInit();
            pnlDgvBack.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStaffs
            // 
            dgvStaffs.AllowUserToAddRows = false;
            dgvStaffs.AllowUserToDeleteRows = false;
            dgvStaffs.AllowUserToResizeRows = false;
            dgvStaffs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaffs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvStaffs.BackgroundColor = Color.White;
            dgvStaffs.BorderStyle = BorderStyle.None;
            dgvStaffs.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvStaffs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStaffs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStaffs.ColumnHeadersHeight = 35;
            dgvStaffs.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dgvStaffs.EnableHeadersVisualStyles = false;
            dgvStaffs.GridColor = SystemColors.ScrollBar;
            dgvStaffs.Location = new Point(0, 2);
            dgvStaffs.Name = "dgvStaffs";
            dgvStaffs.ReadOnly = true;
            dgvStaffs.RowHeadersVisible = false;
            dgvStaffs.RowHeadersWidth = 35;
            dgvStaffs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaffs.Size = new Size(759, 428);
            dgvStaffs.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "Photo";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Fullname";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Age";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Sex";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Birthdate";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Email";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Membership Type";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Status";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // pnlDgvBack
            // 
            pnlDgvBack.BackColor = Color.FromArgb(41, 50, 113);
            pnlDgvBack.BorderColor = Color.Black;
            pnlDgvBack.BorderWidth = 1F;
            pnlDgvBack.Controls.Add(dgvStaffs);
            pnlDgvBack.CornerRadius = 20;
            pnlDgvBack.Location = new Point(15, 39);
            pnlDgvBack.Name = "pnlDgvBack";
            pnlDgvBack.Size = new Size(758, 424);
            pnlDgvBack.TabIndex = 17;
            // 
            // txtSearchStaff
            // 
            txtSearchStaff.CustomizableEdges = customizableEdges1;
            txtSearchStaff.DefaultText = "";
            txtSearchStaff.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchStaff.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchStaff.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchStaff.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchStaff.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchStaff.Font = new Font("Segoe UI", 9F);
            txtSearchStaff.ForeColor = Color.Black;
            txtSearchStaff.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchStaff.Location = new Point(399, 9);
            txtSearchStaff.Name = "txtSearchStaff";
            txtSearchStaff.PasswordChar = '\0';
            txtSearchStaff.PlaceholderForeColor = Color.FromArgb(112, 112, 112);
            txtSearchStaff.PlaceholderText = "⌕ Search Staff";
            txtSearchStaff.SelectedText = "";
            txtSearchStaff.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearchStaff.Size = new Size(301, 25);
            txtSearchStaff.TabIndex = 16;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.ForeColor = Color.Black;
            lblChange.Location = new Point(15, 9);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(50, 20);
            lblChange.TabIndex = 15;
            lblChange.Text = "Staffs";
            // 
            // btnSearchStaff
            // 
            btnSearchStaff.BackColor = Color.FromArgb(67, 154, 71);
            btnSearchStaff.CustomizableEdges = customizableEdges3;
            btnSearchStaff.DisabledState.BorderColor = Color.DarkGray;
            btnSearchStaff.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearchStaff.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearchStaff.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearchStaff.FillColor = Color.FromArgb(67, 154, 71);
            btnSearchStaff.Font = new Font("Segoe UI", 9F);
            btnSearchStaff.ForeColor = Color.White;
            btnSearchStaff.Location = new Point(706, 9);
            btnSearchStaff.Name = "btnSearchStaff";
            btnSearchStaff.ShadowDecoration.BorderRadius = 9;
            btnSearchStaff.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSearchStaff.Size = new Size(67, 25);
            btnSearchStaff.TabIndex = 14;
            btnSearchStaff.Text = "Search";
            // 
            // pnlDgvDisplay
            // 
            pnlDgvDisplay.Dock = DockStyle.Fill;
            pnlDgvDisplay.Location = new Point(0, 0);
            pnlDgvDisplay.Name = "pnlDgvDisplay";
            pnlDgvDisplay.Size = new Size(785, 469);
            pnlDgvDisplay.TabIndex = 18;
            // 
            // frmStaffGridView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 469);
            Controls.Add(pnlDgvBack);
            Controls.Add(txtSearchStaff);
            Controls.Add(lblChange);
            Controls.Add(btnSearchStaff);
            Controls.Add(pnlDgvDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmStaffGridView";
            Text = "frmStaffGridView";
            ((System.ComponentModel.ISupportInitialize)dgvStaffs).EndInit();
            pnlDgvBack.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStaffs;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private csLaundrySystem.CustomizableCornerPanel pnlDgvBack;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchStaff;
        private Label lblChange;
        private Guna.UI2.WinForms.Guna2Button btnSearchStaff;
        private Panel pnlDgvDisplay;
    }
}