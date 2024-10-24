namespace csCY_Avenue.Admin_Interface.Main
{
    partial class frmRevenue
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
            pnlDisplay = new Panel();
            dtFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnFilterGymRevenue = new Guna.UI2.WinForms.Guna2Button();
            lblTotalRevenue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnPrintRevenue = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pnlDgvBack = new csLaundrySystem.CustomizableCornerPanel();
            dgvRevenue = new DataGridView();
            clmTransactionDate = new DataGridViewTextBoxColumn();
            clmMemberName = new DataGridViewTextBoxColumn();
            clmType = new DataGridViewTextBoxColumn();
            clmAmount = new DataGridViewTextBoxColumn();
            label1 = new Label();
            pnlDisplay.SuspendLayout();
            pnlDgvBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRevenue).BeginInit();
            SuspendLayout();
            // 
            // pnlDisplay
            // 
            pnlDisplay.Controls.Add(dtFrom);
            pnlDisplay.Controls.Add(dtTo);
            pnlDisplay.Controls.Add(guna2HtmlLabel6);
            pnlDisplay.Controls.Add(btnFilterGymRevenue);
            pnlDisplay.Controls.Add(lblTotalRevenue);
            pnlDisplay.Controls.Add(guna2HtmlLabel10);
            pnlDisplay.Controls.Add(btnPrintRevenue);
            pnlDisplay.Controls.Add(guna2HtmlLabel3);
            pnlDisplay.Controls.Add(guna2HtmlLabel1);
            pnlDisplay.Controls.Add(pnlDgvBack);
            pnlDisplay.Controls.Add(label1);
            pnlDisplay.Dock = DockStyle.Fill;
            pnlDisplay.Location = new Point(0, 0);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(1173, 721);
            pnlDisplay.TabIndex = 2;
            // 
            // dtFrom
            // 
            dtFrom.BorderColor = Color.Silver;
            dtFrom.BorderRadius = 5;
            dtFrom.BorderThickness = 1;
            dtFrom.Checked = true;
            dtFrom.CustomizableEdges = customizableEdges1;
            dtFrom.FillColor = Color.FromArgb(63, 139, 66);
            dtFrom.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            dtFrom.ForeColor = Color.White;
            dtFrom.Format = DateTimePickerFormat.Custom;
            dtFrom.Location = new Point(562, 74);
            dtFrom.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtFrom.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtFrom.Name = "dtFrom";
            dtFrom.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dtFrom.Size = new Size(143, 36);
            dtFrom.TabIndex = 122;
            dtFrom.Value = new DateTime(2024, 10, 4, 8, 28, 58, 690);
            // 
            // dtTo
            // 
            dtTo.BorderColor = Color.Silver;
            dtTo.BorderRadius = 5;
            dtTo.BorderThickness = 1;
            dtTo.Checked = true;
            dtTo.CustomizableEdges = customizableEdges3;
            dtTo.FillColor = Color.FromArgb(225, 63, 51);
            dtTo.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            dtTo.ForeColor = Color.White;
            dtTo.Format = DateTimePickerFormat.Custom;
            dtTo.Location = new Point(751, 74);
            dtTo.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtTo.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtTo.Name = "dtTo";
            dtTo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtTo.Size = new Size(143, 36);
            dtTo.TabIndex = 121;
            dtTo.Value = new DateTime(2024, 10, 4, 8, 28, 58, 690);
            // 
            // guna2HtmlLabel6
            // 
            guna2HtmlLabel6.BackColor = Color.Transparent;
            guna2HtmlLabel6.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            guna2HtmlLabel6.ForeColor = Color.Black;
            guna2HtmlLabel6.Location = new Point(897, 80);
            guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            guna2HtmlLabel6.Size = new Size(119, 23);
            guna2HtmlLabel6.TabIndex = 124;
            guna2HtmlLabel6.Text = "> > > > > > > >";
            // 
            // btnFilterGymRevenue
            // 
            btnFilterGymRevenue.BackColor = Color.Transparent;
            btnFilterGymRevenue.BorderColor = Color.Silver;
            btnFilterGymRevenue.BorderRadius = 5;
            btnFilterGymRevenue.CustomizableEdges = customizableEdges5;
            btnFilterGymRevenue.DisabledState.BorderColor = Color.DarkGray;
            btnFilterGymRevenue.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFilterGymRevenue.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFilterGymRevenue.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFilterGymRevenue.FillColor = Color.FromArgb(67, 154, 71);
            btnFilterGymRevenue.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilterGymRevenue.ForeColor = Color.White;
            btnFilterGymRevenue.Image = Properties.Resources._4737438_equalizer_filter_filtering_mixer_sorting_icon1;
            btnFilterGymRevenue.Location = new Point(1016, 74);
            btnFilterGymRevenue.Name = "btnFilterGymRevenue";
            btnFilterGymRevenue.ShadowDecoration.Color = Color.Silver;
            btnFilterGymRevenue.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnFilterGymRevenue.Size = new Size(99, 36);
            btnFilterGymRevenue.TabIndex = 115;
            btnFilterGymRevenue.Text = "FILTER";
            btnFilterGymRevenue.Click += btnFilterGymRevenue_Click;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.BackColor = Color.Transparent;
            lblTotalRevenue.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRevenue.ForeColor = Color.FromArgb(0, 192, 0);
            lblTotalRevenue.Location = new Point(976, 637);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(74, 34);
            lblTotalRevenue.TabIndex = 114;
            lblTotalRevenue.Text = "₱ 0.00";
            // 
            // guna2HtmlLabel10
            // 
            guna2HtmlLabel10.BackColor = Color.Transparent;
            guna2HtmlLabel10.Font = new Font("Nirmala UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel10.Location = new Point(788, 637);
            guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            guna2HtmlLabel10.Size = new Size(168, 34);
            guna2HtmlLabel10.TabIndex = 113;
            guna2HtmlLabel10.Text = "Total Revenue  :";
            // 
            // btnPrintRevenue
            // 
            btnPrintRevenue.BorderRadius = 5;
            btnPrintRevenue.CustomizableEdges = customizableEdges7;
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
            btnPrintRevenue.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnPrintRevenue.Size = new Size(152, 51);
            btnPrintRevenue.TabIndex = 74;
            btnPrintRevenue.Text = "Print";
            btnPrintRevenue.Click += btnPrintRevenue_Click;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            guna2HtmlLabel3.ForeColor = Color.Black;
            guna2HtmlLabel3.Location = new Point(715, 80);
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
            guna2HtmlLabel1.Location = new Point(506, 80);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(50, 23);
            guna2HtmlLabel1.TabIndex = 70;
            guna2HtmlLabel1.Text = "From  :";
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
            dgvRevenue.Columns.AddRange(new DataGridViewColumn[] { clmTransactionDate, clmMemberName, clmType, clmAmount });
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
            dgvRevenue.CellContentClick += dgvRevenue_CellContentClick;
            // 
            // clmTransactionDate
            // 
            clmTransactionDate.HeaderText = "Transaction Date";
            clmTransactionDate.MinimumWidth = 6;
            clmTransactionDate.Name = "clmTransactionDate";
            clmTransactionDate.ReadOnly = true;
            // 
            // clmMemberName
            // 
            clmMemberName.HeaderText = "Member Name";
            clmMemberName.MinimumWidth = 6;
            clmMemberName.Name = "clmMemberName";
            clmMemberName.ReadOnly = true;
            // 
            // clmType
            // 
            clmType.HeaderText = "Type";
            clmType.MinimumWidth = 6;
            clmType.Name = "clmType";
            clmType.ReadOnly = true;
            // 
            // clmAmount
            // 
            clmAmount.HeaderText = "Amount";
            clmAmount.MinimumWidth = 6;
            clmAmount.Name = "clmAmount";
            clmAmount.ReadOnly = true;
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
            // frmRevenue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 721);
            Controls.Add(pnlDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRevenue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRevenue";
            pnlDisplay.ResumeLayout(false);
            pnlDisplay.PerformLayout();
            pnlDgvBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRevenue).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlDisplay;
        private Label label1;
        private csLaundrySystem.CustomizableCornerPanel pnlDgvBack;
        private DataGridView dgvRevenue;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnPrintRevenue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalRevenue;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2Button btnFilterGymRevenue;
        private DataGridViewTextBoxColumn clmTransactionDate;
        private DataGridViewTextBoxColumn clmMemberName;
        private DataGridViewTextBoxColumn clmType;
        private DataGridViewTextBoxColumn clmAmount;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTo;
    }
}