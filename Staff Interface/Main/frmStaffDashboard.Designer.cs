namespace csCY_Avenue.Staff_Interface.Main
{
    partial class frmStaffDashboard
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
            lblMembers = new Label();
            cmbFilter = new ComboBox();
            guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            lblTrainersCounter = new Label();
            lblTrainers = new Label();
            btnTrainers = new Button();
            guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            lblClassesCounter = new Label();
            lblClasses = new Label();
            btnClass = new Button();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            lblMembersCounter = new Label();
            btnMembers = new Button();
            pnlDisplay = new Panel();
            pnlActiveMembershipPlans = new Guna.UI2.WinForms.Guna2ShadowPanel();
            guna2ShadowPanel8 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            lblRegularCount = new Label();
            pictureBox4 = new PictureBox();
            label22 = new Label();
            guna2ShadowPanel7 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            lblWalkInCount = new Label();
            pictureBox3 = new PictureBox();
            label21 = new Label();
            guna2ShadowPanel6 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            lblVIPCount = new Label();
            pictureBox2 = new PictureBox();
            label20 = new Label();
            label12 = new Label();
            label6 = new Label();
            pnlRevenueComparison = new Guna.UI2.WinForms.Guna2ShadowPanel();
            label1 = new Label();
            guna2ShadowPanel9 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            label18 = new Label();
            label14 = new Label();
            label17 = new Label();
            lblRevenueCurrentMonth = new Label();
            label4 = new Label();
            label3 = new Label();
            pnlDgvDisplay = new Panel();
            guna2ShadowPanel3.SuspendLayout();
            guna2ShadowPanel2.SuspendLayout();
            guna2ShadowPanel1.SuspendLayout();
            pnlDisplay.SuspendLayout();
            pnlActiveMembershipPlans.SuspendLayout();
            guna2ShadowPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            guna2ShadowPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            guna2ShadowPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlRevenueComparison.SuspendLayout();
            guna2ShadowPanel9.SuspendLayout();
            SuspendLayout();
            // 
            // lblMembers
            // 
            lblMembers.AutoSize = true;
            lblMembers.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMembers.ForeColor = Color.Gray;
            lblMembers.Location = new Point(25, 160);
            lblMembers.Name = "lblMembers";
            lblMembers.Size = new Size(159, 37);
            lblMembers.TabIndex = 1;
            lblMembers.Text = "Members : ";
            // 
            // cmbFilter
            // 
            cmbFilter.ForeColor = Color.Gray;
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "Members", "Trainers", "Class" });
            cmbFilter.Location = new Point(26, 300);
            cmbFilter.Margin = new Padding(3, 4, 3, 4);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(119, 28);
            cmbFilter.TabIndex = 7;
            cmbFilter.Tag = "Filter";
            cmbFilter.Text = "Filter";
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // guna2ShadowPanel3
            // 
            guna2ShadowPanel3.BackColor = Color.Transparent;
            guna2ShadowPanel3.Controls.Add(lblTrainersCounter);
            guna2ShadowPanel3.Controls.Add(lblTrainers);
            guna2ShadowPanel3.Controls.Add(btnTrainers);
            guna2ShadowPanel3.FillColor = Color.White;
            guna2ShadowPanel3.Location = new Point(631, 75);
            guna2ShadowPanel3.Margin = new Padding(3, 4, 3, 4);
            guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            guna2ShadowPanel3.Radius = 5;
            guna2ShadowPanel3.ShadowColor = Color.Black;
            guna2ShadowPanel3.ShadowDepth = 200;
            guna2ShadowPanel3.ShadowShift = 2;
            guna2ShadowPanel3.Size = new Size(271, 203);
            guna2ShadowPanel3.TabIndex = 3;
            // 
            // lblTrainersCounter
            // 
            lblTrainersCounter.AutoSize = true;
            lblTrainersCounter.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrainersCounter.Location = new Point(159, 152);
            lblTrainersCounter.Name = "lblTrainersCounter";
            lblTrainersCounter.Size = new Size(40, 46);
            lblTrainersCounter.TabIndex = 2;
            lblTrainersCounter.Text = "0";
            lblTrainersCounter.Click += lblTrainersCounter_Click;
            // 
            // lblTrainers
            // 
            lblTrainers.AutoSize = true;
            lblTrainers.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrainers.ForeColor = Color.Gray;
            lblTrainers.Location = new Point(25, 159);
            lblTrainers.Name = "lblTrainers";
            lblTrainers.Size = new Size(140, 37);
            lblTrainers.TabIndex = 1;
            lblTrainers.Text = "Trainers : ";
            // 
            // btnTrainers
            // 
            btnTrainers.BackgroundImageLayout = ImageLayout.None;
            btnTrainers.FlatAppearance.BorderSize = 0;
            btnTrainers.FlatStyle = FlatStyle.Flat;
            btnTrainers.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrainers.Image = Properties.Resources._8542020_dumbbell_weight_icon;
            btnTrainers.ImageAlign = ContentAlignment.TopLeft;
            btnTrainers.Location = new Point(0, 0);
            btnTrainers.Margin = new Padding(3, 4, 3, 4);
            btnTrainers.Name = "btnTrainers";
            btnTrainers.Size = new Size(271, 207);
            btnTrainers.TabIndex = 1;
            btnTrainers.TextAlign = ContentAlignment.BottomLeft;
            btnTrainers.UseVisualStyleBackColor = true;
            btnTrainers.Click += btnTrainers_Click;
            // 
            // guna2ShadowPanel2
            // 
            guna2ShadowPanel2.BackColor = Color.Transparent;
            guna2ShadowPanel2.Controls.Add(lblClassesCounter);
            guna2ShadowPanel2.Controls.Add(lblClasses);
            guna2ShadowPanel2.Controls.Add(btnClass);
            guna2ShadowPanel2.FillColor = Color.White;
            guna2ShadowPanel2.Location = new Point(334, 75);
            guna2ShadowPanel2.Margin = new Padding(3, 4, 3, 4);
            guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            guna2ShadowPanel2.Radius = 5;
            guna2ShadowPanel2.ShadowColor = Color.Black;
            guna2ShadowPanel2.ShadowDepth = 200;
            guna2ShadowPanel2.ShadowShift = 2;
            guna2ShadowPanel2.Size = new Size(271, 203);
            guna2ShadowPanel2.TabIndex = 3;
            // 
            // lblClassesCounter
            // 
            lblClassesCounter.AutoSize = true;
            lblClassesCounter.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassesCounter.Location = new Point(157, 153);
            lblClassesCounter.Name = "lblClassesCounter";
            lblClassesCounter.Size = new Size(40, 46);
            lblClassesCounter.TabIndex = 2;
            lblClassesCounter.Text = "0";
            // 
            // lblClasses
            // 
            lblClasses.AutoSize = true;
            lblClasses.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClasses.ForeColor = Color.Gray;
            lblClasses.Location = new Point(54, 161);
            lblClasses.Name = "lblClasses";
            lblClasses.Size = new Size(129, 37);
            lblClasses.TabIndex = 1;
            lblClasses.Text = "Classes : ";
            // 
            // btnClass
            // 
            btnClass.BackgroundImageLayout = ImageLayout.None;
            btnClass.FlatAppearance.BorderSize = 0;
            btnClass.FlatStyle = FlatStyle.Flat;
            btnClass.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClass.Image = Properties.Resources._4308144_employee_insurance_person_personal_protection_icon;
            btnClass.ImageAlign = ContentAlignment.TopLeft;
            btnClass.Location = new Point(0, 0);
            btnClass.Margin = new Padding(3, 4, 3, 4);
            btnClass.Name = "btnClass";
            btnClass.Size = new Size(271, 207);
            btnClass.TabIndex = 1;
            btnClass.TextAlign = ContentAlignment.BottomLeft;
            btnClass.UseVisualStyleBackColor = true;
            btnClass.Click += btnClass_Click;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(lblMembersCounter);
            guna2ShadowPanel1.Controls.Add(lblMembers);
            guna2ShadowPanel1.Controls.Add(btnMembers);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(31, 75);
            guna2ShadowPanel1.Margin = new Padding(3, 4, 3, 4);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 5;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.ShadowDepth = 200;
            guna2ShadowPanel1.ShadowShift = 2;
            guna2ShadowPanel1.Size = new Size(271, 203);
            guna2ShadowPanel1.TabIndex = 0;
            // 
            // lblMembersCounter
            // 
            lblMembersCounter.AutoSize = true;
            lblMembersCounter.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMembersCounter.Location = new Point(159, 155);
            lblMembersCounter.Name = "lblMembersCounter";
            lblMembersCounter.Size = new Size(40, 46);
            lblMembersCounter.TabIndex = 2;
            lblMembersCounter.Text = "0";
            lblMembersCounter.Click += lblMembersCounter_Click;
            // 
            // btnMembers
            // 
            btnMembers.BackgroundImageLayout = ImageLayout.None;
            btnMembers.FlatAppearance.BorderSize = 0;
            btnMembers.FlatStyle = FlatStyle.Flat;
            btnMembers.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMembers.Image = Properties.Resources._309041_users_group_people_icon__1_;
            btnMembers.ImageAlign = ContentAlignment.TopLeft;
            btnMembers.Location = new Point(0, 0);
            btnMembers.Margin = new Padding(3, 4, 3, 4);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(271, 207);
            btnMembers.TabIndex = 1;
            btnMembers.TextAlign = ContentAlignment.BottomLeft;
            btnMembers.UseVisualStyleBackColor = true;
            btnMembers.Click += btnMembers_Click;
            // 
            // pnlDisplay
            // 
            pnlDisplay.Controls.Add(pnlActiveMembershipPlans);
            pnlDisplay.Controls.Add(label6);
            pnlDisplay.Controls.Add(pnlRevenueComparison);
            pnlDisplay.Controls.Add(label4);
            pnlDisplay.Controls.Add(label3);
            pnlDisplay.Controls.Add(pnlDgvDisplay);
            pnlDisplay.Controls.Add(cmbFilter);
            pnlDisplay.Controls.Add(guna2ShadowPanel3);
            pnlDisplay.Controls.Add(guna2ShadowPanel2);
            pnlDisplay.Controls.Add(guna2ShadowPanel1);
            pnlDisplay.Dock = DockStyle.Fill;
            pnlDisplay.Location = new Point(0, 0);
            pnlDisplay.Margin = new Padding(3, 4, 3, 4);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(1341, 788);
            pnlDisplay.TabIndex = 2;
            pnlDisplay.Paint += pnlDisplay_Paint;
            // 
            // pnlActiveMembershipPlans
            // 
            pnlActiveMembershipPlans.BackColor = Color.Transparent;
            pnlActiveMembershipPlans.Controls.Add(guna2ShadowPanel8);
            pnlActiveMembershipPlans.Controls.Add(guna2ShadowPanel7);
            pnlActiveMembershipPlans.Controls.Add(guna2ShadowPanel6);
            pnlActiveMembershipPlans.Controls.Add(label12);
            pnlActiveMembershipPlans.FillColor = Color.White;
            pnlActiveMembershipPlans.Location = new Point(943, 621);
            pnlActiveMembershipPlans.Margin = new Padding(3, 4, 3, 4);
            pnlActiveMembershipPlans.Name = "pnlActiveMembershipPlans";
            pnlActiveMembershipPlans.Radius = 5;
            pnlActiveMembershipPlans.ShadowColor = Color.Black;
            pnlActiveMembershipPlans.ShadowDepth = 200;
            pnlActiveMembershipPlans.ShadowShift = 2;
            pnlActiveMembershipPlans.Size = new Size(335, 291);
            pnlActiveMembershipPlans.TabIndex = 19;
            // 
            // guna2ShadowPanel8
            // 
            guna2ShadowPanel8.BackColor = Color.Transparent;
            guna2ShadowPanel8.Controls.Add(lblRegularCount);
            guna2ShadowPanel8.Controls.Add(pictureBox4);
            guna2ShadowPanel8.Controls.Add(label22);
            guna2ShadowPanel8.FillColor = Color.White;
            guna2ShadowPanel8.Location = new Point(15, 200);
            guna2ShadowPanel8.Margin = new Padding(3, 4, 3, 4);
            guna2ShadowPanel8.Name = "guna2ShadowPanel8";
            guna2ShadowPanel8.ShadowColor = Color.Black;
            guna2ShadowPanel8.ShadowDepth = 200;
            guna2ShadowPanel8.ShadowShift = 2;
            guna2ShadowPanel8.Size = new Size(302, 60);
            guna2ShadowPanel8.TabIndex = 21;
            // 
            // lblRegularCount
            // 
            lblRegularCount.AutoSize = true;
            lblRegularCount.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegularCount.ForeColor = Color.Black;
            lblRegularCount.Location = new Point(145, 11);
            lblRegularCount.Name = "lblRegularCount";
            lblRegularCount.Size = new Size(33, 37);
            lblRegularCount.TabIndex = 24;
            lblRegularCount.Text = "0";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._7436253_exercise_stress_test_medical_fitness_physiology_running_icon;
            pictureBox4.Location = new Point(3, 0);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(56, 61);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Nirmala UI", 11.25F);
            label22.ForeColor = Color.Black;
            label22.Location = new Point(62, 17);
            label22.Name = "label22";
            label22.Size = new Size(95, 25);
            label22.TabIndex = 14;
            label22.Text = "Regular  : ";
            // 
            // guna2ShadowPanel7
            // 
            guna2ShadowPanel7.BackColor = Color.Transparent;
            guna2ShadowPanel7.Controls.Add(lblWalkInCount);
            guna2ShadowPanel7.Controls.Add(pictureBox3);
            guna2ShadowPanel7.Controls.Add(label21);
            guna2ShadowPanel7.FillColor = Color.White;
            guna2ShadowPanel7.Location = new Point(15, 115);
            guna2ShadowPanel7.Margin = new Padding(3, 4, 3, 4);
            guna2ShadowPanel7.Name = "guna2ShadowPanel7";
            guna2ShadowPanel7.ShadowColor = Color.Black;
            guna2ShadowPanel7.ShadowDepth = 200;
            guna2ShadowPanel7.ShadowShift = 2;
            guna2ShadowPanel7.Size = new Size(302, 60);
            guna2ShadowPanel7.TabIndex = 21;
            // 
            // lblWalkInCount
            // 
            lblWalkInCount.AutoSize = true;
            lblWalkInCount.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWalkInCount.ForeColor = Color.Black;
            lblWalkInCount.Location = new Point(139, 9);
            lblWalkInCount.Name = "lblWalkInCount";
            lblWalkInCount.Size = new Size(33, 37);
            lblWalkInCount.TabIndex = 23;
            lblWalkInCount.Text = "0";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._1054988_running_person_walking_icon;
            pictureBox3.Location = new Point(3, 0);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 61);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Nirmala UI", 11.25F);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(62, 16);
            label21.Name = "label21";
            label21.Size = new Size(90, 25);
            label21.TabIndex = 14;
            label21.Text = "Walk-in : ";
            // 
            // guna2ShadowPanel6
            // 
            guna2ShadowPanel6.BackColor = Color.Transparent;
            guna2ShadowPanel6.Controls.Add(lblVIPCount);
            guna2ShadowPanel6.Controls.Add(pictureBox2);
            guna2ShadowPanel6.Controls.Add(label20);
            guna2ShadowPanel6.FillColor = Color.White;
            guna2ShadowPanel6.Location = new Point(15, 25);
            guna2ShadowPanel6.Margin = new Padding(3, 4, 3, 4);
            guna2ShadowPanel6.Name = "guna2ShadowPanel6";
            guna2ShadowPanel6.ShadowColor = Color.Black;
            guna2ShadowPanel6.ShadowDepth = 200;
            guna2ShadowPanel6.ShadowShift = 2;
            guna2ShadowPanel6.Size = new Size(302, 60);
            guna2ShadowPanel6.TabIndex = 20;
            // 
            // lblVIPCount
            // 
            lblVIPCount.AutoSize = true;
            lblVIPCount.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVIPCount.ForeColor = Color.Black;
            lblVIPCount.Location = new Point(106, 9);
            lblVIPCount.Name = "lblVIPCount";
            lblVIPCount.Size = new Size(33, 37);
            lblVIPCount.TabIndex = 22;
            lblVIPCount.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._8679185_vip_premium_icon;
            pictureBox2.Location = new Point(3, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Nirmala UI", 11.25F);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(62, 16);
            label20.Name = "label20";
            label20.Size = new Size(54, 25);
            label20.TabIndex = 14;
            label20.Text = "VIP : ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(18, 156);
            label12.Name = "label12";
            label12.Size = new Size(0, 25);
            label12.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(943, 303);
            label6.Name = "label6";
            label6.Size = new Size(200, 25);
            label6.TabIndex = 18;
            label6.Text = "Revenue Comparison";
            // 
            // pnlRevenueComparison
            // 
            pnlRevenueComparison.BackColor = Color.Transparent;
            pnlRevenueComparison.Controls.Add(label1);
            pnlRevenueComparison.Controls.Add(guna2ShadowPanel9);
            pnlRevenueComparison.Controls.Add(label17);
            pnlRevenueComparison.Controls.Add(lblRevenueCurrentMonth);
            pnlRevenueComparison.FillColor = Color.White;
            pnlRevenueComparison.Location = new Point(943, 334);
            pnlRevenueComparison.Margin = new Padding(3, 4, 3, 4);
            pnlRevenueComparison.Name = "pnlRevenueComparison";
            pnlRevenueComparison.Radius = 5;
            pnlRevenueComparison.ShadowColor = Color.Black;
            pnlRevenueComparison.ShadowDepth = 200;
            pnlRevenueComparison.ShadowShift = 2;
            pnlRevenueComparison.Size = new Size(381, 239);
            pnlRevenueComparison.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(15, 31);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 24;
            label1.Text = "Current Month :";
            // 
            // guna2ShadowPanel9
            // 
            guna2ShadowPanel9.BackColor = Color.Transparent;
            guna2ShadowPanel9.Controls.Add(label18);
            guna2ShadowPanel9.Controls.Add(label14);
            guna2ShadowPanel9.FillColor = Color.FromArgb(223, 225, 237);
            guna2ShadowPanel9.Location = new Point(15, 124);
            guna2ShadowPanel9.Margin = new Padding(3, 4, 3, 4);
            guna2ShadowPanel9.Name = "guna2ShadowPanel9";
            guna2ShadowPanel9.ShadowColor = Color.Black;
            guna2ShadowPanel9.ShadowShift = 1;
            guna2ShadowPanel9.Size = new Size(352, 104);
            guna2ShadowPanel9.TabIndex = 23;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(24, 56);
            label18.Name = "label18";
            label18.Size = new Size(56, 20);
            label18.TabIndex = 21;
            label18.Text = "Shop : ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(24, 20);
            label14.Name = "label14";
            label14.Size = new Size(112, 20);
            label14.TabIndex = 19;
            label14.Text = "Memberships :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(16, 85);
            label17.Name = "label17";
            label17.Size = new Size(185, 32);
            label17.TabIndex = 20;
            label17.Text = "Top Revenues :";
            // 
            // lblRevenueCurrentMonth
            // 
            lblRevenueCurrentMonth.AutoSize = true;
            lblRevenueCurrentMonth.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRevenueCurrentMonth.ForeColor = Color.FromArgb(0, 192, 0);
            lblRevenueCurrentMonth.Location = new Point(170, 29);
            lblRevenueCurrentMonth.Name = "lblRevenueCurrentMonth";
            lblRevenueCurrentMonth.Size = new Size(150, 28);
            lblRevenueCurrentMonth.TabIndex = 19;
            lblRevenueCurrentMonth.Text = "₱1,000.000.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(943, 590);
            label4.Name = "label4";
            label4.Size = new Size(234, 25);
            label4.TabIndex = 16;
            label4.Text = "Active Membership Plans";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(232, 46);
            label3.TabIndex = 15;
            label3.Text = "DASHBOARD";
            // 
            // pnlDgvDisplay
            // 
            pnlDgvDisplay.Location = new Point(14, 332);
            pnlDgvDisplay.Margin = new Padding(3, 4, 3, 4);
            pnlDgvDisplay.Name = "pnlDgvDisplay";
            pnlDgvDisplay.Size = new Size(897, 625);
            pnlDgvDisplay.TabIndex = 14;
            // 
            // frmStaffDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 788);
            Controls.Add(pnlDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmStaffDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmStaffDashboard";
            guna2ShadowPanel3.ResumeLayout(false);
            guna2ShadowPanel3.PerformLayout();
            guna2ShadowPanel2.ResumeLayout(false);
            guna2ShadowPanel2.PerformLayout();
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            pnlDisplay.ResumeLayout(false);
            pnlDisplay.PerformLayout();
            pnlActiveMembershipPlans.ResumeLayout(false);
            pnlActiveMembershipPlans.PerformLayout();
            guna2ShadowPanel8.ResumeLayout(false);
            guna2ShadowPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            guna2ShadowPanel7.ResumeLayout(false);
            guna2ShadowPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            guna2ShadowPanel6.ResumeLayout(false);
            guna2ShadowPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlRevenueComparison.ResumeLayout(false);
            pnlRevenueComparison.PerformLayout();
            guna2ShadowPanel9.ResumeLayout(false);
            guna2ShadowPanel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblMembers;
        private ComboBox cmbFilter;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
        private Label lblTrainersCounter;
        private Label lblTrainers;
        private Button btnTrainers;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Label lblClassesCounter;
        private Label lblClasses;
        private Button btnClass;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Label lblMembersCounter;
        private Button btnMembers;
        private Panel pnlDisplay;
        private Label label3;
        private Panel pnlDgvDisplay;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlActiveMembershipPlans;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel8;
        private Label lblRegularCount;
        private PictureBox pictureBox4;
        private Label label22;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel7;
        private Label lblWalkInCount;
        private PictureBox pictureBox3;
        private Label label21;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel6;
        private Label lblVIPCount;
        private PictureBox pictureBox2;
        private Label label20;
        private Label label12;
        private Label label6;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlRevenueComparison;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel9;
        private Label label18;
        private Label label14;
        private Label label17;
        private Label lblRevenueCurrentMonth;
        private Label label4;
    }
}