namespace csCY_Avenue.Admin_Interface.Main.AdminShopInterface
{
    partial class frmShopTransactions
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnSearchInvoice = new Guna.UI2.WinForms.Guna2Button();
            txtSearchInvoice = new Guna.UI2.WinForms.Guna2TextBox();
            dgvInvoice = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewButtonColumn();
            cmbInvoiceGridViewFilter = new ComboBox();
            pnlDgvBack = new csLaundrySystem.CustomizableCornerPanel();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            label1 = new Label();
            pnlDisplay = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).BeginInit();
            pnlDgvBack.SuspendLayout();
            guna2ShadowPanel1.SuspendLayout();
            pnlDisplay.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearchInvoice
            // 
            btnSearchInvoice.BackColor = Color.Transparent;
            btnSearchInvoice.BorderRadius = 5;
            btnSearchInvoice.CustomizableEdges = customizableEdges1;
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
            btnSearchInvoice.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSearchInvoice.Size = new Size(101, 42);
            btnSearchInvoice.TabIndex = 14;
            btnSearchInvoice.Text = "Search";
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
            dgvInvoice.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
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
            dgvInvoice.CellClick += dgvTransaction_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Invoice ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Customer Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Item";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Category";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Price";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Date Of Transaction";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Status";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "View";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Text = "View";
            Column8.UseColumnTextForButtonValue = true;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(268, 32);
            label1.TabIndex = 3;
            label1.Text = "SHOP TRANSACTIONS";
            // 
            // pnlDisplay
            // 
            pnlDisplay.Controls.Add(label1);
            pnlDisplay.Controls.Add(panel1);
            pnlDisplay.Dock = DockStyle.Fill;
            pnlDisplay.Location = new Point(0, 0);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(1173, 721);
            pnlDisplay.TabIndex = 3;
            pnlDisplay.Paint += pnlDisplay_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(guna2ShadowPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1173, 721);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // frmShopTransactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 721);
            Controls.Add(pnlDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmShopTransactions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmShopTransactions";
            Load += frmShopTransactions_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).EndInit();
            pnlDgvBack.ResumeLayout(false);
            guna2ShadowPanel1.ResumeLayout(false);
            pnlDisplay.ResumeLayout(false);
            pnlDisplay.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSearchInvoice;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchInvoice;
        private DataGridView dgvInvoice;
        private ComboBox cmbInvoiceGridViewFilter;
        private csLaundrySystem.CustomizableCornerPanel pnlDgvBack;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Label label1;
        private Panel pnlDisplay;
        private Panel panel1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewButtonColumn Column8;
    }
}