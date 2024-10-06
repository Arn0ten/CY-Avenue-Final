namespace csCY_Avenue.Admin_Interface.Main
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
            pnlDgvBack = new csLaundrySystem.CustomizableCornerPanel();
            Class = new DataGridView();
            txtSearchClass = new Guna.UI2.WinForms.Guna2TextBox();
            lblChange = new Label();
            btnSearchClass = new Guna.UI2.WinForms.Guna2Button();
            pnlDgvDisplay = new Panel();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            pnlDgvBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Class).BeginInit();
            SuspendLayout();
            // 
            // pnlDgvBack
            // 
            pnlDgvBack.BackColor = Color.FromArgb(41, 50, 113);
            pnlDgvBack.BorderColor = Color.Black;
            pnlDgvBack.BorderWidth = 1F;
            pnlDgvBack.Controls.Add(Class);
            pnlDgvBack.CornerRadius = 20;
            pnlDgvBack.Location = new Point(15, 39);
            pnlDgvBack.Name = "pnlDgvBack";
            pnlDgvBack.Size = new Size(758, 424);
            pnlDgvBack.TabIndex = 18;
            // 
            // Class
            // 
            Class.AllowUserToAddRows = false;
            Class.AllowUserToDeleteRows = false;
            Class.AllowUserToResizeRows = false;
            Class.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Class.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Class.BackgroundColor = Color.White;
            Class.BorderStyle = BorderStyle.None;
            Class.CellBorderStyle = DataGridViewCellBorderStyle.None;
            Class.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Class.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Class.ColumnHeadersHeight = 35;
            Class.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            Class.EnableHeadersVisualStyles = false;
            Class.GridColor = SystemColors.ScrollBar;
            Class.Location = new Point(0, 2);
            Class.Name = "Class";
            Class.ReadOnly = true;
            Class.RowHeadersVisible = false;
            Class.RowHeadersWidth = 35;
            Class.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Class.Size = new Size(759, 428);
            Class.TabIndex = 6;
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
            txtSearchClass.Name = "txtSearchClass";
            txtSearchClass.PasswordChar = '\0';
            txtSearchClass.PlaceholderForeColor = Color.FromArgb(112, 112, 112);
            txtSearchClass.PlaceholderText = "⌕ Search Class";
            txtSearchClass.SelectedText = "";
            txtSearchClass.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearchClass.Size = new Size(301, 25);
            txtSearchClass.TabIndex = 17;
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
            btnSearchClass.TabIndex = 15;
            btnSearchClass.Text = "Search";
            // 
            // pnlDgvDisplay
            // 
            pnlDgvDisplay.Dock = DockStyle.Fill;
            pnlDgvDisplay.Location = new Point(0, 0);
            pnlDgvDisplay.Name = "pnlDgvDisplay";
            pnlDgvDisplay.Size = new Size(785, 469);
            pnlDgvDisplay.TabIndex = 19;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Class Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Trainer";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Schedule";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Capacity";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
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
            Text = "frmClassGridView";
            pnlDgvBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Class).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private csLaundrySystem.CustomizableCornerPanel pnlDgvBack;
        private DataGridView Class;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchClass;
        private Label lblChange;
        private Guna.UI2.WinForms.Guna2Button btnSearchClass;
        private Panel pnlDgvDisplay;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}