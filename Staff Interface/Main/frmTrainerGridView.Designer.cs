namespace csCY_Avenue.Staff_Interface.Main
{
    partial class frmTrainerGridView
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
            pnlDgvDisplay = new Panel();
            pnlDgvBack = new csLaundrySystem.CustomizableCornerPanel();
            btnSearchTrainer = new Guna.UI2.WinForms.Guna2Button();
            txtSearchTrainer = new Guna.UI2.WinForms.Guna2TextBox();
            lblChange = new Label();
            dgvTrainers = new DataGridView();
            clmFullName = new DataGridViewTextBoxColumn();
            clmEmail = new DataGridViewTextBoxColumn();
            clmPhoneNumber = new DataGridViewTextBoxColumn();
            clmTrainerType = new DataGridViewTextBoxColumn();
            clmSalary = new DataGridViewTextBoxColumn();
            pnlDgvDisplay.SuspendLayout();
            pnlDgvBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrainers).BeginInit();
            SuspendLayout();
            // 
            // pnlDgvDisplay
            // 
            pnlDgvDisplay.Controls.Add(pnlDgvBack);
            pnlDgvDisplay.Controls.Add(btnSearchTrainer);
            pnlDgvDisplay.Controls.Add(txtSearchTrainer);
            pnlDgvDisplay.Controls.Add(lblChange);
            pnlDgvDisplay.Dock = DockStyle.Fill;
            pnlDgvDisplay.Location = new Point(0, 0);
            pnlDgvDisplay.Margin = new Padding(3, 4, 3, 4);
            pnlDgvDisplay.Name = "pnlDgvDisplay";
            pnlDgvDisplay.Size = new Size(897, 625);
            pnlDgvDisplay.TabIndex = 27;
            // 
            // pnlDgvBack
            // 
            pnlDgvBack.BackColor = Color.FromArgb(41, 50, 113);
            pnlDgvBack.BorderColor = Color.Black;
            pnlDgvBack.BorderWidth = 1F;
            pnlDgvBack.Controls.Add(dgvTrainers);
            pnlDgvBack.CornerRadius = 20;
            pnlDgvBack.Location = new Point(14, 56);
            pnlDgvBack.Margin = new Padding(3, 4, 3, 4);
            pnlDgvBack.Name = "pnlDgvBack";
            pnlDgvBack.Size = new Size(866, 565);
            pnlDgvBack.TabIndex = 26;
            // 
            // btnSearchTrainer
            // 
            btnSearchTrainer.BackColor = Color.FromArgb(67, 154, 71);
            btnSearchTrainer.CustomizableEdges = customizableEdges1;
            btnSearchTrainer.DisabledState.BorderColor = Color.DarkGray;
            btnSearchTrainer.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearchTrainer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearchTrainer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearchTrainer.FillColor = Color.FromArgb(67, 154, 71);
            btnSearchTrainer.Font = new Font("Segoe UI", 9F);
            btnSearchTrainer.ForeColor = Color.White;
            btnSearchTrainer.Location = new Point(803, 16);
            btnSearchTrainer.Margin = new Padding(3, 4, 3, 4);
            btnSearchTrainer.Name = "btnSearchTrainer";
            btnSearchTrainer.ShadowDecoration.BorderRadius = 9;
            btnSearchTrainer.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSearchTrainer.Size = new Size(77, 33);
            btnSearchTrainer.TabIndex = 23;
            btnSearchTrainer.Text = "Search";
            // 
            // txtSearchTrainer
            // 
            txtSearchTrainer.CustomizableEdges = customizableEdges3;
            txtSearchTrainer.DefaultText = "";
            txtSearchTrainer.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchTrainer.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchTrainer.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchTrainer.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchTrainer.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchTrainer.Font = new Font("Segoe UI", 9F);
            txtSearchTrainer.ForeColor = Color.Black;
            txtSearchTrainer.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchTrainer.Location = new Point(453, 16);
            txtSearchTrainer.Margin = new Padding(3, 5, 3, 5);
            txtSearchTrainer.Name = "txtSearchTrainer";
            txtSearchTrainer.PasswordChar = '\0';
            txtSearchTrainer.PlaceholderForeColor = Color.FromArgb(112, 112, 112);
            txtSearchTrainer.PlaceholderText = "⌕ Search Trainer";
            txtSearchTrainer.SelectedText = "";
            txtSearchTrainer.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSearchTrainer.Size = new Size(344, 33);
            txtSearchTrainer.TabIndex = 25;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.ForeColor = Color.Black;
            lblChange.Location = new Point(14, 16);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(82, 25);
            lblChange.TabIndex = 24;
            lblChange.Text = "Trainers";
            // 
            // dgvTrainers
            // 
            dgvTrainers.AllowUserToAddRows = false;
            dgvTrainers.AllowUserToDeleteRows = false;
            dgvTrainers.AllowUserToResizeRows = false;
            dgvTrainers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrainers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTrainers.BackgroundColor = Color.White;
            dgvTrainers.BorderStyle = BorderStyle.None;
            dgvTrainers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvTrainers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTrainers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTrainers.ColumnHeadersHeight = 35;
            dgvTrainers.Columns.AddRange(new DataGridViewColumn[] { clmFullName, clmEmail, clmPhoneNumber, clmTrainerType, clmSalary });
            dgvTrainers.EnableHeadersVisualStyles = false;
            dgvTrainers.GridColor = SystemColors.ScrollBar;
            dgvTrainers.Location = new Point(0, -3);
            dgvTrainers.Margin = new Padding(3, 4, 3, 4);
            dgvTrainers.Name = "dgvTrainers";
            dgvTrainers.ReadOnly = true;
            dgvTrainers.RowHeadersVisible = false;
            dgvTrainers.RowHeadersWidth = 35;
            dgvTrainers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrainers.Size = new Size(867, 571);
            dgvTrainers.TabIndex = 7;
            // 
            // clmFullName
            // 
            clmFullName.HeaderText = "Fullname";
            clmFullName.MinimumWidth = 6;
            clmFullName.Name = "clmFullName";
            clmFullName.ReadOnly = true;
            // 
            // clmEmail
            // 
            clmEmail.HeaderText = "Email";
            clmEmail.MinimumWidth = 6;
            clmEmail.Name = "clmEmail";
            clmEmail.ReadOnly = true;
            // 
            // clmPhoneNumber
            // 
            clmPhoneNumber.HeaderText = "Phone-Number";
            clmPhoneNumber.MinimumWidth = 6;
            clmPhoneNumber.Name = "clmPhoneNumber";
            clmPhoneNumber.ReadOnly = true;
            // 
            // clmTrainerType
            // 
            clmTrainerType.HeaderText = "Trainer-Type";
            clmTrainerType.MinimumWidth = 6;
            clmTrainerType.Name = "clmTrainerType";
            clmTrainerType.ReadOnly = true;
            // 
            // clmSalary
            // 
            clmSalary.HeaderText = "Salary";
            clmSalary.MinimumWidth = 6;
            clmSalary.Name = "clmSalary";
            clmSalary.ReadOnly = true;
            // 
            // frmTrainerGridView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 625);
            Controls.Add(pnlDgvDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTrainerGridView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTrainerGridView";
            pnlDgvDisplay.ResumeLayout(false);
            pnlDgvDisplay.PerformLayout();
            pnlDgvBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTrainers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDgvDisplay;
        private csLaundrySystem.CustomizableCornerPanel pnlDgvBack;
        private Guna.UI2.WinForms.Guna2Button btnSearchTrainer;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchTrainer;
        private Label lblChange;
        private DataGridView dgvTrainers;
        private DataGridViewTextBoxColumn clmFullName;
        private DataGridViewTextBoxColumn clmEmail;
        private DataGridViewTextBoxColumn clmPhoneNumber;
        private DataGridViewTextBoxColumn clmTrainerType;
        private DataGridViewTextBoxColumn clmSalary;
    }
}