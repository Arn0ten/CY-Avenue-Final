namespace csCY_Avenue.Admin_Interface
{
    partial class frmAttendanceStaff
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label3 = new Label();
            pnlDgvBack = new csLaundrySystem.CustomizableCornerPanel();
            dgvStaffsAttendance = new DataGridView();
            clmName = new DataGridViewTextBoxColumn();
            clmType = new DataGridViewTextBoxColumn();
            clmDate = new DataGridViewTextBoxColumn();
            clmTimeIn = new DataGridViewTextBoxColumn();
            clmTimeOut = new DataGridViewTextBoxColumn();
            clmStatus = new DataGridViewTextBoxColumn();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            btnMarkAttendance = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            radLate = new Guna.UI2.WinForms.Guna2RadioButton();
            radAbsent = new Guna.UI2.WinForms.Guna2RadioButton();
            radPresent = new Guna.UI2.WinForms.Guna2RadioButton();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dtTimeOut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtTimeIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cmbStaffs = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtRemarks = new Guna.UI2.WinForms.Guna2TextBox();
            dtStaffAttendanceDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnDateFilter = new Guna.UI2.WinForms.Guna2Button();
            pnlDgvBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaffsAttendance).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(291, 37);
            label3.TabIndex = 17;
            label3.Text = "STAFFS ATTENDANCE";
            // 
            // pnlDgvBack
            // 
            pnlDgvBack.BackColor = Color.FromArgb(41, 50, 113);
            pnlDgvBack.BorderColor = Color.Black;
            pnlDgvBack.BorderWidth = 1F;
            pnlDgvBack.Controls.Add(dgvStaffsAttendance);
            pnlDgvBack.CornerRadius = 20;
            pnlDgvBack.Location = new Point(491, 83);
            pnlDgvBack.Name = "pnlDgvBack";
            pnlDgvBack.Size = new Size(669, 596);
            pnlDgvBack.TabIndex = 130;
            // 
            // dgvStaffsAttendance
            // 
            dgvStaffsAttendance.AllowUserToAddRows = false;
            dgvStaffsAttendance.AllowUserToDeleteRows = false;
            dgvStaffsAttendance.AllowUserToResizeRows = false;
            dgvStaffsAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaffsAttendance.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvStaffsAttendance.BackgroundColor = Color.White;
            dgvStaffsAttendance.BorderStyle = BorderStyle.None;
            dgvStaffsAttendance.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvStaffsAttendance.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStaffsAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStaffsAttendance.ColumnHeadersHeight = 35;
            dgvStaffsAttendance.Columns.AddRange(new DataGridViewColumn[] { clmName, clmType, clmDate, clmTimeIn, clmTimeOut, clmStatus });
            dgvStaffsAttendance.EnableHeadersVisualStyles = false;
            dgvStaffsAttendance.GridColor = SystemColors.ScrollBar;
            dgvStaffsAttendance.Location = new Point(0, 2);
            dgvStaffsAttendance.Name = "dgvStaffsAttendance";
            dgvStaffsAttendance.ReadOnly = true;
            dgvStaffsAttendance.RowHeadersVisible = false;
            dgvStaffsAttendance.RowHeadersWidth = 35;
            dgvStaffsAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaffsAttendance.Size = new Size(669, 594);
            dgvStaffsAttendance.TabIndex = 6;
            // 
            // clmName
            // 
            clmName.HeaderText = "Name";
            clmName.MinimumWidth = 6;
            clmName.Name = "clmName";
            clmName.ReadOnly = true;
            // 
            // clmType
            // 
            clmType.HeaderText = "Employee Type";
            clmType.MinimumWidth = 6;
            clmType.Name = "clmType";
            clmType.ReadOnly = true;
            // 
            // clmDate
            // 
            clmDate.HeaderText = "Date";
            clmDate.MinimumWidth = 6;
            clmDate.Name = "clmDate";
            clmDate.ReadOnly = true;
            // 
            // clmTimeIn
            // 
            clmTimeIn.HeaderText = "Time-In";
            clmTimeIn.MinimumWidth = 6;
            clmTimeIn.Name = "clmTimeIn";
            clmTimeIn.ReadOnly = true;
            // 
            // clmTimeOut
            // 
            clmTimeOut.HeaderText = "Time-Out";
            clmTimeOut.MinimumWidth = 6;
            clmTimeOut.Name = "clmTimeOut";
            clmTimeOut.ReadOnly = true;
            // 
            // clmStatus
            // 
            clmStatus.HeaderText = "Status";
            clmStatus.MinimumWidth = 6;
            clmStatus.Name = "clmStatus";
            clmStatus.ReadOnly = true;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.FillColor = Color.Silver;
            guna2ShadowPanel1.Location = new Point(466, 77);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 8;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(5, 630);
            guna2ShadowPanel1.TabIndex = 129;
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
            btnMarkAttendance.Location = new Point(70, 637);
            btnMarkAttendance.Name = "btnMarkAttendance";
            btnMarkAttendance.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnMarkAttendance.Size = new Size(361, 42);
            btnMarkAttendance.TabIndex = 128;
            btnMarkAttendance.Text = "Mark Attendance";
            btnMarkAttendance.Click += btnMarkAttendance_Click;
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            guna2HtmlLabel5.ForeColor = Color.Black;
            guna2HtmlLabel5.Location = new Point(46, 437);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(76, 23);
            guna2HtmlLabel5.TabIndex = 127;
            guna2HtmlLabel5.Text = "Remarks  :";
            // 
            // radLate
            // 
            radLate.AutoSize = true;
            radLate.BackColor = SystemColors.Control;
            radLate.CheckedState.BorderColor = Color.FromArgb(249, 141, 5);
            radLate.CheckedState.BorderThickness = 10;
            radLate.CheckedState.FillColor = Color.FromArgb(249, 141, 5);
            radLate.CheckedState.InnerColor = Color.White;
            radLate.CheckedState.InnerOffset = -4;
            radLate.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            radLate.ForeColor = Color.FromArgb(64, 64, 64);
            radLate.Location = new Point(339, 371);
            radLate.Name = "radLate";
            radLate.Size = new Size(69, 24);
            radLate.TabIndex = 126;
            radLate.Text = "Late   ";
            radLate.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            radLate.UncheckedState.BorderThickness = 2;
            radLate.UncheckedState.FillColor = Color.Transparent;
            radLate.UncheckedState.InnerColor = Color.Transparent;
            radLate.UseVisualStyleBackColor = false;
            // 
            // radAbsent
            // 
            radAbsent.AutoSize = true;
            radAbsent.BackColor = SystemColors.Control;
            radAbsent.CheckedState.BorderColor = Color.FromArgb(218, 61, 49);
            radAbsent.CheckedState.BorderThickness = 10;
            radAbsent.CheckedState.FillColor = Color.FromArgb(218, 61, 49);
            radAbsent.CheckedState.InnerColor = Color.White;
            radAbsent.CheckedState.InnerOffset = -4;
            radAbsent.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            radAbsent.ForeColor = Color.FromArgb(64, 64, 64);
            radAbsent.Location = new Point(240, 371);
            radAbsent.Name = "radAbsent";
            radAbsent.Size = new Size(77, 24);
            radAbsent.TabIndex = 125;
            radAbsent.Text = "Absent";
            radAbsent.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            radAbsent.UncheckedState.BorderThickness = 2;
            radAbsent.UncheckedState.FillColor = Color.Transparent;
            radAbsent.UncheckedState.InnerColor = Color.Transparent;
            radAbsent.UseVisualStyleBackColor = false;
            // 
            // radPresent
            // 
            radPresent.AutoSize = true;
            radPresent.BackColor = SystemColors.Control;
            radPresent.BackgroundImageLayout = ImageLayout.Center;
            radPresent.CheckedState.BorderColor = Color.FromArgb(42, 98, 45);
            radPresent.CheckedState.BorderThickness = 10;
            radPresent.CheckedState.FillColor = Color.FromArgb(42, 98, 45);
            radPresent.CheckedState.InnerColor = Color.White;
            radPresent.CheckedState.InnerOffset = -4;
            radPresent.FlatAppearance.BorderColor = Color.Black;
            radPresent.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold);
            radPresent.ForeColor = Color.FromArgb(64, 64, 64);
            radPresent.Location = new Point(141, 371);
            radPresent.Name = "radPresent";
            radPresent.Size = new Size(80, 24);
            radPresent.TabIndex = 124;
            radPresent.Text = "Present";
            radPresent.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            radPresent.UncheckedState.BorderThickness = 2;
            radPresent.UncheckedState.FillColor = Color.Transparent;
            radPresent.UncheckedState.InnerColor = Color.Transparent;
            radPresent.UseVisualStyleBackColor = false;
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            guna2HtmlLabel4.ForeColor = Color.Black;
            guna2HtmlLabel4.Location = new Point(46, 372);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(58, 23);
            guna2HtmlLabel4.TabIndex = 123;
            guna2HtmlLabel4.Text = "Status  :";
            // 
            // dtTimeOut
            // 
            dtTimeOut.BorderColor = Color.Silver;
            dtTimeOut.BorderRadius = 5;
            dtTimeOut.BorderThickness = 1;
            dtTimeOut.Checked = true;
            dtTimeOut.CustomFormat = "hh:mm tt";
            dtTimeOut.CustomizableEdges = customizableEdges3;
            dtTimeOut.FillColor = Color.FromArgb(225, 63, 51);
            dtTimeOut.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            dtTimeOut.ForeColor = Color.White;
            dtTimeOut.Format = DateTimePickerFormat.Custom;
            dtTimeOut.Location = new Point(174, 288);
            dtTimeOut.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtTimeOut.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtTimeOut.Name = "dtTimeOut";
            dtTimeOut.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtTimeOut.ShowUpDown = true;
            dtTimeOut.Size = new Size(234, 36);
            dtTimeOut.TabIndex = 122;
            dtTimeOut.Value = new DateTime(2024, 10, 4, 8, 28, 58, 690);
            // 
            // dtTimeIn
            // 
            dtTimeIn.BorderColor = Color.Silver;
            dtTimeIn.BorderRadius = 5;
            dtTimeIn.BorderThickness = 1;
            dtTimeIn.Checked = true;
            dtTimeIn.CustomFormat = "hh:mm tt";
            dtTimeIn.CustomizableEdges = customizableEdges5;
            dtTimeIn.FillColor = Color.FromArgb(63, 139, 66);
            dtTimeIn.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            dtTimeIn.ForeColor = Color.White;
            dtTimeIn.Format = DateTimePickerFormat.Custom;
            dtTimeIn.Location = new Point(174, 240);
            dtTimeIn.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtTimeIn.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtTimeIn.Name = "dtTimeIn";
            dtTimeIn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dtTimeIn.ShowUpDown = true;
            dtTimeIn.Size = new Size(234, 36);
            dtTimeIn.TabIndex = 121;
            dtTimeIn.Value = new DateTime(2024, 10, 4, 8, 28, 58, 690);
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            guna2HtmlLabel3.ForeColor = Color.Black;
            guna2HtmlLabel3.Location = new Point(46, 295);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(81, 23);
            guna2HtmlLabel3.TabIndex = 120;
            guna2HtmlLabel3.Text = "Time  Out  :";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            guna2HtmlLabel1.ForeColor = Color.Black;
            guna2HtmlLabel1.Location = new Point(46, 247);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(68, 23);
            guna2HtmlLabel1.TabIndex = 119;
            guna2HtmlLabel1.Text = "Time In  :";
            // 
            // guna2HtmlLabel12
            // 
            guna2HtmlLabel12.BackColor = Color.Transparent;
            guna2HtmlLabel12.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel12.ForeColor = Color.Gray;
            guna2HtmlLabel12.Location = new Point(12, 179);
            guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            guna2HtmlLabel12.Size = new Size(152, 22);
            guna2HtmlLabel12.TabIndex = 118;
            guna2HtmlLabel12.Text = "MARK ATTENDANCE";
            // 
            // cmbStaffs
            // 
            cmbStaffs.BackColor = Color.Transparent;
            cmbStaffs.BorderColor = Color.Silver;
            cmbStaffs.BorderRadius = 5;
            cmbStaffs.CustomizableEdges = customizableEdges7;
            cmbStaffs.DrawMode = DrawMode.OwnerDrawFixed;
            cmbStaffs.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStaffs.FillColor = Color.FromArgb(219, 219, 219);
            cmbStaffs.FocusedColor = Color.FromArgb(41, 50, 113);
            cmbStaffs.FocusedState.BorderColor = Color.FromArgb(41, 50, 113);
            cmbStaffs.FocusedState.FillColor = Color.FromArgb(41, 50, 113);
            cmbStaffs.FocusedState.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbStaffs.FocusedState.ForeColor = Color.White;
            cmbStaffs.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbStaffs.ForeColor = Color.FromArgb(41, 50, 113);
            cmbStaffs.HoverState.FillColor = Color.FromArgb(41, 50, 113);
            cmbStaffs.HoverState.Font = new Font("Microsoft Sans Serif", 8.25F);
            cmbStaffs.HoverState.ForeColor = Color.White;
            cmbStaffs.ItemHeight = 30;
            cmbStaffs.Location = new Point(174, 83);
            cmbStaffs.Name = "cmbStaffs";
            cmbStaffs.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cmbStaffs.Size = new Size(234, 36);
            cmbStaffs.Sorted = true;
            cmbStaffs.TabIndex = 117;
            cmbStaffs.Tag = "Membership Type";
            cmbStaffs.TextAlign = HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            guna2HtmlLabel2.ForeColor = Color.Black;
            guna2HtmlLabel2.Location = new Point(46, 88);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(97, 23);
            guna2HtmlLabel2.TabIndex = 116;
            guna2HtmlLabel2.Text = "Staff Name :";
            // 
            // txtRemarks
            // 
            txtRemarks.BorderColor = Color.Silver;
            txtRemarks.BorderRadius = 5;
            txtRemarks.CustomizableEdges = customizableEdges9;
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
            txtRemarks.Location = new Point(141, 441);
            txtRemarks.Margin = new Padding(3, 4, 3, 4);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.PasswordChar = '\0';
            txtRemarks.PlaceholderForeColor = Color.Gray;
            txtRemarks.PlaceholderText = "Type here...";
            txtRemarks.SelectedText = "";
            txtRemarks.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtRemarks.Size = new Size(267, 156);
            txtRemarks.TabIndex = 115;
            // 
            // dtStaffAttendanceDate
            // 
            dtStaffAttendanceDate.BorderColor = Color.Silver;
            dtStaffAttendanceDate.BorderRadius = 5;
            dtStaffAttendanceDate.BorderThickness = 1;
            dtStaffAttendanceDate.Checked = true;
            dtStaffAttendanceDate.CustomizableEdges = customizableEdges11;
            dtStaffAttendanceDate.FillColor = Color.FromArgb(42, 54, 127);
            dtStaffAttendanceDate.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtStaffAttendanceDate.ForeColor = Color.White;
            dtStaffAttendanceDate.Format = DateTimePickerFormat.Long;
            dtStaffAttendanceDate.Location = new Point(545, 14);
            dtStaffAttendanceDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtStaffAttendanceDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtStaffAttendanceDate.Name = "dtStaffAttendanceDate";
            dtStaffAttendanceDate.ShadowDecoration.CustomizableEdges = customizableEdges12;
            dtStaffAttendanceDate.Size = new Size(203, 36);
            dtStaffAttendanceDate.TabIndex = 114;
            dtStaffAttendanceDate.Value = new DateTime(2024, 10, 4, 8, 28, 58, 690);
            // 
            // guna2HtmlLabel7
            // 
            guna2HtmlLabel7.BackColor = Color.Transparent;
            guna2HtmlLabel7.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel7.ForeColor = Color.Black;
            guna2HtmlLabel7.Location = new Point(494, 20);
            guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            guna2HtmlLabel7.Size = new Size(47, 23);
            guna2HtmlLabel7.TabIndex = 113;
            guna2HtmlLabel7.Text = "Date :";
            // 
            // btnDateFilter
            // 
            btnDateFilter.BorderColor = Color.FromArgb(67, 154, 71);
            btnDateFilter.BorderRadius = 5;
            btnDateFilter.BorderThickness = 1;
            btnDateFilter.CustomizableEdges = customizableEdges13;
            btnDateFilter.DisabledState.BorderColor = Color.DarkGray;
            btnDateFilter.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDateFilter.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDateFilter.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDateFilter.FillColor = Color.FromArgb(67, 154, 71);
            btnDateFilter.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDateFilter.ForeColor = Color.White;
            btnDateFilter.Image = Properties.Resources._4737438_equalizer_filter_filtering_mixer_sorting_icon3;
            btnDateFilter.Location = new Point(763, 14);
            btnDateFilter.Name = "btnDateFilter";
            btnDateFilter.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnDateFilter.Size = new Size(97, 36);
            btnDateFilter.TabIndex = 132;
            btnDateFilter.Text = "FILTER";
            // 
            // frmAttendanceStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 721);
            Controls.Add(btnDateFilter);
            Controls.Add(pnlDgvBack);
            Controls.Add(guna2ShadowPanel1);
            Controls.Add(btnMarkAttendance);
            Controls.Add(guna2HtmlLabel5);
            Controls.Add(radLate);
            Controls.Add(radAbsent);
            Controls.Add(radPresent);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(dtTimeOut);
            Controls.Add(dtTimeIn);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2HtmlLabel12);
            Controls.Add(cmbStaffs);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(txtRemarks);
            Controls.Add(dtStaffAttendanceDate);
            Controls.Add(guna2HtmlLabel7);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAttendanceStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAttendanceStaff";
            pnlDgvBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStaffsAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private csLaundrySystem.CustomizableCornerPanel pnlDgvBack;
        private DataGridView dgvStaffsAttendance;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Button btnMarkAttendance;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2RadioButton radLate;
        private Guna.UI2.WinForms.Guna2RadioButton radAbsent;
        private Guna.UI2.WinForms.Guna2RadioButton radPresent;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTimeOut;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTimeIn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStaffs;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtRemarks;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtStaffAttendanceDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmType;
        private DataGridViewTextBoxColumn clmDate;
        private DataGridViewTextBoxColumn clmTimeIn;
        private DataGridViewTextBoxColumn clmTimeOut;
        private DataGridViewTextBoxColumn clmStatus;
        private Guna.UI2.WinForms.Guna2Button btnDateFilter;
    }
}