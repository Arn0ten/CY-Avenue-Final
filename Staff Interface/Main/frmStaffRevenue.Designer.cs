namespace csCY_Avenue.Staff_Interface.Main
{
    partial class frmStaffRevenue
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblTotalRevenue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnPrintRevenue = new Guna.UI2.WinForms.Guna2Button();
            dtTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cmbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            Column3 = new DataGridViewTextBoxColumn();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pnlDgvBack = new csLaundrySystem.CustomizableCornerPanel();
            dgvRevenue = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            pnlDisplay = new Panel();
            pnlDgvBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRevenue).BeginInit();
            pnlDisplay.SuspendLayout();
            SuspendLayout();
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.BackColor = Color.Transparent;
            lblTotalRevenue.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRevenue.Location = new Point(1041, 637);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(74, 34);
            lblTotalRevenue.TabIndex = 114;
            lblTotalRevenue.Text = "₱ 0.00";
            // 
            // guna2HtmlLabel10
            // 
            guna2HtmlLabel10.BackColor = Color.Transparent;
            guna2HtmlLabel10.Font = new Font("Nirmala UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel10.Location = new Point(853, 637);
            guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            guna2HtmlLabel10.Size = new Size(168, 34);
            guna2HtmlLabel10.TabIndex = 113;
            guna2HtmlLabel10.Text = "Total Revenue  :";
            // 
            // btnPrintRevenue
            // 
            btnPrintRevenue.BorderRadius = 5;
            btnPrintRevenue.CustomizableEdges = customizableEdges1;
            btnPrintRevenue.DisabledState.BorderColor = Color.DarkGray;
            btnPrintRevenue.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPrintRevenue.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPrintRevenue.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPrintRevenue.FillColor = Color.FromArgb(200, 202, 217);
            btnPrintRevenue.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintRevenue.ForeColor = Color.White;
            btnPrintRevenue.Image = Properties.Resources._2931177_output_print_printer_icon;
            btnPrintRevenue.ImageAlign = HorizontalAlignment.Left;
            btnPrintRevenue.Location = new Point(510, 658);
            btnPrintRevenue.Name = "btnPrintRevenue";
            btnPrintRevenue.ShadowDecoration.Color = Color.Silver;
            btnPrintRevenue.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnPrintRevenue.Size = new Size(152, 51);
            btnPrintRevenue.TabIndex = 74;
            btnPrintRevenue.Text = "Print";
            // 
            // dtTo
            // 
            dtTo.BorderColor = Color.Silver;
            dtTo.BorderRadius = 5;
            dtTo.BorderThickness = 1;
            dtTo.Checked = true;
            dtTo.CustomFormat = "";
            dtTo.CustomizableEdges = customizableEdges3;
            dtTo.FillColor = Color.FromArgb(225, 63, 51);
            dtTo.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            dtTo.Format = DateTimePickerFormat.Custom;
            dtTo.Location = new Point(881, 67);
            dtTo.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtTo.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtTo.Name = "dtTo";
            dtTo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtTo.ShowUpDown = true;
            dtTo.Size = new Size(234, 36);
            dtTo.TabIndex = 73;
            dtTo.Value = new DateTime(2024, 10, 4, 8, 28, 58, 690);
            // 
            // dtFrom
            // 
            dtFrom.BorderColor = Color.Silver;
            dtFrom.BorderRadius = 5;
            dtFrom.BorderThickness = 1;
            dtFrom.Checked = true;
            dtFrom.CustomFormat = "";
            dtFrom.CustomizableEdges = customizableEdges5;
            dtFrom.FillColor = Color.FromArgb(63, 139, 66);
            dtFrom.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            dtFrom.Format = DateTimePickerFormat.Custom;
            dtFrom.Location = new Point(881, 22);
            dtFrom.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtFrom.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtFrom.Name = "dtFrom";
            dtFrom.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dtFrom.ShowUpDown = true;
            dtFrom.Size = new Size(234, 36);
            dtFrom.TabIndex = 72;
            dtFrom.Value = new DateTime(2024, 10, 4, 8, 28, 58, 690);
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            guna2HtmlLabel3.ForeColor = Color.Black;
            guna2HtmlLabel3.Location = new Point(776, 74);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(30, 23);
            guna2HtmlLabel3.TabIndex = 71;
            guna2HtmlLabel3.Text = "To  :";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            guna2HtmlLabel1.ForeColor = Color.Black;
            guna2HtmlLabel1.Location = new Point(776, 28);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(50, 23);
            guna2HtmlLabel1.TabIndex = 70;
            guna2HtmlLabel1.Text = "From  :";
            // 
            // cmbFilter
            // 
            cmbFilter.AutoCompleteCustomSource.AddRange(new string[] { "Weekly", "Monthly", "Yearly", "Custom" });
            cmbFilter.BackColor = Color.Transparent;
            cmbFilter.BorderColor = Color.Silver;
            cmbFilter.BorderRadius = 5;
            cmbFilter.CustomizableEdges = customizableEdges7;
            cmbFilter.DrawMode = DrawMode.OwnerDrawFixed;
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.FillColor = Color.FromArgb(219, 219, 219);
            cmbFilter.FocusedColor = Color.FromArgb(41, 50, 113);
            cmbFilter.FocusedState.BorderColor = Color.FromArgb(41, 50, 113);
            cmbFilter.FocusedState.FillColor = Color.FromArgb(41, 50, 113);
            cmbFilter.FocusedState.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbFilter.FocusedState.ForeColor = Color.White;
            cmbFilter.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbFilter.ForeColor = Color.FromArgb(41, 50, 113);
            cmbFilter.HoverState.FillColor = Color.FromArgb(41, 50, 113);
            cmbFilter.HoverState.Font = new Font("Microsoft Sans Serif", 8.25F);
            cmbFilter.HoverState.ForeColor = Color.White;
            cmbFilter.ItemHeight = 30;
            cmbFilter.Items.AddRange(new object[] { "Custom", "Monthly", "Weekly", "Yearly" });
            cmbFilter.Location = new Point(515, 22);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cmbFilter.Size = new Size(234, 36);
            cmbFilter.Sorted = true;
            cmbFilter.TabIndex = 66;
            cmbFilter.Tag = "Membership Type";
            cmbFilter.TextAlign = HorizontalAlignment.Center;
            // 
            // Column3
            // 
            Column3.HeaderText = "Type";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            guna2HtmlLabel2.ForeColor = Color.Black;
            guna2HtmlLabel2.Location = new Point(410, 28);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(73, 23);
            guna2HtmlLabel2.TabIndex = 65;
            guna2HtmlLabel2.Text = "Filter By :";
            // 
            // pnlDgvBack
            // 
            pnlDgvBack.BackColor = Color.FromArgb(41, 50, 113);
            pnlDgvBack.BorderColor = Color.Black;
            pnlDgvBack.BorderWidth = 1F;
            pnlDgvBack.Controls.Add(dgvRevenue);
            pnlDgvBack.CornerRadius = 20;
            pnlDgvBack.Location = new Point(57, 119);
            pnlDgvBack.Name = "pnlDgvBack";
            pnlDgvBack.Size = new Size(1058, 512);
            pnlDgvBack.TabIndex = 32;
            // 
            // dgvRevenue
            // 
            dgvRevenue.AllowUserToAddRows = false;
            dgvRevenue.AllowUserToDeleteRows = false;
            dgvRevenue.AllowUserToResizeRows = false;
            dgvRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRevenue.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRevenue.BackgroundColor = Color.White;
            dgvRevenue.BorderStyle = BorderStyle.None;
            dgvRevenue.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvRevenue.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRevenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRevenue.ColumnHeadersHeight = 35;
            dgvRevenue.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvRevenue.EnableHeadersVisualStyles = false;
            dgvRevenue.GridColor = SystemColors.ScrollBar;
            dgvRevenue.Location = new Point(0, 3);
            dgvRevenue.Name = "dgvRevenue";
            dgvRevenue.ReadOnly = true;
            dgvRevenue.RowHeadersVisible = false;
            dgvRevenue.RowHeadersWidth = 35;
            dgvRevenue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRevenue.Size = new Size(1058, 509);
            dgvRevenue.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "Transaction Date";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Member Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Amount";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 32);
            label1.TabIndex = 2;
            label1.Text = "GYM REVENUE";
            // 
            // pnlDisplay
            // 
            pnlDisplay.Controls.Add(lblTotalRevenue);
            pnlDisplay.Controls.Add(guna2HtmlLabel10);
            pnlDisplay.Controls.Add(btnPrintRevenue);
            pnlDisplay.Controls.Add(dtTo);
            pnlDisplay.Controls.Add(dtFrom);
            pnlDisplay.Controls.Add(guna2HtmlLabel3);
            pnlDisplay.Controls.Add(guna2HtmlLabel1);
            pnlDisplay.Controls.Add(cmbFilter);
            pnlDisplay.Controls.Add(guna2HtmlLabel2);
            pnlDisplay.Controls.Add(pnlDgvBack);
            pnlDisplay.Controls.Add(label1);
            pnlDisplay.Dock = DockStyle.Fill;
            pnlDisplay.Location = new Point(0, 0);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(1173, 721);
            pnlDisplay.TabIndex = 3;
            // 
            // frmStaffRevenue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 721);
            Controls.Add(pnlDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmStaffRevenue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmStaffRevenuecs";
            pnlDgvBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRevenue).EndInit();
            pnlDisplay.ResumeLayout(false);
            pnlDisplay.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalRevenue;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2Button btnPrintRevenue;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtFrom;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilter;
        private DataGridViewTextBoxColumn Column3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private csLaundrySystem.CustomizableCornerPanel pnlDgvBack;
        private DataGridView dgvRevenue;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private Label label1;
        private Panel pnlDisplay;
    }
}