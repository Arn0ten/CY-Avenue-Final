namespace csCY_Avenue.Staff_Interface.Main
{
    partial class frmClassGridView
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlDgvBack = new csLaundrySystem.CustomizableCornerPanel();
            dgvClass = new DataGridView();
            txtSearchClass = new Guna.UI2.WinForms.Guna2TextBox();
            lblChange = new Label();
            btnSearchClass = new Guna.UI2.WinForms.Guna2Button();
            pnlDgvDisplay = new Panel();
            clmId = new DataGridViewTextBoxColumn();
            clmClassName = new DataGridViewTextBoxColumn();
            clmClassType = new DataGridViewTextBoxColumn();
            clmTrainer = new DataGridViewTextBoxColumn();
            clmSchedule = new DataGridViewTextBoxColumn();
            pnlDgvBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClass).BeginInit();
            SuspendLayout();
            // 
            // pnlDgvBack
            // 
            pnlDgvBack.BackColor = Color.FromArgb(41, 50, 113);
            pnlDgvBack.BorderColor = Color.Black;
            pnlDgvBack.BorderWidth = 1F;
            pnlDgvBack.Controls.Add(dgvClass);
            pnlDgvBack.CornerRadius = 20;
            pnlDgvBack.Location = new Point(15, 39);
            pnlDgvBack.Name = "pnlDgvBack";
            pnlDgvBack.Size = new Size(758, 424);
            pnlDgvBack.TabIndex = 23;
            // 
            // dgvClass
            // 
            dgvClass.AllowUserToAddRows = false;
            dgvClass.AllowUserToDeleteRows = false;
            dgvClass.AllowUserToResizeRows = false;
            dgvClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClass.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClass.BackgroundColor = Color.White;
            dgvClass.BorderStyle = BorderStyle.None;
            dgvClass.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvClass.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClass.ColumnHeadersHeight = 35;
            dgvClass.Columns.AddRange(new DataGridViewColumn[] { clmId, clmClassName, clmClassType, clmTrainer, clmSchedule });
            dgvClass.EnableHeadersVisualStyles = false;
            dgvClass.GridColor = SystemColors.ScrollBar;
            dgvClass.Location = new Point(0, 2);
            dgvClass.Name = "dgvClass";
            dgvClass.ReadOnly = true;
            dgvClass.RowHeadersVisible = false;
            dgvClass.RowHeadersWidth = 35;
            dgvClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClass.Size = new Size(759, 428);
            dgvClass.TabIndex = 6;
            dgvClass.CellContentClick += dgvClass_CellContentClick;
            // 
            // txtSearchClass
            // 
            txtSearchClass.CustomizableEdges = customizableEdges1;
            txtSearchClass.DefaultText = "";
            txtSearchClass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchClass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchClass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchClass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchClass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchClass.Font = new Font("Segoe UI", 9F);
            txtSearchClass.ForeColor = Color.Black;
            txtSearchClass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchClass.Location = new Point(399, 9);
            txtSearchClass.Margin = new Padding(3, 4, 3, 4);
            txtSearchClass.Name = "txtSearchClass";
            txtSearchClass.PasswordChar = '\0';
            txtSearchClass.PlaceholderForeColor = Color.FromArgb(112, 112, 112);
            txtSearchClass.PlaceholderText = "⌕ Search Class";
            txtSearchClass.SelectedText = "";
            txtSearchClass.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearchClass.Size = new Size(301, 25);
            txtSearchClass.TabIndex = 22;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.ForeColor = Color.Black;
            lblChange.Location = new Point(15, 9);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(55, 20);
            lblChange.TabIndex = 21;
            lblChange.Text = "Classs ";
            // 
            // btnSearchClass
            // 
            btnSearchClass.BackColor = Color.FromArgb(67, 154, 71);
            btnSearchClass.CustomizableEdges = customizableEdges3;
            btnSearchClass.DisabledState.BorderColor = Color.DarkGray;
            btnSearchClass.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearchClass.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearchClass.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearchClass.FillColor = Color.FromArgb(67, 154, 71);
            btnSearchClass.Font = new Font("Segoe UI", 9F);
            btnSearchClass.ForeColor = Color.White;
            btnSearchClass.Location = new Point(706, 9);
            btnSearchClass.Name = "btnSearchClass";
            btnSearchClass.ShadowDecoration.BorderRadius = 9;
            btnSearchClass.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSearchClass.Size = new Size(67, 25);
            btnSearchClass.TabIndex = 20;
            btnSearchClass.Text = "Search";
            // 
            // pnlDgvDisplay
            // 
            pnlDgvDisplay.Dock = DockStyle.Fill;
            pnlDgvDisplay.Location = new Point(0, 0);
            pnlDgvDisplay.Name = "pnlDgvDisplay";
            pnlDgvDisplay.Size = new Size(785, 469);
            pnlDgvDisplay.TabIndex = 24;
            // 
            // clmId
            // 
            dataGridViewCellStyle2.Font = new Font("Nirmala UI", 8.25F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Gray;
            clmId.DefaultCellStyle = dataGridViewCellStyle2;
            clmId.HeaderText = "ID";
            clmId.MinimumWidth = 6;
            clmId.Name = "clmId";
            clmId.ReadOnly = true;
            // 
            // clmClassName
            // 
            dataGridViewCellStyle3.Font = new Font("Nirmala UI", 9.25F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            clmClassName.DefaultCellStyle = dataGridViewCellStyle3;
            clmClassName.HeaderText = "Class Name";
            clmClassName.MinimumWidth = 6;
            clmClassName.Name = "clmClassName";
            clmClassName.ReadOnly = true;
            // 
            // clmClassType
            // 
            clmClassType.HeaderText = "Class Type";
            clmClassType.MinimumWidth = 6;
            clmClassType.Name = "clmClassType";
            clmClassType.ReadOnly = true;
            // 
            // clmTrainer
            // 
            dataGridViewCellStyle4.Font = new Font("Nirmala UI", 8.25F, FontStyle.Bold);
            clmTrainer.DefaultCellStyle = dataGridViewCellStyle4;
            clmTrainer.HeaderText = "Trainer";
            clmTrainer.MinimumWidth = 6;
            clmTrainer.Name = "clmTrainer";
            clmTrainer.ReadOnly = true;
            // 
            // clmSchedule
            // 
            clmSchedule.HeaderText = "Schedule";
            clmSchedule.MinimumWidth = 6;
            clmSchedule.Name = "clmSchedule";
            clmSchedule.ReadOnly = true;
            // 
            // frmClassGridView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 469);
            Controls.Add(pnlDgvBack);
            Controls.Add(txtSearchClass);
            Controls.Add(lblChange);
            Controls.Add(btnSearchClass);
            Controls.Add(pnlDgvDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmClassGridView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmClassGridView";
            pnlDgvBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private csLaundrySystem.CustomizableCornerPanel pnlDgvBack;
        private DataGridView dgvClass;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchClass;
        private Label lblChange;
        private Guna.UI2.WinForms.Guna2Button btnSearchClass;
        private Panel pnlDgvDisplay;
        private DataGridViewTextBoxColumn clmId;
        private DataGridViewTextBoxColumn clmClassName;
        private DataGridViewTextBoxColumn clmClassType;
        private DataGridViewTextBoxColumn clmTrainer;
        private DataGridViewTextBoxColumn clmSchedule;
    }
}