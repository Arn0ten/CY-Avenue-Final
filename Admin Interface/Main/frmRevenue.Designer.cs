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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlDisplay = new Panel();
            btnFilterGymRevenue = new Guna.UI2.WinForms.Guna2Button();
            lblTotalRevenue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnPrintRevenue = new Guna.UI2.WinForms.Guna2Button();
            dtTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cmbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
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
            pnlDisplay.Controls.Add(btnFilterGymRevenue);
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
            pnlDisplay.Margin = new Padding(3, 4, 3, 4);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(1341, 961);
            pnlDisplay.TabIndex = 2;
            // 
            // btnFilterGymRevenue
            // 
            btnFilterGymRevenue.BackColor = SystemColors.ActiveCaptionText;
            btnFilterGymRevenue.BorderRadius = 5;
            btnFilterGymRevenue.CustomizableEdges = customizableEdges1;
            btnFilterGymRevenue.DisabledState.BorderColor = Color.DarkGray;
            btnFilterGymRevenue.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFilterGymRevenue.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFilterGymRevenue.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFilterGymRevenue.FillColor = Color.FromArgb(255, 192, 128);
            btnFilterGymRevenue.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilterGymRevenue.ForeColor = Color.Black;
            btnFilterGymRevenue.ImageAlign = HorizontalAlignment.Left;
            btnFilterGymRevenue.Location = new Point(1129, 29);
            btnFilterGymRevenue.Margin = new Padding(3, 4, 3, 4);
            btnFilterGymRevenue.Name = "btnFilterGymRevenue";
            btnFilterGymRevenue.ShadowDecoration.Color = Color.Silver;
            btnFilterGymRevenue.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnFilterGymRevenue.Size = new Size(113, 48);
            btnFilterGymRevenue.TabIndex = 115;
            btnFilterGymRevenue.Text = "FILTER";
            btnFilterGymRevenue.Click += btnFilterGymRevenue_Click;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.BackColor = Color.Transparent;
            lblTotalRevenue.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRevenue.Location = new Point(1190, 849);
            lblTotalRevenue.Margin = new Padding(3, 4, 3, 4);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(89, 43);
            lblTotalRevenue.TabIndex = 114;
            lblTotalRevenue.Text = "₱ 0.00";
            // 
            // guna2HtmlLabel10
            // 
            guna2HtmlLabel10.BackColor = Color.Transparent;
            guna2HtmlLabel10.Font = new Font("Nirmala UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel10.Location = new Point(975, 849);
            guna2HtmlLabel10.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            guna2HtmlLabel10.Size = new Size(206, 43);
            guna2HtmlLabel10.TabIndex = 113;
            guna2HtmlLabel10.Text = "Total Revenue  :";
            // 
            // btnPrintRevenue
            // 
            btnPrintRevenue.BorderRadius = 5;
            btnPrintRevenue.CustomizableEdges = customizableEdges3;
            btnPrintRevenue.DisabledState.BorderColor = Color.DarkGray;
            btnPrintRevenue.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPrintRevenue.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPrintRevenue.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPrintRevenue.FillColor = Color.FromArgb(200, 202, 217);
            btnPrintRevenue.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintRevenue.ForeColor = Color.White;
            btnPrintRevenue.Image = Properties.Resources._2931177_output_print_printer_icon;
            btnPrintRevenue.ImageAlign = HorizontalAlignment.Left;
            btnPrintRevenue.Location = new Point(583, 877);
            btnPrintRevenue.Margin = new Padding(3, 4, 3, 4);
            btnPrintRevenue.Name = "btnPrintRevenue";
            btnPrintRevenue.ShadowDecoration.Color = Color.Silver;
            btnPrintRevenue.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnPrintRevenue.Size = new Size(174, 68);
            btnPrintRevenue.TabIndex = 74;
            btnPrintRevenue.Text = "Print";
            btnPrintRevenue.Click += btnPrintRevenue_Click;
            // 
            // dtTo
            // 
            dtTo.BorderColor = Color.Silver;
            dtTo.BorderRadius = 5;
            dtTo.BorderThickness = 1;
            dtTo.Checked = true;
            dtTo.CustomFormat = "";
            dtTo.CustomizableEdges = customizableEdges5;
            dtTo.FillColor = Color.FromArgb(225, 63, 51);
            dtTo.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            dtTo.Format = DateTimePickerFormat.Custom;
            dtTo.Location = new Point(832, 89);
            dtTo.Margin = new Padding(3, 4, 3, 4);
            dtTo.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtTo.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtTo.Name = "dtTo";
            dtTo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dtTo.ShowUpDown = true;
            dtTo.Size = new Size(267, 48);
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
            dtFrom.CustomizableEdges = customizableEdges7;
            dtFrom.FillColor = Color.FromArgb(63, 139, 66);
            dtFrom.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            dtFrom.Format = DateTimePickerFormat.Custom;
            dtFrom.Location = new Point(832, 29);
            dtFrom.Margin = new Padding(3, 4, 3, 4);
            dtFrom.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtFrom.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtFrom.Name = "dtFrom";
            dtFrom.ShadowDecoration.CustomizableEdges = customizableEdges8;
            dtFrom.ShowUpDown = true;
            dtFrom.Size = new Size(267, 48);
            dtFrom.TabIndex = 72;
            dtFrom.Value = new DateTime(2024, 10, 4, 8, 28, 58, 690);
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            guna2HtmlLabel3.ForeColor = Color.Black;
            guna2HtmlLabel3.Location = new Point(754, 99);
            guna2HtmlLabel3.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(38, 30);
            guna2HtmlLabel3.TabIndex = 71;
            guna2HtmlLabel3.Text = "To  :";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            guna2HtmlLabel1.ForeColor = Color.Black;
            guna2HtmlLabel1.Location = new Point(754, 29);
            guna2HtmlLabel1.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(62, 30);
            guna2HtmlLabel1.TabIndex = 70;
            guna2HtmlLabel1.Text = "From  :";
            // 
            // cmbFilter
            // 
            cmbFilter.AutoCompleteCustomSource.AddRange(new string[] { "Weekly", "Monthly", "Yearly", "Custom" });
            cmbFilter.BackColor = Color.Transparent;
            cmbFilter.BorderColor = Color.Silver;
            cmbFilter.BorderRadius = 5;
            cmbFilter.CustomizableEdges = customizableEdges9;
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
            cmbFilter.Location = new Point(428, 29);
            cmbFilter.Margin = new Padding(3, 4, 3, 4);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cmbFilter.Size = new Size(267, 36);
            cmbFilter.Sorted = true;
            cmbFilter.TabIndex = 66;
            cmbFilter.Tag = "Membership Type";
            cmbFilter.TextAlign = HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            guna2HtmlLabel2.ForeColor = Color.Black;
            guna2HtmlLabel2.Location = new Point(320, 29);
            guna2HtmlLabel2.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(93, 30);
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
            pnlDgvBack.Location = new Point(65, 159);
            pnlDgvBack.Margin = new Padding(3, 4, 3, 4);
            pnlDgvBack.Name = "pnlDgvBack";
            pnlDgvBack.Size = new Size(1209, 683);
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
            dgvRevenue.Location = new Point(0, 4);
            dgvRevenue.Margin = new Padding(3, 4, 3, 4);
            dgvRevenue.Name = "dgvRevenue";
            dgvRevenue.ReadOnly = true;
            dgvRevenue.RowHeadersVisible = false;
            dgvRevenue.RowHeadersWidth = 35;
            dgvRevenue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRevenue.Size = new Size(1209, 679);
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
            label1.Size = new Size(228, 41);
            label1.TabIndex = 2;
            label1.Text = "GYM REVENUE";
            // 
            // frmRevenue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 961);
            Controls.Add(pnlDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRevenue";
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
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtFrom;
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
    }
}