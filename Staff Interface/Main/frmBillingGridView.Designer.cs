namespace csCY_Avenue.Staff_Interface.Main
{
    partial class frmBillingGridView
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
            pnlDgvDisplay = new Panel();
            pnlDgvBack = new csLaundrySystem.CustomizableCornerPanel();
            dgvBilling = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnSearchBilling = new Guna.UI2.WinForms.Guna2Button();
            txtSearchBilling = new Guna.UI2.WinForms.Guna2TextBox();
            lblChange = new Label();
            pnlDgvDisplay.SuspendLayout();
            pnlDgvBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBilling).BeginInit();
            SuspendLayout();
            // 
            // pnlDgvDisplay
            // 
            pnlDgvDisplay.Controls.Add(pnlDgvBack);
            pnlDgvDisplay.Controls.Add(btnSearchBilling);
            pnlDgvDisplay.Controls.Add(txtSearchBilling);
            pnlDgvDisplay.Controls.Add(lblChange);
            pnlDgvDisplay.Dock = DockStyle.Fill;
            pnlDgvDisplay.Location = new Point(0, 0);
            pnlDgvDisplay.Name = "pnlDgvDisplay";
            pnlDgvDisplay.Size = new Size(785, 469);
            pnlDgvDisplay.TabIndex = 33;
            // 
            // pnlDgvBack
            // 
            pnlDgvBack.BackColor = Color.FromArgb(41, 50, 113);
            pnlDgvBack.BorderColor = Color.Black;
            pnlDgvBack.BorderWidth = 1F;
            pnlDgvBack.Controls.Add(dgvBilling);
            pnlDgvBack.CornerRadius = 20;
            pnlDgvBack.Location = new Point(14, 39);
            pnlDgvBack.Name = "pnlDgvBack";
            pnlDgvBack.Size = new Size(758, 424);
            pnlDgvBack.TabIndex = 31;
            // 
            // dgvBilling
            // 
            dgvBilling.AllowUserToAddRows = false;
            dgvBilling.AllowUserToDeleteRows = false;
            dgvBilling.AllowUserToResizeRows = false;
            dgvBilling.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBilling.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBilling.BackgroundColor = Color.White;
            dgvBilling.BorderStyle = BorderStyle.None;
            dgvBilling.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBilling.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBilling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBilling.ColumnHeadersHeight = 35;
            dgvBilling.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column8, Column1, Column4 });
            dgvBilling.EnableHeadersVisualStyles = false;
            dgvBilling.GridColor = SystemColors.ScrollBar;
            dgvBilling.Location = new Point(0, 2);
            dgvBilling.Name = "dgvBilling";
            dgvBilling.ReadOnly = true;
            dgvBilling.RowHeadersVisible = false;
            dgvBilling.RowHeadersWidth = 35;
            dgvBilling.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBilling.Size = new Size(759, 428);
            dgvBilling.TabIndex = 6;
            // 
            // Column2
            // 
            Column2.HeaderText = "ID";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Member Name";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Amount Due";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Due Date";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Status";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // btnSearchBilling
            // 
            btnSearchBilling.BackColor = Color.FromArgb(67, 154, 71);
            btnSearchBilling.CustomizableEdges = customizableEdges1;
            btnSearchBilling.DisabledState.BorderColor = Color.DarkGray;
            btnSearchBilling.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearchBilling.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearchBilling.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearchBilling.FillColor = Color.FromArgb(67, 154, 71);
            btnSearchBilling.Font = new Font("Segoe UI", 9F);
            btnSearchBilling.ForeColor = Color.White;
            btnSearchBilling.Location = new Point(705, 9);
            btnSearchBilling.Name = "btnSearchBilling";
            btnSearchBilling.ShadowDecoration.BorderRadius = 9;
            btnSearchBilling.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSearchBilling.Size = new Size(67, 25);
            btnSearchBilling.TabIndex = 28;
            btnSearchBilling.Text = "Search";
            // 
            // txtSearchBilling
            // 
            txtSearchBilling.CustomizableEdges = customizableEdges3;
            txtSearchBilling.DefaultText = "";
            txtSearchBilling.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchBilling.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchBilling.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchBilling.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchBilling.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchBilling.Font = new Font("Segoe UI", 9F);
            txtSearchBilling.ForeColor = Color.Black;
            txtSearchBilling.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchBilling.Location = new Point(398, 9);
            txtSearchBilling.Name = "txtSearchBilling";
            txtSearchBilling.PasswordChar = '\0';
            txtSearchBilling.PlaceholderForeColor = Color.FromArgb(112, 112, 112);
            txtSearchBilling.PlaceholderText = "⌕ Search Billing";
            txtSearchBilling.SelectedText = "";
            txtSearchBilling.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSearchBilling.Size = new Size(301, 25);
            txtSearchBilling.TabIndex = 30;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.ForeColor = Color.Black;
            lblChange.Location = new Point(14, 9);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(136, 20);
            lblChange.TabIndex = 29;
            lblChange.Text = "Billing && Payment";
            // 
            // frmBillingGridView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 469);
            Controls.Add(pnlDgvDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBillingGridView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBillingGridView";
            pnlDgvDisplay.ResumeLayout(false);
            pnlDgvDisplay.PerformLayout();
            pnlDgvBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBilling).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDgvDisplay;
        private csLaundrySystem.CustomizableCornerPanel pnlDgvBack;
        private DataGridView dgvBilling;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2Button btnSearchBilling;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchBilling;
        private Label lblChange;
    }
}