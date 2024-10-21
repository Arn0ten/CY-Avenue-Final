namespace csCY_Avenue.Admin_Interface.Main
{
    partial class frmMembersGridView
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
            btnSearchMember = new Guna.UI2.WinForms.Guna2Button();
            txtSearchMember = new Guna.UI2.WinForms.Guna2TextBox();
            lblChange = new Label();
            pnlDgvBack = new csLaundrySystem.CustomizableCornerPanel();
            dgvMembers = new DataGridView();
            pnlDgvDisplay = new Panel();
            clmName = new DataGridViewTextBoxColumn();
            clmEmail = new DataGridViewTextBoxColumn();
            clmPhonenumber = new DataGridViewTextBoxColumn();
            clmMembership = new DataGridViewTextBoxColumn();
            clmStatus = new DataGridViewTextBoxColumn();
            clmRenew = new DataGridViewButtonColumn();
            pnlDgvBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();
            // 
            // btnSearchMember
            // 
            btnSearchMember.BackColor = Color.FromArgb(67, 154, 71);
            btnSearchMember.CustomizableEdges = customizableEdges1;
            btnSearchMember.DisabledState.BorderColor = Color.DarkGray;
            btnSearchMember.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearchMember.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearchMember.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearchMember.FillColor = Color.FromArgb(67, 154, 71);
            btnSearchMember.Font = new Font("Segoe UI", 9F);
            btnSearchMember.ForeColor = Color.White;
            btnSearchMember.Location = new Point(807, 12);
            btnSearchMember.Margin = new Padding(3, 4, 3, 4);
            btnSearchMember.Name = "btnSearchMember";
            btnSearchMember.ShadowDecoration.BorderRadius = 9;
            btnSearchMember.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSearchMember.Size = new Size(77, 33);
            btnSearchMember.TabIndex = 10;
            btnSearchMember.Text = "Search";
            // 
            // txtSearchMember
            // 
            txtSearchMember.CustomizableEdges = customizableEdges3;
            txtSearchMember.DefaultText = "";
            txtSearchMember.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchMember.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchMember.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchMember.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchMember.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchMember.Font = new Font("Segoe UI", 9F);
            txtSearchMember.ForeColor = Color.Black;
            txtSearchMember.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchMember.Location = new Point(456, 12);
            txtSearchMember.Margin = new Padding(3, 5, 3, 5);
            txtSearchMember.Name = "txtSearchMember";
            txtSearchMember.PasswordChar = '\0';
            txtSearchMember.PlaceholderForeColor = Color.FromArgb(112, 112, 112);
            txtSearchMember.PlaceholderText = "⌕ Search Member";
            txtSearchMember.SelectedText = "";
            txtSearchMember.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSearchMember.Size = new Size(344, 33);
            txtSearchMember.TabIndex = 12;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.ForeColor = Color.Black;
            lblChange.Location = new Point(17, 12);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(100, 25);
            lblChange.TabIndex = 11;
            lblChange.Text = "Members ";
            // 
            // pnlDgvBack
            // 
            pnlDgvBack.BackColor = Color.FromArgb(41, 50, 113);
            pnlDgvBack.BorderColor = Color.Black;
            pnlDgvBack.BorderWidth = 1F;
            pnlDgvBack.Controls.Add(dgvMembers);
            pnlDgvBack.CornerRadius = 20;
            pnlDgvBack.Location = new Point(17, 52);
            pnlDgvBack.Margin = new Padding(3, 4, 3, 4);
            pnlDgvBack.Name = "pnlDgvBack";
            pnlDgvBack.Size = new Size(866, 565);
            pnlDgvBack.TabIndex = 13;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMembers.ColumnHeadersHeight = 35;
            dgvMembers.Columns.AddRange(new DataGridViewColumn[] { clmName, clmEmail, clmPhonenumber, clmMembership, clmStatus, clmRenew });
            dgvMembers.EnableHeadersVisualStyles = false;
            dgvMembers.GridColor = SystemColors.ScrollBar;
            dgvMembers.Location = new Point(0, 3);
            dgvMembers.Margin = new Padding(3, 4, 3, 4);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersVisible = false;
            dgvMembers.RowHeadersWidth = 35;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(867, 571);
            dgvMembers.TabIndex = 6;
            dgvMembers.CellClick += dgvMembers_CellClick;
            // 
            // pnlDgvDisplay
            // 
            pnlDgvDisplay.Dock = DockStyle.Fill;
            pnlDgvDisplay.Location = new Point(0, 0);
            pnlDgvDisplay.Margin = new Padding(3, 4, 3, 4);
            pnlDgvDisplay.Name = "pnlDgvDisplay";
            pnlDgvDisplay.Size = new Size(897, 625);
            pnlDgvDisplay.TabIndex = 14;
            // 
            // clmName
            // 
            clmName.HeaderText = "Fullname";
            clmName.MinimumWidth = 6;
            clmName.Name = "clmName";
            clmName.ReadOnly = true;
            // 
            // clmEmail
            // 
            clmEmail.HeaderText = "Email";
            clmEmail.MinimumWidth = 6;
            clmEmail.Name = "clmEmail";
            clmEmail.ReadOnly = true;
            // 
            // clmPhonenumber
            // 
            clmPhonenumber.HeaderText = "Phonenumber";
            clmPhonenumber.MinimumWidth = 6;
            clmPhonenumber.Name = "clmPhonenumber";
            clmPhonenumber.ReadOnly = true;
            // 
            // clmMembership
            // 
            clmMembership.HeaderText = "Membership ";
            clmMembership.MinimumWidth = 6;
            clmMembership.Name = "clmMembership";
            clmMembership.ReadOnly = true;
            // 
            // clmStatus
            // 
            clmStatus.HeaderText = "Status";
            clmStatus.MinimumWidth = 6;
            clmStatus.Name = "clmStatus";
            clmStatus.ReadOnly = true;
            // 
            // clmRenew
            // 
            clmRenew.HeaderText = "Renew";
            clmRenew.MinimumWidth = 6;
            clmRenew.Name = "clmRenew";
            clmRenew.ReadOnly = true;
            clmRenew.Text = "Renew";
            clmRenew.UseColumnTextForButtonValue = true;
            // 
            // frmMembersGridView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 625);
            Controls.Add(pnlDgvBack);
            Controls.Add(txtSearchMember);
            Controls.Add(lblChange);
            Controls.Add(btnSearchMember);
            Controls.Add(pnlDgvDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMembersGridView";
            Text = "frmMembersGridView";
            Load += frmMembersGridView_Load;
            pnlDgvBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnSearchMember;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchMember;
        private Label lblChange;
        private csLaundrySystem.CustomizableCornerPanel pnlDgvBack;
        private DataGridView dgvMembers;
        private Panel pnlDgvDisplay;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmEmail;
        private DataGridViewTextBoxColumn clmPhonenumber;
        private DataGridViewTextBoxColumn clmMembership;
        private DataGridViewTextBoxColumn clmStatus;
        private DataGridViewButtonColumn clmRenew;
    }
}