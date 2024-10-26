namespace csCY_Avenue.Staff_Interface.Main
{
    partial class frmAttendanceMember
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlDgvBack = new csLaundrySystem.CustomizableCornerPanel();
            dgvMembersAttendance = new DataGridView();
            clmName = new DataGridViewTextBoxColumn();
            clmType = new DataGridViewTextBoxColumn();
            clmDate = new DataGridViewTextBoxColumn();
            clmTimeIn = new DataGridViewTextBoxColumn();
            clmStatus = new DataGridViewTextBoxColumn();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            btnMarkAttendance = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dtTimeIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cmbMembers = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtRemarks = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            btnDateFilter = new Guna.UI2.WinForms.Guna2Button();
            dtMemberAttendanceDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pnlDgvBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembersAttendance).BeginInit();
            SuspendLayout();
            // 
            // pnlDgvBack
            // 
            pnlDgvBack.BackColor = Color.FromArgb(41, 50, 113);
            pnlDgvBack.BorderColor = Color.Black;
            pnlDgvBack.BorderWidth = 1F;
            pnlDgvBack.Controls.Add(dgvMembersAttendance);
            pnlDgvBack.CornerRadius = 20;
            pnlDgvBack.Location = new Point(569, 119);
            pnlDgvBack.Margin = new Padding(3, 4, 3, 4);
            pnlDgvBack.Name = "pnlDgvBack";
            pnlDgvBack.Size = new Size(765, 795);
            pnlDgvBack.TabIndex = 131;
            // 
            // dgvMembersAttendance
            // 
            dgvMembersAttendance.AllowUserToAddRows = false;
            dgvMembersAttendance.AllowUserToDeleteRows = false;
            dgvMembersAttendance.AllowUserToResizeRows = false;
            dgvMembersAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembersAttendance.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMembersAttendance.BackgroundColor = Color.White;
            dgvMembersAttendance.BorderStyle = BorderStyle.None;
            dgvMembersAttendance.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvMembersAttendance.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMembersAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMembersAttendance.ColumnHeadersHeight = 35;
            dgvMembersAttendance.Columns.AddRange(new DataGridViewColumn[] { clmName, clmType, clmDate, clmTimeIn, clmStatus });
            dgvMembersAttendance.EnableHeadersVisualStyles = false;
            dgvMembersAttendance.GridColor = SystemColors.ScrollBar;
            dgvMembersAttendance.Location = new Point(0, 1);
            dgvMembersAttendance.Margin = new Padding(3, 4, 3, 4);
            dgvMembersAttendance.Name = "dgvMembersAttendance";
            dgvMembersAttendance.ReadOnly = true;
            dgvMembersAttendance.RowHeadersVisible = false;
            dgvMembersAttendance.RowHeadersWidth = 35;
            dgvMembersAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembersAttendance.Size = new Size(765, 792);
            dgvMembersAttendance.TabIndex = 7;
            // 
            // clmName
            // 
            dataGridViewCellStyle2.Font = new Font("Nirmala UI", 8.25F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            clmName.DefaultCellStyle = dataGridViewCellStyle2;
            clmName.HeaderText = "Name";
            clmName.MinimumWidth = 6;
            clmName.Name = "clmName";
            clmName.ReadOnly = true;
            // 
            // clmType
            // 
            clmType.HeaderText = "Type";
            clmType.MinimumWidth = 6;
            clmType.Name = "clmType";
            clmType.ReadOnly = true;
            // 
            // clmDate
            // 
            dataGridViewCellStyle3.Font = new Font("Nirmala UI", 8.25F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Green;
            clmDate.DefaultCellStyle = dataGridViewCellStyle3;
            clmDate.HeaderText = "Date";
            clmDate.MinimumWidth = 6;
            clmDate.Name = "clmDate";
            clmDate.ReadOnly = true;
            // 
            // clmTimeIn
            // 
            dataGridViewCellStyle4.Font = new Font("Nirmala UI", 8.25F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(192, 0, 0);
            clmTimeIn.DefaultCellStyle = dataGridViewCellStyle4;
            clmTimeIn.HeaderText = "Time-In";
            clmTimeIn.MinimumWidth = 6;
            clmTimeIn.Name = "clmTimeIn";
            clmTimeIn.ReadOnly = true;
            // 
            // clmStatus
            // 
            dataGridViewCellStyle5.Font = new Font("Nirmala UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            clmStatus.DefaultCellStyle = dataGridViewCellStyle5;
            clmStatus.HeaderText = "Status";
            clmStatus.MinimumWidth = 6;
            clmStatus.Name = "clmStatus";
            clmStatus.ReadOnly = true;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.FillColor = Color.Silver;
            guna2ShadowPanel1.Location = new Point(541, 111);
            guna2ShadowPanel1.Margin = new Padding(3, 4, 3, 4);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 8;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(6, 840);
            guna2ShadowPanel1.TabIndex = 130;
            // 
            // btnMarkAttendance
            // 
            btnMarkAttendance.BorderColor = Color.FromArgb(67, 154, 71);
            btnMarkAttendance.BorderRadius = 5;
            btnMarkAttendance.BorderThickness = 1;
            btnMarkAttendance.CustomizableEdges = customizableEdges1;
            btnMarkAttendance.DisabledState.BorderColor = Color.DarkGray;
            btnMarkAttendance.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMarkAttendance.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMarkAttendance.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMarkAttendance.FillColor = Color.FromArgb(67, 154, 71);
            btnMarkAttendance.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMarkAttendance.ForeColor = Color.White;
            btnMarkAttendance.Location = new Point(88, 857);
            btnMarkAttendance.Margin = new Padding(3, 4, 3, 4);
            btnMarkAttendance.Name = "btnMarkAttendance";
            btnMarkAttendance.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnMarkAttendance.Size = new Size(413, 56);
            btnMarkAttendance.TabIndex = 129;
            btnMarkAttendance.Text = "Mark Attendance";
            btnMarkAttendance.Click += btnMarkAttendance_Click;
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            guna2HtmlLabel5.ForeColor = Color.Black;
            guna2HtmlLabel5.Location = new Point(61, 591);
            guna2HtmlLabel5.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(95, 30);
            guna2HtmlLabel5.TabIndex = 128;
            guna2HtmlLabel5.Text = "Remarks  :";
            // 
            // dtTimeIn
            // 
            dtTimeIn.BorderColor = Color.Silver;
            dtTimeIn.BorderRadius = 5;
            dtTimeIn.BorderThickness = 1;
            dtTimeIn.Checked = true;
            dtTimeIn.CustomFormat = "hh:mm tt";
            dtTimeIn.CustomizableEdges = customizableEdges3;
            dtTimeIn.FillColor = Color.FromArgb(63, 139, 66);
            dtTimeIn.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            dtTimeIn.Format = DateTimePickerFormat.Custom;
            dtTimeIn.Location = new Point(207, 328);
            dtTimeIn.Margin = new Padding(3, 4, 3, 4);
            dtTimeIn.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtTimeIn.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtTimeIn.Name = "dtTimeIn";
            dtTimeIn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtTimeIn.ShowUpDown = true;
            dtTimeIn.Size = new Size(267, 48);
            dtTimeIn.TabIndex = 122;
            dtTimeIn.Value = new DateTime(2024, 10, 4, 8, 28, 58, 690);
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            guna2HtmlLabel1.ForeColor = Color.Black;
            guna2HtmlLabel1.Location = new Point(61, 337);
            guna2HtmlLabel1.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(85, 30);
            guna2HtmlLabel1.TabIndex = 120;
            guna2HtmlLabel1.Text = "Time In  :";
            // 
            // guna2HtmlLabel12
            // 
            guna2HtmlLabel12.BackColor = Color.Transparent;
            guna2HtmlLabel12.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel12.ForeColor = Color.Gray;
            guna2HtmlLabel12.Location = new Point(22, 247);
            guna2HtmlLabel12.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            guna2HtmlLabel12.Size = new Size(187, 27);
            guna2HtmlLabel12.TabIndex = 119;
            guna2HtmlLabel12.Text = "MARK ATTENDANCE";
            // 
            // cmbMembers
            // 
            cmbMembers.BackColor = Color.Transparent;
            cmbMembers.BorderColor = Color.Silver;
            cmbMembers.BorderRadius = 5;
            cmbMembers.CustomizableEdges = customizableEdges5;
            cmbMembers.DrawMode = DrawMode.OwnerDrawFixed;
            cmbMembers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMembers.FillColor = Color.FromArgb(219, 219, 219);
            cmbMembers.FocusedColor = Color.FromArgb(41, 50, 113);
            cmbMembers.FocusedState.BorderColor = Color.FromArgb(41, 50, 113);
            cmbMembers.FocusedState.FillColor = Color.FromArgb(41, 50, 113);
            cmbMembers.FocusedState.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbMembers.FocusedState.ForeColor = Color.White;
            cmbMembers.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbMembers.ForeColor = Color.FromArgb(41, 50, 113);
            cmbMembers.HoverState.FillColor = Color.FromArgb(41, 50, 113);
            cmbMembers.HoverState.Font = new Font("Microsoft Sans Serif", 8.25F);
            cmbMembers.HoverState.ForeColor = Color.White;
            cmbMembers.ItemHeight = 30;
            cmbMembers.Location = new Point(207, 119);
            cmbMembers.Margin = new Padding(3, 4, 3, 4);
            cmbMembers.Name = "cmbMembers";
            cmbMembers.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cmbMembers.Size = new Size(267, 36);
            cmbMembers.Sorted = true;
            cmbMembers.TabIndex = 118;
            cmbMembers.Tag = "Membership Type";
            cmbMembers.TextAlign = HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            guna2HtmlLabel2.ForeColor = Color.Black;
            guna2HtmlLabel2.Location = new Point(61, 125);
            guna2HtmlLabel2.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(155, 30);
            guna2HtmlLabel2.TabIndex = 117;
            guna2HtmlLabel2.Text = "Member Name :";
            // 
            // txtRemarks
            // 
            txtRemarks.BorderColor = Color.Silver;
            txtRemarks.BorderRadius = 5;
            txtRemarks.CustomizableEdges = customizableEdges7;
            txtRemarks.DefaultText = "";
            txtRemarks.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtRemarks.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtRemarks.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtRemarks.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtRemarks.FillColor = Color.FromArgb(224, 224, 224);
            txtRemarks.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRemarks.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRemarks.ForeColor = Color.Black;
            txtRemarks.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRemarks.Location = new Point(169, 596);
            txtRemarks.Margin = new Padding(3, 5, 3, 5);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.PasswordChar = '\0';
            txtRemarks.PlaceholderForeColor = Color.Gray;
            txtRemarks.PlaceholderText = "Type here...";
            txtRemarks.SelectedText = "";
            txtRemarks.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtRemarks.Size = new Size(305, 208);
            txtRemarks.TabIndex = 116;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(416, 46);
            label3.TabIndex = 113;
            label3.Text = "MEMBERS ATTENDANCE";
            // 
            // btnDateFilter
            // 
            btnDateFilter.BorderColor = Color.FromArgb(67, 154, 71);
            btnDateFilter.BorderRadius = 5;
            btnDateFilter.BorderThickness = 1;
            btnDateFilter.CustomizableEdges = customizableEdges9;
            btnDateFilter.DisabledState.BorderColor = Color.DarkGray;
            btnDateFilter.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDateFilter.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDateFilter.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDateFilter.FillColor = Color.FromArgb(67, 154, 71);
            btnDateFilter.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDateFilter.ForeColor = Color.White;
            btnDateFilter.Image = Properties.Resources._4737438_equalizer_filter_filtering_mixer_sorting_icon3;
            btnDateFilter.Location = new Point(906, 13);
            btnDateFilter.Margin = new Padding(3, 4, 3, 4);
            btnDateFilter.Name = "btnDateFilter";
            btnDateFilter.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnDateFilter.Size = new Size(111, 48);
            btnDateFilter.TabIndex = 136;
            btnDateFilter.Text = "FILTER";
            btnDateFilter.Click += btnDateFilter_Click;
            // 
            // dtMemberAttendanceDate
            // 
            dtMemberAttendanceDate.BorderColor = Color.Silver;
            dtMemberAttendanceDate.BorderRadius = 5;
            dtMemberAttendanceDate.BorderThickness = 1;
            dtMemberAttendanceDate.Checked = true;
            dtMemberAttendanceDate.CustomizableEdges = customizableEdges11;
            dtMemberAttendanceDate.FillColor = Color.FromArgb(42, 54, 127);
            dtMemberAttendanceDate.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtMemberAttendanceDate.ForeColor = Color.White;
            dtMemberAttendanceDate.Format = DateTimePickerFormat.Long;
            dtMemberAttendanceDate.Location = new Point(657, 13);
            dtMemberAttendanceDate.Margin = new Padding(3, 4, 3, 4);
            dtMemberAttendanceDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtMemberAttendanceDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtMemberAttendanceDate.Name = "dtMemberAttendanceDate";
            dtMemberAttendanceDate.ShadowDecoration.CustomizableEdges = customizableEdges12;
            dtMemberAttendanceDate.Size = new Size(232, 48);
            dtMemberAttendanceDate.TabIndex = 135;
            dtMemberAttendanceDate.Value = new DateTime(2024, 10, 4, 8, 28, 58, 690);
            // 
            // guna2HtmlLabel7
            // 
            guna2HtmlLabel7.BackColor = Color.Transparent;
            guna2HtmlLabel7.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel7.ForeColor = Color.Black;
            guna2HtmlLabel7.Location = new Point(599, 21);
            guna2HtmlLabel7.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            guna2HtmlLabel7.Size = new Size(59, 30);
            guna2HtmlLabel7.TabIndex = 134;
            guna2HtmlLabel7.Text = "Date :";
            // 
            // frmAttendanceMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 961);
            Controls.Add(btnDateFilter);
            Controls.Add(dtMemberAttendanceDate);
            Controls.Add(guna2HtmlLabel7);
            Controls.Add(pnlDgvBack);
            Controls.Add(guna2ShadowPanel1);
            Controls.Add(btnMarkAttendance);
            Controls.Add(guna2HtmlLabel5);
            Controls.Add(dtTimeIn);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2HtmlLabel12);
            Controls.Add(cmbMembers);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(txtRemarks);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAttendanceMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAttendanceMember";
            pnlDgvBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMembersAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private csLaundrySystem.CustomizableCornerPanel pnlDgvBack;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Button btnMarkAttendance;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTimeIn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMembers;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtRemarks;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button btnDateFilter;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtMemberAttendanceDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private DataGridView dgvMembersAttendance;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmType;
        private DataGridViewTextBoxColumn clmDate;
        private DataGridViewTextBoxColumn clmTimeIn;
        private DataGridViewTextBoxColumn clmStatus;
    }
}