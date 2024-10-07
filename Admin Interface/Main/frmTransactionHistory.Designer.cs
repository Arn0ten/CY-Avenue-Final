namespace csCY_Avenue.Admin_Interface.Main
{
    partial class frmTransactionHistory
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            button1 = new Button();
            guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            label1 = new Label();
            FormDesign = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            pnlDgvBack = new csLaundrySystem.CustomizableCornerPanel();
            dgvTransactionHistory = new DataGridView();
            TransactionID = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            guna2ShadowPanel2.SuspendLayout();
            pnlDgvBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactionHistory).BeginInit();
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
            guna2ShadowPanel2.TabIndex = 94;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(224, 13);
            label1.Name = "label1";
            label1.Size = new Size(188, 21);
            label1.TabIndex = 2;
            label1.Text = "TRANSACTIONHISTORY";
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
            pnlDgvBack.Controls.Add(dgvTransactionHistory);
            pnlDgvBack.CornerRadius = 20;
            pnlDgvBack.Location = new Point(12, 56);
            pnlDgvBack.Name = "pnlDgvBack";
            pnlDgvBack.Size = new Size(612, 338);
            pnlDgvBack.TabIndex = 95;
            // 
            // dgvTransactionHistory
            // 
            dgvTransactionHistory.AllowUserToAddRows = false;
            dgvTransactionHistory.AllowUserToDeleteRows = false;
            dgvTransactionHistory.AllowUserToResizeRows = false;
            dgvTransactionHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactionHistory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTransactionHistory.BackgroundColor = Color.White;
            dgvTransactionHistory.BorderStyle = BorderStyle.None;
            dgvTransactionHistory.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvTransactionHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle4.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvTransactionHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvTransactionHistory.ColumnHeadersHeight = 35;
            dgvTransactionHistory.Columns.AddRange(new DataGridViewColumn[] { TransactionID, Date, Amount, Status });
            dgvTransactionHistory.EnableHeadersVisualStyles = false;
            dgvTransactionHistory.GridColor = SystemColors.ScrollBar;
            dgvTransactionHistory.Location = new Point(0, 3);
            dgvTransactionHistory.Name = "dgvTransactionHistory";
            dgvTransactionHistory.ReadOnly = true;
            dgvTransactionHistory.RowHeadersVisible = false;
            dgvTransactionHistory.RowHeadersWidth = 35;
            dgvTransactionHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactionHistory.Size = new Size(612, 335);
            dgvTransactionHistory.TabIndex = 6;
            // 
            // TransactionID
            // 
            TransactionID.HeaderText = "Transaction ID";
            TransactionID.Name = "TransactionID";
            TransactionID.ReadOnly = true;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // frmTransactionHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 407);
            Controls.Add(guna2ShadowPanel2);
            Controls.Add(pnlDgvBack);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTransactionHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTransactionHistory";
            guna2ShadowPanel2.ResumeLayout(false);
            guna2ShadowPanel2.PerformLayout();
            pnlDgvBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransactionHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm FormDesign;
        private csLaundrySystem.CustomizableCornerPanel pnlDgvBack;
        private DataGridView dgvTransactionHistory;
        private DataGridViewTextBoxColumn TransactionID;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Status;
    }
}