namespace csCY_Avenue.Admin_Interface.Main
{
    partial class frmMemberMainForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlDisplay = new Panel();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            cmbMemberGridViewFilter = new ComboBox();
            pnlDgvBack = new csLaundrySystem.CustomizableCornerPanel();
            dgvMembers = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            View = new DataGridViewButtonColumn();
            Attendance = new DataGridViewButtonColumn();
            txtSearchMember = new Guna.UI2.WinForms.Guna2TextBox();
            btnSearchMember = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            pnlDisplay.SuspendLayout();
            guna2ShadowPanel1.SuspendLayout();
            pnlDgvBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();
            // 
            // pnlDisplay
            // 
            pnlDisplay.Controls.Add(guna2ShadowPanel1);
            pnlDisplay.Controls.Add(label3);
            pnlDisplay.Dock = DockStyle.Fill;
            pnlDisplay.Location = new Point(0, 0);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(1173, 721);
            pnlDisplay.TabIndex = 2;
            pnlDisplay.Paint += pnlDisplay_Paint;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(cmbMemberGridViewFilter);
            guna2ShadowPanel1.Controls.Add(pnlDgvBack);
            guna2ShadowPanel1.Controls.Add(txtSearchMember);
            guna2ShadowPanel1.Controls.Add(btnSearchMember);
            guna2ShadowPanel1.FillColor = Color.FromArgb(224, 224, 224);
            guna2ShadowPanel1.Location = new Point(26, 80);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 5;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.ShadowDepth = 200;
            guna2ShadowPanel1.ShadowShift = 2;
            guna2ShadowPanel1.Size = new Size(1108, 629);
            guna2ShadowPanel1.TabIndex = 17;
            // 
            // cmbMemberGridViewFilter
            // 
            cmbMemberGridViewFilter.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMemberGridViewFilter.FormattingEnabled = true;
            cmbMemberGridViewFilter.Items.AddRange(new object[] { "VIP", "Walk-in", "Accessibilty", "Walk-in(Treadmill)" });
            cmbMemberGridViewFilter.Location = new Point(14, 24);
            cmbMemberGridViewFilter.Name = "cmbMemberGridViewFilter";
            cmbMemberGridViewFilter.Size = new Size(117, 28);
            cmbMemberGridViewFilter.TabIndex = 17;
            cmbMemberGridViewFilter.Tag = "";
            cmbMemberGridViewFilter.Text = "Filter";
            // 
            // pnlDgvBack
            // 
            pnlDgvBack.BackColor = Color.FromArgb(41, 50, 113);
            pnlDgvBack.BorderColor = Color.Black;
            pnlDgvBack.BorderWidth = 1F;
            pnlDgvBack.Controls.Add(dgvMembers);
            pnlDgvBack.CornerRadius = 20;
            pnlDgvBack.Location = new Point(14, 62);
            pnlDgvBack.Name = "pnlDgvBack";
            pnlDgvBack.Size = new Size(1083, 554);
            pnlDgvBack.TabIndex = 16;
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AllowUserToResizeRows = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMembers.BackgroundColor = Color.White;
            dgvMembers.BorderStyle = BorderStyle.None;
            dgvMembers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvMembers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMembers.ColumnHeadersHeight = 35;
            dgvMembers.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Column1, Column2, Column3, View, Attendance });
            dgvMembers.EnableHeadersVisualStyles = false;
            dgvMembers.GridColor = SystemColors.ScrollBar;
            dgvMembers.Location = new Point(0, 2);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersVisible = false;
            dgvMembers.RowHeadersWidth = 35;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(1083, 552);
            dgvMembers.TabIndex = 6;
            dgvMembers.CellContentClick += dgvMembers_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Membership ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Member Name";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Membership Type";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Status";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // View
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(101, 173, 104);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            View.DefaultCellStyle = dataGridViewCellStyle2;
            View.HeaderText = "View";
            View.Name = "View";
            View.ReadOnly = true;
            View.Text = "View";
            View.UseColumnTextForButtonValue = true;
            // 
            // Attendance
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(92, 107, 192);
            Attendance.DefaultCellStyle = dataGridViewCellStyle3;
            Attendance.HeaderText = "Attendance";
            Attendance.Name = "Attendance";
            Attendance.ReadOnly = true;
            Attendance.Text = "History";
            Attendance.UseColumnTextForButtonValue = true;
            // 
            // txtSearchMember
            // 
            txtSearchMember.BorderRadius = 5;
            txtSearchMember.CustomizableEdges = customizableEdges1;
            txtSearchMember.DefaultText = "";
            txtSearchMember.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchMember.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchMember.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchMember.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchMember.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchMember.Font = new Font("Segoe UI", 9F);
            txtSearchMember.ForeColor = Color.Black;
            txtSearchMember.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchMember.Location = new Point(687, 15);
            txtSearchMember.Name = "txtSearchMember";
            txtSearchMember.PasswordChar = '\0';
            txtSearchMember.PlaceholderForeColor = Color.FromArgb(112, 112, 112);
            txtSearchMember.PlaceholderText = "⌕ Search Member";
            txtSearchMember.SelectedText = "";
            txtSearchMember.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearchMember.Size = new Size(313, 41);
            txtSearchMember.TabIndex = 15;
            // 
            // btnSearchMember
            // 
            btnSearchMember.BackColor = Color.Transparent;
            btnSearchMember.BorderRadius = 5;
            btnSearchMember.CustomizableEdges = customizableEdges3;
            btnSearchMember.DisabledState.BorderColor = Color.DarkGray;
            btnSearchMember.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearchMember.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearchMember.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearchMember.FillColor = Color.FromArgb(67, 154, 71);
            btnSearchMember.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchMember.ForeColor = Color.White;
            btnSearchMember.HoverState.CustomBorderColor = Color.FromArgb(125, 183, 127);
            btnSearchMember.HoverState.ForeColor = Color.White;
            btnSearchMember.Location = new Point(1004, 15);
            btnSearchMember.Name = "btnSearchMember";
            btnSearchMember.PressedColor = Color.FromArgb(67, 154, 71);
            btnSearchMember.ShadowDecoration.BorderRadius = 9;
            btnSearchMember.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSearchMember.Size = new Size(93, 41);
            btnSearchMember.TabIndex = 14;
            btnSearchMember.Text = "Search";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 37);
            label3.TabIndex = 15;
            label3.Text = "MEMBERS";
            // 
            // frmMemberMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 721);
            Controls.Add(pnlDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMemberMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMemberMainForm";
            Load += frmMemberMainForm_Load;
            pnlDisplay.ResumeLayout(false);
            pnlDisplay.PerformLayout();
            guna2ShadowPanel1.ResumeLayout(false);
            pnlDgvBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDisplay;
        private Label label3;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private ComboBox cmbMemberGridViewFilter;
        private csLaundrySystem.CustomizableCornerPanel pnlDgvBack;
        private DataGridView dgvMembers;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchMember;
        private Guna.UI2.WinForms.Guna2Button btnSearchMember;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewButtonColumn View;
        private DataGridViewButtonColumn Attendance;
    }
}