namespace csCY_Avenue.Staff_Interface.Main
{
    partial class frmPersonalTrainerClasses
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvTrainerClass = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            ClassName = new DataGridViewTextBoxColumn();
            NumberOfAttendees = new DataGridViewTextBoxColumn();
            button1 = new Button();
            guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            label1 = new Label();
            FormDesign = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            pnlDgvBack = new csLaundrySystem.CustomizableCornerPanel();
            ((System.ComponentModel.ISupportInitialize)dgvTrainerClass).BeginInit();
            guna2ShadowPanel2.SuspendLayout();
            pnlDgvBack.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTrainerClass
            // 
            dgvTrainerClass.AllowUserToAddRows = false;
            dgvTrainerClass.AllowUserToDeleteRows = false;
            dgvTrainerClass.AllowUserToResizeRows = false;
            dgvTrainerClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrainerClass.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTrainerClass.BackgroundColor = Color.White;
            dgvTrainerClass.BorderStyle = BorderStyle.None;
            dgvTrainerClass.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvTrainerClass.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTrainerClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTrainerClass.ColumnHeadersHeight = 35;
            dgvTrainerClass.Columns.AddRange(new DataGridViewColumn[] { Date, ClassName, NumberOfAttendees });
            dgvTrainerClass.EnableHeadersVisualStyles = false;
            dgvTrainerClass.GridColor = SystemColors.ScrollBar;
            dgvTrainerClass.Location = new Point(0, 3);
            dgvTrainerClass.Name = "dgvTrainerClass";
            dgvTrainerClass.ReadOnly = true;
            dgvTrainerClass.RowHeadersVisible = false;
            dgvTrainerClass.RowHeadersWidth = 35;
            dgvTrainerClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrainerClass.Size = new Size(612, 335);
            dgvTrainerClass.TabIndex = 6;
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
            // NumberOfAttendees
            // 
            NumberOfAttendees.HeaderText = "Number Of Attendees";
            NumberOfAttendees.Name = "NumberOfAttendees";
            NumberOfAttendees.ReadOnly = true;
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
            guna2ShadowPanel2.TabIndex = 98;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(254, 13);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 2;
            label1.Text = "TRAINER CLASS";
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
            pnlDgvBack.Controls.Add(dgvTrainerClass);
            pnlDgvBack.CornerRadius = 20;
            pnlDgvBack.Location = new Point(12, 61);
            pnlDgvBack.Name = "pnlDgvBack";
            pnlDgvBack.Size = new Size(612, 338);
            pnlDgvBack.TabIndex = 99;
            // 
            // frmPersonalTrainerClasses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 407);
            Controls.Add(guna2ShadowPanel2);
            Controls.Add(pnlDgvBack);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPersonalTrainerClasses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPersonalTrainerClasses";
            ((System.ComponentModel.ISupportInitialize)dgvTrainerClass).EndInit();
            guna2ShadowPanel2.ResumeLayout(false);
            guna2ShadowPanel2.PerformLayout();
            pnlDgvBack.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTrainerClass;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn NumberOfAttendees;
        private Button button1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm FormDesign;
        private csLaundrySystem.CustomizableCornerPanel pnlDgvBack;
    }
}