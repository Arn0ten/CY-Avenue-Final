﻿namespace csCY_Avenue.Staff_Interface.Main
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            label1 = new Label();
            pnlDgvBack = new csLaundrySystem.CustomizableCornerPanel();
            dgvFixedTrainers = new DataGridView();
            txtSearchTrainer = new Guna.UI2.WinForms.Guna2TextBox();
            btnSearchTrainer = new Guna.UI2.WinForms.Guna2Button();
            ID = new DataGridViewTextBoxColumn();
            Fullname = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Birthdate = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            AsignedMembers = new DataGridViewButtonColumn();
            TrainerClasses = new DataGridViewButtonColumn();
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
            guna2ShadowPanel1.Dock = DockStyle.Fill;
            guna2ShadowPanel1.FillColor = Color.FromArgb(224, 224, 224);
            guna2ShadowPanel1.Location = new Point(0, 0);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 5;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.ShadowDepth = 200;
            guna2ShadowPanel1.ShadowShift = 2;
            guna2ShadowPanel1.Size = new Size(1108, 600);
            guna2ShadowPanel1.TabIndex = 19;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle2.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvFixedTrainers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvFixedTrainers.ColumnHeadersHeight = 35;
            dgvFixedTrainers.Columns.AddRange(new DataGridViewColumn[] { ID, Fullname, Age, Gender, Birthdate, Email, Status, AsignedMembers, TrainerClasses });
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
            dgvFixedTrainers.CellClick += dgvFixedTrainers_CellClick;
            // 
            // txtSearchTrainer
            // 
            txtSearchTrainer.BorderRadius = 5;
            txtSearchTrainer.CustomizableEdges = customizableEdges5;
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
            txtSearchTrainer.PlaceholderText = "⌕ Search Trainer";
            txtSearchTrainer.SelectedText = "";
            txtSearchTrainer.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtSearchTrainer.Size = new Size(313, 41);
            txtSearchTrainer.TabIndex = 20;
            // 
            // btnSearchTrainer
            // 
            btnSearchTrainer.BackColor = Color.Transparent;
            btnSearchTrainer.BorderRadius = 5;
            btnSearchTrainer.CustomizableEdges = customizableEdges7;
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
            btnSearchTrainer.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSearchTrainer.Size = new Size(93, 41);
            btnSearchTrainer.TabIndex = 19;
            btnSearchTrainer.Text = "Search";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Fullname
            // 
            Fullname.HeaderText = "Fullname";
            Fullname.Name = "Fullname";
            Fullname.ReadOnly = true;
            // 
            // Age
            // 
            Age.HeaderText = "Age";
            Age.Name = "Age";
            Age.ReadOnly = true;
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            // 
            // Birthdate
            // 
            Birthdate.HeaderText = "Birthdate";
            Birthdate.Name = "Birthdate";
            Birthdate.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // AsignedMembers
            // 
            AsignedMembers.HeaderText = "Asigned Members";
            AsignedMembers.Name = "AsignedMembers";
            AsignedMembers.ReadOnly = true;
            AsignedMembers.Text = "View";
            AsignedMembers.UseColumnTextForButtonValue = true;
            // 
            // TrainerClasses
            // 
            TrainerClasses.HeaderText = "Trainer Classes";
            TrainerClasses.Name = "TrainerClasses";
            TrainerClasses.ReadOnly = true;
            TrainerClasses.Text = "View";
            TrainerClasses.UseColumnTextForButtonValue = true;
            // 
            // frmFixedTrainers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 600);
            Controls.Add(guna2ShadowPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFixedTrainers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFixedTrainers";
            Load += frmFixedTrainers_Load;
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
        private Guna.UI2.WinForms.Guna2TextBox txtSearchTrainer;
        private Guna.UI2.WinForms.Guna2Button btnSearchTrainer;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Fullname;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Birthdate;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn AsignedMembers;
        private DataGridViewButtonColumn TrainerClasses;
    }
}