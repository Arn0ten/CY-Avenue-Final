﻿namespace csCY_Avenue.Admin_Interface.Main
{
    partial class frmBillingAndTransaction
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlDisplay = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            btnGenerateInvoice = new Guna.UI2.WinForms.Guna2Button();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            cmbInvoiceGridViewFilter = new ComboBox();
            pnlDgvBack = new csLaundrySystem.CustomizableCornerPanel();
            dgvInvoice = new DataGridView();
            InvoiceID = new DataGridViewTextBoxColumn();
            MemberName = new DataGridViewTextBoxColumn();
            AmountDue = new DataGridViewTextBoxColumn();
            DueDate = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Pay = new DataGridViewButtonColumn();
            View = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            txtSearchInvoice = new Guna.UI2.WinForms.Guna2TextBox();
            btnSearchInvoice = new Guna.UI2.WinForms.Guna2Button();
            pnlDisplay.SuspendLayout();
            panel1.SuspendLayout();
            guna2ShadowPanel1.SuspendLayout();
            pnlDgvBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).BeginInit();
            SuspendLayout();
            // 
            // pnlDisplay
            // 
            pnlDisplay.Controls.Add(label1);
            pnlDisplay.Controls.Add(panel1);
            pnlDisplay.Dock = DockStyle.Fill;
            pnlDisplay.Location = new Point(0, 0);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(1173, 721);
            pnlDisplay.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(322, 32);
            label1.TabIndex = 3;
            label1.Text = "BILLING && TRANSACTIONS";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnGenerateInvoice);
            panel1.Controls.Add(guna2ShadowPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1173, 721);
            panel1.TabIndex = 4;
            // 
            // btnGenerateInvoice
            // 
            btnGenerateInvoice.BorderRadius = 5;
            btnGenerateInvoice.CustomizableEdges = customizableEdges1;
            btnGenerateInvoice.DisabledState.BorderColor = Color.DarkGray;
            btnGenerateInvoice.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGenerateInvoice.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGenerateInvoice.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGenerateInvoice.FillColor = Color.FromArgb(67, 154, 71);
            btnGenerateInvoice.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateInvoice.ForeColor = Color.White;
            btnGenerateInvoice.Image = Properties.Resources._8665402_file_invoice_icon;
            btnGenerateInvoice.ImageAlign = HorizontalAlignment.Left;
            btnGenerateInvoice.Location = new Point(471, 30);
            btnGenerateInvoice.Name = "btnGenerateInvoice";
            btnGenerateInvoice.ShadowDecoration.Color = Color.Silver;
            btnGenerateInvoice.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnGenerateInvoice.Size = new Size(230, 46);
            btnGenerateInvoice.TabIndex = 18;
            btnGenerateInvoice.Text = "Generate Invoice";
            btnGenerateInvoice.Click += btnGenerateInvoice_Click;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(cmbInvoiceGridViewFilter);
            guna2ShadowPanel1.Controls.Add(pnlDgvBack);
            guna2ShadowPanel1.Controls.Add(txtSearchInvoice);
            guna2ShadowPanel1.Controls.Add(btnSearchInvoice);
            guna2ShadowPanel1.FillColor = Color.FromArgb(224, 224, 224);
            guna2ShadowPanel1.Location = new Point(30, 93);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 5;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.ShadowDepth = 200;
            guna2ShadowPanel1.ShadowShift = 2;
            guna2ShadowPanel1.Size = new Size(1112, 606);
            guna2ShadowPanel1.TabIndex = 16;
            // 
            // cmbInvoiceGridViewFilter
            // 
            cmbInvoiceGridViewFilter.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbInvoiceGridViewFilter.FormattingEnabled = true;
            cmbInvoiceGridViewFilter.Location = new Point(7, 28);
            cmbInvoiceGridViewFilter.Name = "cmbInvoiceGridViewFilter";
            cmbInvoiceGridViewFilter.Size = new Size(132, 28);
            cmbInvoiceGridViewFilter.TabIndex = 17;
            cmbInvoiceGridViewFilter.Tag = "";
            cmbInvoiceGridViewFilter.Text = "Filter";
            // 
            // pnlDgvBack
            // 
            pnlDgvBack.BackColor = Color.FromArgb(41, 50, 113);
            pnlDgvBack.BorderColor = Color.Black;
            pnlDgvBack.BorderWidth = 1F;
            pnlDgvBack.Controls.Add(dgvInvoice);
            pnlDgvBack.CornerRadius = 20;
            pnlDgvBack.Location = new Point(6, 62);
            pnlDgvBack.Name = "pnlDgvBack";
            pnlDgvBack.Size = new Size(1101, 527);
            pnlDgvBack.TabIndex = 16;
            // 
            // dgvInvoice
            // 
            dgvInvoice.AllowUserToAddRows = false;
            dgvInvoice.AllowUserToDeleteRows = false;
            dgvInvoice.AllowUserToResizeRows = false;
            dgvInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoice.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvInvoice.BackgroundColor = Color.White;
            dgvInvoice.BorderStyle = BorderStyle.None;
            dgvInvoice.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvInvoice.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInvoice.ColumnHeadersHeight = 35;
            dgvInvoice.Columns.AddRange(new DataGridViewColumn[] { InvoiceID, MemberName, AmountDue, DueDate, Column1, Status, Pay, View, Delete });
            dgvInvoice.EnableHeadersVisualStyles = false;
            dgvInvoice.GridColor = SystemColors.ScrollBar;
            dgvInvoice.Location = new Point(0, 2);
            dgvInvoice.Name = "dgvInvoice";
            dgvInvoice.ReadOnly = true;
            dgvInvoice.RowHeadersVisible = false;
            dgvInvoice.RowHeadersWidth = 35;
            dgvInvoice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoice.Size = new Size(1101, 525);
            dgvInvoice.TabIndex = 6;
            dgvInvoice.CellClick += dgvInvoice_CellClick;
            dgvInvoice.CellContentClick += dgvInvoice_CellContentClick;
            // 
            // InvoiceID
            // 
            InvoiceID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            InvoiceID.HeaderText = "Invoice ID";
            InvoiceID.Name = "InvoiceID";
            InvoiceID.ReadOnly = true;
            // 
            // MemberName
            // 
            MemberName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MemberName.HeaderText = "Member Name";
            MemberName.Name = "MemberName";
            MemberName.ReadOnly = true;
            // 
            // AmountDue
            // 
            AmountDue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AmountDue.HeaderText = "Amount Due";
            AmountDue.Name = "AmountDue";
            AmountDue.ReadOnly = true;
            // 
            // DueDate
            // 
            DueDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DueDate.HeaderText = "Due Date";
            DueDate.Name = "DueDate";
            DueDate.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Membership Type";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Pay
            // 
            Pay.HeaderText = "Pay";
            Pay.Name = "Pay";
            Pay.ReadOnly = true;
            Pay.Text = "Pay";
            Pay.UseColumnTextForButtonValue = true;
            // 
            // View
            // 
            View.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            View.HeaderText = "View";
            View.Name = "View";
            View.ReadOnly = true;
            View.Text = "View";
            View.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // txtSearchInvoice
            // 
            txtSearchInvoice.BorderRadius = 5;
            txtSearchInvoice.CustomizableEdges = customizableEdges3;
            txtSearchInvoice.DefaultText = "";
            txtSearchInvoice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchInvoice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchInvoice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchInvoice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchInvoice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchInvoice.Font = new Font("Segoe UI", 9F);
            txtSearchInvoice.ForeColor = Color.Black;
            txtSearchInvoice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchInvoice.Location = new Point(688, 16);
            txtSearchInvoice.Name = "txtSearchInvoice";
            txtSearchInvoice.PasswordChar = '\0';
            txtSearchInvoice.PlaceholderForeColor = Color.FromArgb(112, 112, 112);
            txtSearchInvoice.PlaceholderText = "⌕ Search Invoice";
            txtSearchInvoice.SelectedText = "";
            txtSearchInvoice.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSearchInvoice.Size = new Size(313, 42);
            txtSearchInvoice.TabIndex = 15;
            // 
            // btnSearchInvoice
            // 
            btnSearchInvoice.BackColor = Color.Transparent;
            btnSearchInvoice.BorderRadius = 5;
            btnSearchInvoice.CustomizableEdges = customizableEdges5;
            btnSearchInvoice.DisabledState.BorderColor = Color.DarkGray;
            btnSearchInvoice.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearchInvoice.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearchInvoice.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearchInvoice.FillColor = Color.FromArgb(67, 154, 71);
            btnSearchInvoice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchInvoice.ForeColor = Color.White;
            btnSearchInvoice.HoverState.CustomBorderColor = Color.FromArgb(125, 183, 127);
            btnSearchInvoice.HoverState.ForeColor = Color.White;
            btnSearchInvoice.Location = new Point(1007, 16);
            btnSearchInvoice.Name = "btnSearchInvoice";
            btnSearchInvoice.PressedColor = Color.FromArgb(67, 154, 71);
            btnSearchInvoice.ShadowDecoration.BorderRadius = 9;
            btnSearchInvoice.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSearchInvoice.Size = new Size(101, 42);
            btnSearchInvoice.TabIndex = 14;
            btnSearchInvoice.Text = "Search";
            // 
            // frmBillingAndTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 721);
            Controls.Add(pnlDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBillingAndTransaction";
            Text = "frmBillingAndPayments";
            Load += frmBillingAndPayments_Load;
            pnlDisplay.ResumeLayout(false);
            pnlDisplay.PerformLayout();
            panel1.ResumeLayout(false);
            guna2ShadowPanel1.ResumeLayout(false);
            pnlDgvBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlDisplay;
        private Label label1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnGenerateInvoice;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private ComboBox cmbInvoiceGridViewFilter;
        private csLaundrySystem.CustomizableCornerPanel pnlDgvBack;
        private DataGridView dgvInvoice;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchInvoice;
        private Guna.UI2.WinForms.Guna2Button btnSearchInvoice;
        private DataGridViewTextBoxColumn InvoiceID;
        private DataGridViewTextBoxColumn MemberName;
        private DataGridViewTextBoxColumn AmountDue;
        private DataGridViewTextBoxColumn DueDate;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn Pay;
        private DataGridViewButtonColumn View;
        private DataGridViewButtonColumn Delete;
    }
}