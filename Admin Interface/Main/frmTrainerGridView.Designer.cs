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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvTrainers = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTrainers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTrainers.ColumnHeadersHeight = 35;
            dgvTrainers.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
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
            // Column1
            // 
            Column1.HeaderText = "Photo";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private csLaundrySystem.CustomizableCornerPanel pnlDgvBack;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchTrainer;
        private Label lblChange;
        private Guna.UI2.WinForms.Guna2Button btnSearchTrainer;
        private Panel pnlDgvDisplay;
    }
}