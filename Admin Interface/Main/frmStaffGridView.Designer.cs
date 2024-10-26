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
            pnlDgvBack = new csLaundrySystem.CustomizableCornerPanel();
            txtSearchStaff = new Guna.UI2.WinForms.Guna2TextBox();
            lblChange = new Label();
            btnSearchStaff = new Guna.UI2.WinForms.Guna2Button();
            pnlDgvDisplay = new Panel();
            clmFullName = new DataGridViewTextBoxColumn();
            clmEmail = new DataGridViewTextBoxColumn();
            clmPhoneNumber = new DataGridViewTextBoxColumn();
            clmEmployeeType = new DataGridViewTextBoxColumn();
            clmSalary = new DataGridViewTextBoxColumn();
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
            dgvStaffs.Columns.AddRange(new DataGridViewColumn[] { clmFullName, clmEmail, clmPhoneNumber, clmEmployeeType, clmSalary });
            dgvStaffs.EnableHeadersVisualStyles = false;
            dgvStaffs.GridColor = SystemColors.ScrollBar;
            dgvStaffs.Location = new Point(0, 3);
            dgvStaffs.Margin = new Padding(3, 4, 3, 4);
            dgvStaffs.Name = "dgvStaffs";
            dgvStaffs.ReadOnly = true;
            dgvStaffs.RowHeadersVisible = false;
            dgvStaffs.RowHeadersWidth = 35;
            dgvStaffs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaffs.Size = new Size(867, 571);
            dgvStaffs.TabIndex = 6;
            //dgvStaffs.CellContentClick += dgvStaffs_CellContentClick;
            // 
            // pnlDgvBack
            // 
            pnlDgvBack.BackColor = Color.FromArgb(41, 50, 113);
            pnlDgvBack.BorderColor = Color.Black;
            pnlDgvBack.BorderWidth = 1F;
            pnlDgvBack.Controls.Add(dgvStaffs);
            pnlDgvBack.CornerRadius = 20;
            pnlDgvBack.Location = new Point(17, 52);
            pnlDgvBack.Margin = new Padding(3, 4, 3, 4);
            pnlDgvBack.Name = "pnlDgvBack";
            pnlDgvBack.Size = new Size(866, 565);
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
            txtSearchStaff.Location = new Point(456, 12);
            txtSearchStaff.Margin = new Padding(3, 5, 3, 5);
            txtSearchStaff.Name = "txtSearchStaff";
            txtSearchStaff.PasswordChar = '\0';
            txtSearchStaff.PlaceholderForeColor = Color.FromArgb(112, 112, 112);
            txtSearchStaff.PlaceholderText = "⌕ Search Staff";
            txtSearchStaff.SelectedText = "";
            txtSearchStaff.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearchStaff.Size = new Size(344, 33);
            txtSearchStaff.TabIndex = 16;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.ForeColor = Color.Black;
            lblChange.Location = new Point(17, 12);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(61, 25);
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
            btnSearchStaff.Location = new Point(807, 12);
            btnSearchStaff.Margin = new Padding(3, 4, 3, 4);
            btnSearchStaff.Name = "btnSearchStaff";
            btnSearchStaff.ShadowDecoration.BorderRadius = 9;
            btnSearchStaff.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSearchStaff.Size = new Size(77, 33);
            btnSearchStaff.TabIndex = 14;
            btnSearchStaff.Text = "Search";
            // 
            // pnlDgvDisplay
            // 
            pnlDgvDisplay.Dock = DockStyle.Fill;
            pnlDgvDisplay.Location = new Point(0, 0);
            pnlDgvDisplay.Margin = new Padding(3, 4, 3, 4);
            pnlDgvDisplay.Name = "pnlDgvDisplay";
            pnlDgvDisplay.Size = new Size(897, 625);
            pnlDgvDisplay.TabIndex = 18;
            // 
            // clmFullName
            // 
            clmFullName.HeaderText = "Fullname";
            clmFullName.MinimumWidth = 6;
            clmFullName.Name = "clmFullName";
            clmFullName.ReadOnly = true;
            // 
            // clmEmail
            // 
            clmEmail.HeaderText = "Email";
            clmEmail.MinimumWidth = 6;
            clmEmail.Name = "clmEmail";
            clmEmail.ReadOnly = true;
            // 
            // clmPhoneNumber
            // 
            clmPhoneNumber.HeaderText = "Phone-Number";
            clmPhoneNumber.MinimumWidth = 6;
            clmPhoneNumber.Name = "clmPhoneNumber";
            clmPhoneNumber.ReadOnly = true;
            // 
            // clmEmployeeType
            // 
            clmEmployeeType.HeaderText = "Employee-Type";
            clmEmployeeType.MinimumWidth = 6;
            clmEmployeeType.Name = "clmEmployeeType";
            clmEmployeeType.ReadOnly = true;
            // 
            // clmSalary
            // 
            clmSalary.HeaderText = "Salary";
            clmSalary.MinimumWidth = 6;
            clmSalary.Name = "clmSalary";
            clmSalary.ReadOnly = true;
            // 
            // frmStaffGridView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 625);
            Controls.Add(pnlDgvBack);
            Controls.Add(txtSearchStaff);
            Controls.Add(lblChange);
            Controls.Add(btnSearchStaff);
            Controls.Add(pnlDgvDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmStaffGridView";
            Text = "frmStaffGridView";
            ((System.ComponentModel.ISupportInitialize)dgvStaffs).EndInit();
            pnlDgvBack.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStaffs;
        private csLaundrySystem.CustomizableCornerPanel pnlDgvBack;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchStaff;
        private Label lblChange;
        private Guna.UI2.WinForms.Guna2Button btnSearchStaff;
        private Panel pnlDgvDisplay;
        private DataGridViewTextBoxColumn clmFullName;
        private DataGridViewTextBoxColumn clmEmail;
        private DataGridViewTextBoxColumn clmPhoneNumber;
        private DataGridViewTextBoxColumn clmEmployeeType;
        private DataGridViewTextBoxColumn clmSalary;
    }
}