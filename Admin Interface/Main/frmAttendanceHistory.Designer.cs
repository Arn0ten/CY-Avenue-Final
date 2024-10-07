namespace csCY_Avenue.Admin_Interface.Main
{
    partial class frmAttendanceHistory
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            button1 = new Button();
            guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            label1 = new Label();
            FormDesign = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            pnlDgvBack = new csLaundrySystem.CustomizableCornerPanel();
            dgvAttendanceHistory = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            ClassName = new DataGridViewTextBoxColumn();
            AttendanceStatus = new DataGridViewTextBoxColumn();
            guna2ShadowPanel2.SuspendLayout();
            pnlDgvBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendanceHistory).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(41, 50, 113);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources._10758949_x_icon2;
            button1.Location = new Point(594, 8);
            button1.Name = "button1";
            button1.Size = new Size(34, 30);
            button1.TabIndex = 84;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // guna2ShadowPanel2
            // 
            guna2ShadowPanel2.BackColor = Color.Transparent;
            guna2ShadowPanel2.Controls.Add(button1);
            guna2ShadowPanel2.Controls.Add(label1);
            guna2ShadowPanel2.Dock = DockStyle.Top;
            guna2ShadowPanel2.FillColor = Color.FromArgb(41, 50, 113);
            guna2ShadowPanel2.Location = new Point(0, 0);
            guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            guna2ShadowPanel2.Radius = 4;
            guna2ShadowPanel2.ShadowColor = Color.Transparent;
            guna2ShadowPanel2.ShadowDepth = 1;
            guna2ShadowPanel2.ShadowShift = 1;
            guna2ShadowPanel2.Size = new Size(636, 47);
            guna2ShadowPanel2.TabIndex = 92;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(226, 13);
            label1.Name = "label1";
            label1.Size = new Size(185, 21);
            label1.TabIndex = 2;
            label1.Text = "ATTENDANCE HISTORY";
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
            // pnlDgvBack
            // 
            pnlDgvBack.BackColor = Color.FromArgb(41, 50, 113);
            pnlDgvBack.BorderColor = Color.Black;
            pnlDgvBack.BorderWidth = 1F;
            pnlDgvBack.Controls.Add(dgvAttendanceHistory);
            pnlDgvBack.CornerRadius = 20;
            pnlDgvBack.Location = new Point(12, 55);
            pnlDgvBack.Name = "pnlDgvBack";
            pnlDgvBack.Size = new Size(612, 338);
            pnlDgvBack.TabIndex = 93;
            // 
            // dgvAttendanceHistory
            // 
            dgvAttendanceHistory.AllowUserToAddRows = false;
            dgvAttendanceHistory.AllowUserToDeleteRows = false;
            dgvAttendanceHistory.AllowUserToResizeRows = false;
            dgvAttendanceHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendanceHistory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAttendanceHistory.BackgroundColor = Color.White;
            dgvAttendanceHistory.BorderStyle = BorderStyle.None;
            dgvAttendanceHistory.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvAttendanceHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle2.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAttendanceHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAttendanceHistory.ColumnHeadersHeight = 35;
            dgvAttendanceHistory.Columns.AddRange(new DataGridViewColumn[] { Date, ClassName, AttendanceStatus });
            dgvAttendanceHistory.EnableHeadersVisualStyles = false;
            dgvAttendanceHistory.GridColor = SystemColors.ScrollBar;
            dgvAttendanceHistory.Location = new Point(0, 3);
            dgvAttendanceHistory.Name = "dgvAttendanceHistory";
            dgvAttendanceHistory.ReadOnly = true;
            dgvAttendanceHistory.RowHeadersVisible = false;
            dgvAttendanceHistory.RowHeadersWidth = 35;
            dgvAttendanceHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendanceHistory.Size = new Size(612, 335);
            dgvAttendanceHistory.TabIndex = 6;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // ClassName
            // 
            ClassName.HeaderText = "Class Name";
            ClassName.Name = "ClassName";
            ClassName.ReadOnly = true;
            // 
            // AttendanceStatus
            // 
            AttendanceStatus.HeaderText = "Attendance Status";
            AttendanceStatus.Name = "AttendanceStatus";
            AttendanceStatus.ReadOnly = true;
            // 
            // frmAttendanceHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 407);
            Controls.Add(pnlDgvBack);
            Controls.Add(guna2ShadowPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAttendanceHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAttendanceHistory";
            guna2ShadowPanel2.ResumeLayout(false);
            guna2ShadowPanel2.PerformLayout();
            pnlDgvBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAttendanceHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm FormDesign;
        private csLaundrySystem.CustomizableCornerPanel pnlDgvBack;
        private DataGridView dgvAttendanceHistory;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn AttendanceStatus;
    }
}