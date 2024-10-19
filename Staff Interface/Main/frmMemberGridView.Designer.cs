namespace csCY_Avenue.Staff_Interface.Main
{
    partial class frmMemberGridView
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlDgvBack = new csLaundrySystem.CustomizableCornerPanel();
            dgvMembers = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Renew = new DataGridViewButtonColumn();
            txtSearchMember = new Guna.UI2.WinForms.Guna2TextBox();
            lblChange = new Label();
            btnSearchMember = new Guna.UI2.WinForms.Guna2Button();
            pnlDgvDisplay = new Panel();
            pnlDgvBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();
            // 
            // pnlDgvBack
            // 
            pnlDgvBack.BackColor = Color.FromArgb(41, 50, 113);
            pnlDgvBack.BorderColor = Color.Black;
            pnlDgvBack.BorderWidth = 1F;
            pnlDgvBack.Controls.Add(dgvMembers);
            pnlDgvBack.CornerRadius = 20;
            pnlDgvBack.Location = new Point(15, 39);
            pnlDgvBack.Name = "pnlDgvBack";
            pnlDgvBack.Size = new Size(758, 424);
            pnlDgvBack.TabIndex = 18;
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AllowUserToResizeRows = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMembers.BackgroundColor = Color.White;
            dgvMembers.BorderStyle = BorderStyle.None;
            dgvMembers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvMembers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle3.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvMembers.ColumnHeadersHeight = 35;
            dgvMembers.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4, Column5, Column6, Column7, Column8, Renew });
            dgvMembers.EnableHeadersVisualStyles = false;
            dgvMembers.GridColor = SystemColors.ScrollBar;
            dgvMembers.Location = new Point(0, 2);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersVisible = false;
            dgvMembers.RowHeadersWidth = 35;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(759, 428);
            dgvMembers.TabIndex = 6;
            dgvMembers.CellClick += dgvMembers_CellClick;
            // 
            // Column2
            // 
            Column2.HeaderText = "Fullname";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Age";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Sex";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Birthdate";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Email";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Membership Type";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Status";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Renew
            // 
            Renew.HeaderText = "Renew";
            Renew.Name = "Renew";
            Renew.ReadOnly = true;
            Renew.Text = "Renew";
            Renew.UseColumnTextForButtonValue = true;
            // 
            // txtSearchMember
            // 
            txtSearchMember.CustomizableEdges = customizableEdges9;
            txtSearchMember.DefaultText = "";
            txtSearchMember.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchMember.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchMember.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchMember.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchMember.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchMember.Font = new Font("Segoe UI", 9F);
            txtSearchMember.ForeColor = Color.Black;
            txtSearchMember.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchMember.Location = new Point(399, 9);
            txtSearchMember.Name = "txtSearchMember";
            txtSearchMember.PasswordChar = '\0';
            txtSearchMember.PlaceholderForeColor = Color.FromArgb(112, 112, 112);
            txtSearchMember.PlaceholderText = "⌕ Search Member";
            txtSearchMember.SelectedText = "";
            txtSearchMember.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtSearchMember.Size = new Size(301, 25);
            txtSearchMember.TabIndex = 17;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.ForeColor = Color.Black;
            lblChange.Location = new Point(15, 9);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(79, 20);
            lblChange.TabIndex = 16;
            lblChange.Text = "Members ";
            // 
            // btnSearchMember
            // 
            btnSearchMember.BackColor = Color.FromArgb(67, 154, 71);
            btnSearchMember.CustomizableEdges = customizableEdges11;
            btnSearchMember.DisabledState.BorderColor = Color.DarkGray;
            btnSearchMember.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearchMember.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearchMember.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearchMember.FillColor = Color.FromArgb(67, 154, 71);
            btnSearchMember.Font = new Font("Segoe UI", 9F);
            btnSearchMember.ForeColor = Color.White;
            btnSearchMember.Location = new Point(706, 9);
            btnSearchMember.Name = "btnSearchMember";
            btnSearchMember.ShadowDecoration.BorderRadius = 9;
            btnSearchMember.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnSearchMember.Size = new Size(67, 25);
            btnSearchMember.TabIndex = 15;
            btnSearchMember.Text = "Search";
            // 
            // pnlDgvDisplay
            // 
            pnlDgvDisplay.Dock = DockStyle.Fill;
            pnlDgvDisplay.Location = new Point(0, 0);
            pnlDgvDisplay.Name = "pnlDgvDisplay";
            pnlDgvDisplay.Size = new Size(785, 469);
            pnlDgvDisplay.TabIndex = 19;
            // 
            // frmMemberGridView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 469);
            Controls.Add(pnlDgvBack);
            Controls.Add(txtSearchMember);
            Controls.Add(lblChange);
            Controls.Add(btnSearchMember);
            Controls.Add(pnlDgvDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMemberGridView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMemberGridView";
            Load += frmMemberGridView_Load;
            pnlDgvBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private csLaundrySystem.CustomizableCornerPanel pnlDgvBack;
        private DataGridView dgvMembers;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewButtonColumn Renew;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchMember;
        private Label lblChange;
        private Guna.UI2.WinForms.Guna2Button btnSearchMember;
        private Panel pnlDgvDisplay;
    }
}