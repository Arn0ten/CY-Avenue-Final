namespace csCY_Avenue.Admin_Interface.Main
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvTrainers = new DataGridView();
            clmFullName = new DataGridViewTextBoxColumn();
            clmEmail = new DataGridViewTextBoxColumn();
            clmPhoneNumber = new DataGridViewTextBoxColumn();
            clmTrainerType = new DataGridViewTextBoxColumn();
            clmSalary = new DataGridViewTextBoxColumn();
            pnlDgvBack = new csLaundrySystem.CustomizableCornerPanel();
            txtSearchTrainer = new Guna.UI2.WinForms.Guna2TextBox();
            lblChange = new Label();
            btnSearchTrainer = new Guna.UI2.WinForms.Guna2Button();
            pnlDgvDisplay = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvTrainers).BeginInit();
            pnlDgvBack.SuspendLayout();
            SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
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
            dgvTrainers.Location = new Point(0, 2);
            dgvTrainers.Name = "dgvTrainers";
            dgvTrainers.ReadOnly = true;
            dgvTrainers.RowHeadersVisible = false;
            dgvTrainers.RowHeadersWidth = 35;
            dgvTrainers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrainers.Size = new Size(759, 428);
            dgvTrainers.TabIndex = 6;
            // 
            // clmFullName
            // 
            dataGridViewCellStyle2.Font = new Font("Nirmala UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            clmFullName.DefaultCellStyle = dataGridViewCellStyle2;
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
            clmTrainerType.HeaderText = "Type";
            clmTrainerType.MinimumWidth = 6;
            clmTrainerType.Name = "clmTrainerType";
            clmTrainerType.ReadOnly = true;
            // 
            // clmSalary
            // 
            dataGridViewCellStyle3.Font = new Font("Nirmala UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle3.Format = "₱  #,##0.00";
            clmSalary.DefaultCellStyle = dataGridViewCellStyle3;
            clmSalary.HeaderText = "Salary";
            clmSalary.MinimumWidth = 6;
            clmSalary.Name = "clmSalary";
            clmSalary.ReadOnly = true;
            // 
            // pnlDgvBack
            // 
            pnlDgvBack.BackColor = Color.FromArgb(41, 50, 113);
            pnlDgvBack.BorderColor = Color.Black;
            pnlDgvBack.BorderWidth = 1F;
            pnlDgvBack.Controls.Add(dgvTrainers);
            pnlDgvBack.CornerRadius = 20;
            pnlDgvBack.Location = new Point(14, 39);
            pnlDgvBack.Name = "pnlDgvBack";
            pnlDgvBack.Size = new Size(758, 424);
            pnlDgvBack.TabIndex = 21;
            // 
            // txtSearchTrainer
            // 
            txtSearchTrainer.CustomizableEdges = customizableEdges1;
            txtSearchTrainer.DefaultText = "";
            txtSearchTrainer.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchTrainer.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchTrainer.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchTrainer.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchTrainer.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchTrainer.Font = new Font("Segoe UI", 9F);
            txtSearchTrainer.ForeColor = Color.Black;
            txtSearchTrainer.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchTrainer.Location = new Point(398, 9);
            txtSearchTrainer.Margin = new Padding(3, 4, 3, 4);
            txtSearchTrainer.Name = "txtSearchTrainer";
            txtSearchTrainer.PasswordChar = '\0';
            txtSearchTrainer.PlaceholderForeColor = Color.FromArgb(112, 112, 112);
            txtSearchTrainer.PlaceholderText = "⌕ Search Trainer";
            txtSearchTrainer.SelectedText = "";
            txtSearchTrainer.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearchTrainer.Size = new Size(301, 25);
            txtSearchTrainer.TabIndex = 20;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.ForeColor = Color.Black;
            lblChange.Location = new Point(14, 9);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(65, 20);
            lblChange.TabIndex = 19;
            lblChange.Text = "Trainers";
            // 
            // btnSearchTrainer
            // 
            btnSearchTrainer.BackColor = Color.FromArgb(67, 154, 71);
            btnSearchTrainer.CustomizableEdges = customizableEdges3;
            btnSearchTrainer.DisabledState.BorderColor = Color.DarkGray;
            btnSearchTrainer.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearchTrainer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearchTrainer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearchTrainer.FillColor = Color.FromArgb(67, 154, 71);
            btnSearchTrainer.Font = new Font("Segoe UI", 9F);
            btnSearchTrainer.ForeColor = Color.White;
            btnSearchTrainer.Location = new Point(705, 9);
            btnSearchTrainer.Name = "btnSearchTrainer";
            btnSearchTrainer.ShadowDecoration.BorderRadius = 9;
            btnSearchTrainer.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSearchTrainer.Size = new Size(67, 25);
            btnSearchTrainer.TabIndex = 18;
            btnSearchTrainer.Text = "Search";
            btnSearchTrainer.Click += btnSearchTrainer_Click;
            // 
            // pnlDgvDisplay
            // 
            pnlDgvDisplay.Dock = DockStyle.Fill;
            pnlDgvDisplay.Location = new Point(0, 0);
            pnlDgvDisplay.Name = "pnlDgvDisplay";
            pnlDgvDisplay.Size = new Size(785, 469);
            pnlDgvDisplay.TabIndex = 22;
            // 
            // frmTrainerGridView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 469);
            Controls.Add(pnlDgvBack);
            Controls.Add(txtSearchTrainer);
            Controls.Add(lblChange);
            Controls.Add(btnSearchTrainer);
            Controls.Add(pnlDgvDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTrainerGridView";
            Text = "frmTrainerGridView";
            ((System.ComponentModel.ISupportInitialize)dgvTrainers).EndInit();
            pnlDgvBack.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTrainers;
        private csLaundrySystem.CustomizableCornerPanel pnlDgvBack;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchTrainer;
        private Label lblChange;
        private Guna.UI2.WinForms.Guna2Button btnSearchTrainer;
        private Panel pnlDgvDisplay;
        private DataGridViewTextBoxColumn clmFullName;
        private DataGridViewTextBoxColumn clmEmail;
        private DataGridViewTextBoxColumn clmPhoneNumber;
        private DataGridViewTextBoxColumn clmTrainerType;
        private DataGridViewTextBoxColumn clmSalary;
    }
}