namespace csCY_Avenue.Staff_Interface.Main.StaffShopInterface
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlDisplay = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            pnlDgvBack = new csLaundrySystem.CustomizableCornerPanel();
            dgvInvoice = new DataGridView();
            txtSearchInvoice = new Guna.UI2.WinForms.Guna2TextBox();
            btnSearchInvoice = new Guna.UI2.WinForms.Guna2Button();
            clmInvoiceId = new DataGridViewTextBoxColumn();
            clmPrice = new DataGridViewTextBoxColumn();
            clmDiscount = new DataGridViewTextBoxColumn();
            clmDateOfTransaction = new DataGridViewTextBoxColumn();
            clmStatus = new DataGridViewTextBoxColumn();
            clmView = new DataGridViewButtonColumn();
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
            pnlDisplay.Margin = new Padding(3, 4, 3, 4);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(1341, 961);
            pnlDisplay.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(339, 41);
            label1.TabIndex = 3;
            label1.Text = "SHOP TRANSACTIONS";
            // 
            // panel1
            // 
            panel1.Controls.Add(guna2ShadowPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1341, 961);
            panel1.TabIndex = 4;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(pnlDgvBack);
            guna2ShadowPanel1.Controls.Add(txtSearchInvoice);
            guna2ShadowPanel1.Controls.Add(btnSearchInvoice);
            guna2ShadowPanel1.FillColor = Color.FromArgb(224, 224, 224);
            guna2ShadowPanel1.Location = new Point(34, 124);
            guna2ShadowPanel1.Margin = new Padding(3, 4, 3, 4);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 5;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.ShadowDepth = 200;
            guna2ShadowPanel1.ShadowShift = 2;
            guna2ShadowPanel1.Size = new Size(1271, 808);
            guna2ShadowPanel1.TabIndex = 16;
            // 
            // pnlDgvBack
            // 
            pnlDgvBack.BackColor = Color.FromArgb(41, 50, 113);
            pnlDgvBack.BorderColor = Color.Black;
            pnlDgvBack.BorderWidth = 1F;
            pnlDgvBack.Controls.Add(dgvInvoice);
            pnlDgvBack.CornerRadius = 20;
            pnlDgvBack.Location = new Point(7, 83);
            pnlDgvBack.Margin = new Padding(3, 4, 3, 4);
            pnlDgvBack.Name = "pnlDgvBack";
            pnlDgvBack.Size = new Size(1258, 703);
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
            dgvInvoice.Columns.AddRange(new DataGridViewColumn[] { clmInvoiceId, clmPrice, clmDiscount, clmDateOfTransaction, clmStatus, clmView });
            dgvInvoice.EnableHeadersVisualStyles = false;
            dgvInvoice.GridColor = SystemColors.ScrollBar;
            dgvInvoice.Location = new Point(0, 3);
            dgvInvoice.Margin = new Padding(3, 4, 3, 4);
            dgvInvoice.Name = "dgvInvoice";
            dgvInvoice.ReadOnly = true;
            dgvInvoice.RowHeadersVisible = false;
            dgvInvoice.RowHeadersWidth = 35;
            dgvInvoice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoice.Size = new Size(1258, 700);
            dgvInvoice.TabIndex = 6;
            dgvInvoice.CellClick += dgvInvoice_CellClick;
            dgvInvoice.CellContentClick += dgvInvoice_CellContentClick;
            // 
            // txtSearchInvoice
            // 
            txtSearchInvoice.BorderRadius = 5;
            txtSearchInvoice.CustomizableEdges = customizableEdges1;
            txtSearchInvoice.DefaultText = "";
            txtSearchInvoice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchInvoice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchInvoice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchInvoice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchInvoice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchInvoice.Font = new Font("Segoe UI", 9F);
            txtSearchInvoice.ForeColor = Color.Black;
            txtSearchInvoice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchInvoice.Location = new Point(786, 21);
            txtSearchInvoice.Margin = new Padding(3, 5, 3, 5);
            txtSearchInvoice.Name = "txtSearchInvoice";
            txtSearchInvoice.PasswordChar = '\0';
            txtSearchInvoice.PlaceholderForeColor = Color.FromArgb(112, 112, 112);
            txtSearchInvoice.PlaceholderText = "⌕ Search Invoice";
            txtSearchInvoice.SelectedText = "";
            txtSearchInvoice.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearchInvoice.Size = new Size(358, 56);
            txtSearchInvoice.TabIndex = 15;
            // 
            // btnSearchInvoice
            // 
            btnSearchInvoice.BackColor = Color.Transparent;
            btnSearchInvoice.BorderRadius = 5;
            btnSearchInvoice.CustomizableEdges = customizableEdges3;
            btnSearchInvoice.DisabledState.BorderColor = Color.DarkGray;
            btnSearchInvoice.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearchInvoice.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearchInvoice.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearchInvoice.FillColor = Color.FromArgb(67, 154, 71);
            btnSearchInvoice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchInvoice.ForeColor = Color.White;
            btnSearchInvoice.HoverState.CustomBorderColor = Color.FromArgb(125, 183, 127);
            btnSearchInvoice.HoverState.ForeColor = Color.White;
            btnSearchInvoice.Location = new Point(1151, 21);
            btnSearchInvoice.Margin = new Padding(3, 4, 3, 4);
            btnSearchInvoice.Name = "btnSearchInvoice";
            btnSearchInvoice.PressedColor = Color.FromArgb(67, 154, 71);
            btnSearchInvoice.ShadowDecoration.BorderRadius = 9;
            btnSearchInvoice.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSearchInvoice.Size = new Size(115, 56);
            btnSearchInvoice.TabIndex = 14;
            btnSearchInvoice.Text = "Search";
            // 
            // clmInvoiceId
            // 
            clmInvoiceId.HeaderText = "Invoice ID";
            clmInvoiceId.MinimumWidth = 6;
            clmInvoiceId.Name = "clmInvoiceId";
            clmInvoiceId.ReadOnly = true;
            // 
            // clmPrice
            // 
            clmPrice.HeaderText = "Price";
            clmPrice.MinimumWidth = 6;
            clmPrice.Name = "clmPrice";
            clmPrice.ReadOnly = true;
            // 
            // clmDiscount
            // 
            clmDiscount.HeaderText = "Discount";
            clmDiscount.MinimumWidth = 6;
            clmDiscount.Name = "clmDiscount";
            clmDiscount.ReadOnly = true;
            // 
            // clmDateOfTransaction
            // 
            clmDateOfTransaction.HeaderText = "Date Of Transaction";
            clmDateOfTransaction.MinimumWidth = 6;
            clmDateOfTransaction.Name = "clmDateOfTransaction";
            clmDateOfTransaction.ReadOnly = true;
            // 
            // clmStatus
            // 
            clmStatus.HeaderText = "Status";
            clmStatus.MinimumWidth = 6;
            clmStatus.Name = "clmStatus";
            clmStatus.ReadOnly = true;
            // 
            // clmView
            // 
            clmView.HeaderText = "View";
            clmView.MinimumWidth = 6;
            clmView.Name = "clmView";
            clmView.ReadOnly = true;
            clmView.Text = "View";
            clmView.UseColumnTextForButtonValue = true;
            // 
            // frmShopTransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 961);
            Controls.Add(pnlDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmShopTransactions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmShopTransactions";
            Load += frmShopTransactions_Load;
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
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private csLaundrySystem.CustomizableCornerPanel pnlDgvBack;
        private DataGridView dgvInvoice;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchInvoice;
        private Guna.UI2.WinForms.Guna2Button btnSearchInvoice;
        private DataGridViewTextBoxColumn clmInvoiceId;
        private DataGridViewTextBoxColumn clmPrice;
        private DataGridViewTextBoxColumn clmDiscount;
        private DataGridViewTextBoxColumn clmDateOfTransaction;
        private DataGridViewTextBoxColumn clmStatus;
        private DataGridViewButtonColumn clmView;
    }
}