namespace csCY_Avenue.Admin_Interface.Main
{
    partial class frmShopCheckBuyer
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            button1 = new Button();
            guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            label1 = new Label();
            FormDesign = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            pnlDgvBack = new csLaundrySystem.CustomizableCornerPanel();
            dgvMember = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            txtSearchMember = new Guna.UI2.WinForms.Guna2TextBox();
            btnSearchMember = new Guna.UI2.WinForms.Guna2Button();
            label4 = new Label();
            btnProceed = new Guna.UI2.WinForms.Guna2Button();
            guna2ShadowPanel2.SuspendLayout();
            pnlDgvBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
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
            guna2ShadowPanel2.TabIndex = 96;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(260, 13);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 2;
            label1.Text = "CHECK BUYER";
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
            pnlDgvBack.Controls.Add(dgvMember);
            pnlDgvBack.CornerRadius = 20;
            pnlDgvBack.Location = new Point(12, 116);
            pnlDgvBack.Name = "pnlDgvBack";
            pnlDgvBack.Size = new Size(612, 338);
            pnlDgvBack.TabIndex = 97;
            // 
            // dgvMember
            // 
            dgvMember.AllowUserToAddRows = false;
            dgvMember.AllowUserToDeleteRows = false;
            dgvMember.AllowUserToResizeRows = false;
            dgvMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMember.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMember.BackgroundColor = Color.White;
            dgvMember.BorderStyle = BorderStyle.None;
            dgvMember.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvMember.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 50, 113);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMember.ColumnHeadersHeight = 35;
            dgvMember.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4, Column3 });
            dgvMember.EnableHeadersVisualStyles = false;
            dgvMember.GridColor = SystemColors.ScrollBar;
            dgvMember.Location = new Point(0, 3);
            dgvMember.Name = "dgvMember";
            dgvMember.ReadOnly = true;
            dgvMember.RowHeadersVisible = false;
            dgvMember.RowHeadersWidth = 35;
            dgvMember.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMember.Size = new Size(612, 335);
            dgvMember.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "Member ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Member Type";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Status";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // txtSearchMember
            // 
            txtSearchMember.BorderRadius = 5;
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
            txtSearchMember.Location = new Point(171, 73);
            txtSearchMember.Name = "txtSearchMember";
            txtSearchMember.PasswordChar = '\0';
            txtSearchMember.PlaceholderForeColor = Color.FromArgb(112, 112, 112);
            txtSearchMember.PlaceholderText = "";
            txtSearchMember.SelectedText = "";
            txtSearchMember.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSearchMember.Size = new Size(313, 34);
            txtSearchMember.TabIndex = 99;
            // 
            // btnSearchMember
            // 
            btnSearchMember.BackColor = Color.Transparent;
            btnSearchMember.BorderRadius = 5;
            btnSearchMember.CustomizableEdges = customizableEdges5;
            btnSearchMember.DisabledState.BorderColor = Color.DarkGray;
            btnSearchMember.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearchMember.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearchMember.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearchMember.FillColor = Color.FromArgb(67, 154, 71);
            btnSearchMember.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchMember.ForeColor = Color.White;
            btnSearchMember.HoverState.CustomBorderColor = Color.FromArgb(125, 183, 127);
            btnSearchMember.HoverState.ForeColor = Color.White;
            btnSearchMember.Location = new Point(490, 73);
            btnSearchMember.Name = "btnSearchMember";
            btnSearchMember.PressedColor = Color.FromArgb(67, 154, 71);
            btnSearchMember.ShadowDecoration.BorderRadius = 9;
            btnSearchMember.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSearchMember.Size = new Size(75, 34);
            btnSearchMember.TabIndex = 98;
            btnSearchMember.Text = "Search";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 81);
            label4.Name = "label4";
            label4.Size = new Size(152, 17);
            label4.TabIndex = 100;
            label4.Text = "Member ID/Fullname  :";
            // 
            // btnProceed
            // 
            btnProceed.BackColor = Color.Transparent;
            btnProceed.BorderRadius = 5;
            btnProceed.CustomizableEdges = customizableEdges1;
            btnProceed.DisabledState.BorderColor = Color.DarkGray;
            btnProceed.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProceed.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProceed.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProceed.FillColor = Color.FromArgb(67, 154, 71);
            btnProceed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProceed.ForeColor = Color.White;
            btnProceed.HoverState.CustomBorderColor = Color.FromArgb(125, 183, 127);
            btnProceed.HoverState.ForeColor = Color.White;
            btnProceed.Location = new Point(53, 481);
            btnProceed.Name = "btnProceed";
            btnProceed.PressedColor = Color.FromArgb(67, 154, 71);
            btnProceed.ShadowDecoration.BorderRadius = 9;
            btnProceed.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnProceed.Size = new Size(535, 34);
            btnProceed.TabIndex = 101;
            btnProceed.Text = "Proceed";
            btnProceed.Click += btnProceed_Click;
            // 
            // frmShopCheckBuyer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 538);
            Controls.Add(btnProceed);
            Controls.Add(label4);
            Controls.Add(txtSearchMember);
            Controls.Add(btnSearchMember);
            Controls.Add(guna2ShadowPanel2);
            Controls.Add(pnlDgvBack);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmShopCheckBuyer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmShopCheckBuyer";
            guna2ShadowPanel2.ResumeLayout(false);
            guna2ShadowPanel2.PerformLayout();
            pnlDgvBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm FormDesign;
        private csLaundrySystem.CustomizableCornerPanel pnlDgvBack;
        private DataGridView dgvMember;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchMember;
        private Guna.UI2.WinForms.Guna2Button btnSearchMember;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button btnProceed;
    }
}