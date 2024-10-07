namespace csCY_Avenue.Admin_Interface.Main
{
    partial class frmFixedTrainers
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
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            label1 = new Label();
            pnlDgvBack = new csLaundrySystem.CustomizableCornerPanel();
            dgvFixedTrainers = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            View = new DataGridViewButtonColumn();
            Attendance = new DataGridViewButtonColumn();
            Transaction = new DataGridViewButtonColumn();
            txtSearchTrainer = new Guna.UI2.WinForms.Guna2TextBox();
            btnSearchTrainer = new Guna.UI2.WinForms.Guna2Button();
            guna2ShadowPanel1.SuspendLayout();
            pnlDgvBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFixedTrainers).BeginInit();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(label1);
            guna2ShadowPanel1.Controls.Add(pnlDgvBack);
            guna2ShadowPanel1.Controls.Add(txtSearchTrainer);
            guna2ShadowPanel1.Controls.Add(btnSearchTrainer);
            guna2ShadowPanel1.FillColor = Color.FromArgb(224, 224, 224);
            guna2ShadowPanel1.Location = new Point(1, 1);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 5;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.ShadowDepth = 200;
            guna2ShadowPanel1.ShadowShift = 2;
            guna2ShadowPanel1.Size = new Size(1108, 600);
            guna2ShadowPanel1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(337, 9);
            label1.Name = "label1";
            label1.Size = new Size(229, 37);
            label1.TabIndex = 22;
            label1.Text = "FIXED TRAINERS";
            // 
            // pnlDgvBack
            // 
            pnlDgvBack.BackColor = Color.FromArgb(41, 50, 113);
            pnlDgvBack.BorderColor = Color.Black;
            pnlDgvBack.BorderWidth = 1F;
            pnlDgvBack.Controls.Add(dgvFixedTrainers);
            pnlDgvBack.CornerRadius = 20;
            pnlDgvBack.Location = new Point(13, 56);
            pnlDgvBack.Name = "pnlDgvBack";
            pnlDgvBack.Size = new Size(1083, 536);
            pnlDgvBack.TabIndex = 21;
            // 
            // dgvFixedTrainers
            // 
            dgvFixedTrainers.AllowUserToAddRows = false;
            dgvFixedTrainers.AllowUserToDeleteRows = false;
            dgvFixedTrainers.AllowUserToResizeRows = false;
            dgvFixedTrainers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFixedTrainers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvFixedTrainers.BackgroundColor = Color.White;
            dgvFixedTrainers.BorderStyle = BorderStyle.None;
            dgvFixedTrainers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvFixedTrainers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFixedTrainers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFixedTrainers.ColumnHeadersHeight = 35;
            dgvFixedTrainers.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Column1, Column2, Column3, View, Attendance, Transaction });
            dgvFixedTrainers.EnableHeadersVisualStyles = false;
            dgvFixedTrainers.GridColor = SystemColors.ScrollBar;
            dgvFixedTrainers.Location = new Point(0, 2);
            dgvFixedTrainers.Name = "dgvFixedTrainers";
            dgvFixedTrainers.ReadOnly = true;
            dgvFixedTrainers.RowHeadersVisible = false;
            dgvFixedTrainers.RowHeadersWidth = 35;
            dgvFixedTrainers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFixedTrainers.Size = new Size(1083, 535);
            dgvFixedTrainers.TabIndex = 6;
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
            View.HeaderText = "View";
            View.Name = "View";
            View.ReadOnly = true;
            View.Text = "View";
            View.UseColumnTextForButtonValue = true;
            // 
            // Attendance
            // 
            Attendance.HeaderText = "Attendance";
            Attendance.Name = "Attendance";
            Attendance.ReadOnly = true;
            Attendance.Text = "History";
            Attendance.UseColumnTextForButtonValue = true;
            // 
            // Transaction
            // 
            Transaction.HeaderText = "Transaction";
            Transaction.Name = "Transaction";
            Transaction.ReadOnly = true;
            Transaction.Text = "History";
            Transaction.UseColumnTextForButtonValue = true;
            // 
            // txtSearchTrainer
            // 
            txtSearchTrainer.BorderRadius = 5;
            txtSearchTrainer.CustomizableEdges = customizableEdges1;
            txtSearchTrainer.DefaultText = "";
            txtSearchTrainer.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchTrainer.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchTrainer.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchTrainer.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchTrainer.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchTrainer.Font = new Font("Segoe UI", 9F);
            txtSearchTrainer.ForeColor = Color.Black;
            txtSearchTrainer.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchTrainer.Location = new Point(686, 9);
            txtSearchTrainer.Name = "txtSearchTrainer";
            txtSearchTrainer.PasswordChar = '\0';
            txtSearchTrainer.PlaceholderForeColor = Color.FromArgb(112, 112, 112);
            txtSearchTrainer.PlaceholderText = "⌕ Search Member";
            txtSearchTrainer.SelectedText = "";
            txtSearchTrainer.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearchTrainer.Size = new Size(313, 41);
            txtSearchTrainer.TabIndex = 20;
            // 
            // btnSearchTrainer
            // 
            btnSearchTrainer.BackColor = Color.Transparent;
            btnSearchTrainer.BorderRadius = 5;
            btnSearchTrainer.CustomizableEdges = customizableEdges3;
            btnSearchTrainer.DisabledState.BorderColor = Color.DarkGray;
            btnSearchTrainer.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearchTrainer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearchTrainer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearchTrainer.FillColor = Color.FromArgb(67, 154, 71);
            btnSearchTrainer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchTrainer.ForeColor = Color.White;
            btnSearchTrainer.HoverState.CustomBorderColor = Color.FromArgb(125, 183, 127);
            btnSearchTrainer.HoverState.ForeColor = Color.White;
            btnSearchTrainer.Location = new Point(1003, 9);
            btnSearchTrainer.Name = "btnSearchTrainer";
            btnSearchTrainer.PressedColor = Color.FromArgb(67, 154, 71);
            btnSearchTrainer.ShadowDecoration.BorderRadius = 9;
            btnSearchTrainer.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSearchTrainer.Size = new Size(93, 41);
            btnSearchTrainer.TabIndex = 19;
            btnSearchTrainer.Text = "Search";
            // 
            // frmFixedTrainers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 602);
            Controls.Add(guna2ShadowPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFixedTrainers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFixedTrainers";
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            pnlDgvBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFixedTrainers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Label label1;
        private csLaundrySystem.CustomizableCornerPanel pnlDgvBack;
        private DataGridView dgvFixedTrainers;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewButtonColumn View;
        private DataGridViewButtonColumn Attendance;
        private DataGridViewButtonColumn Transaction;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchTrainer;
        private Guna.UI2.WinForms.Guna2Button btnSearchTrainer;
    }
}