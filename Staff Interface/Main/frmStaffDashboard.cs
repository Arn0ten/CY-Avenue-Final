using CarlosYulo.backend;
using CarlosYulo.preload;
using csCY_Avenue.Custom;
using csCY_Avenue.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csCY_Avenue.Staff_Interface.Main
{
    public partial class frmStaffDashboard : Form
    {
        fncControl Control;
        private frmMemberGridView membersGridView;
        private frmTrainerGridView trainerGridView;
        private frmClassGridView classGridView;
        frmMemberManagement MemberManagement = new frmMemberManagement();
        frmClassesAndSchedules ClassesAndSchedulesManagement = new frmClassesAndSchedules();
        frmTrainerMainForm TrainerManagement = new frmTrainerMainForm();
        private GlobalProcedure _globalProcedure;
        public frmStaffDashboard()
        {
            InitializeComponent();
            cmbFilter.SelectedIndex = 0;
            Control = new fncControl();

            lblMembersCounter.Text = PreloadData.Clients.Count.ToString();

            lblTrainersCounter.Text = PreloadData.Employees
                      .Count(e => e.EmployeeTypeId == 3 || e.EmployeeTypeId == 4)
                      .ToString();
            _globalProcedure = new GlobalProcedure();
            LoadDashBoard();
        }


        private void LoadDashBoard()
        {
            LoadMembershipTypeCounts();
        }
        private void LoadMembershipTypeCounts()
        {
            if (_globalProcedure.fncConnectToDatabase())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand("prcCountMembershipTypes", _globalProcedure.conLaundry);
                    command.CommandType = CommandType.StoredProcedure;

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Reset labels in case any membership type has no records
                        lblVIPCount.Text = "0";
                        lblWalkInCount.Text = "0";
                        lblRegularCount.Text = "0";

                        while (reader.Read())
                        {
                            string membershipType = reader["MembershipType"].ToString();
                            int memberCount = Convert.ToInt32(reader["MemberCount"]);

                            // Update labels based on MembershipType
                            switch (membershipType)
                            {
                                case "VIP":
                                    lblVIPCount.Text = memberCount.ToString();
                                    break;
                                case "Walk-in":
                                    lblWalkInCount.Text = memberCount.ToString();
                                    break;
                                case "Regular":
                                    lblRegularCount.Text = memberCount.ToString();
                                    break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading membership counts: " + ex.Message);
                }
                finally
                {
                    _globalProcedure.conLaundry.Close();
                }
            }
            else
            {
                MessageBox.Show("Unable to connect to the database.");
            }
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, MemberManagement);
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, ClassesAndSchedulesManagement);
        }

        private void btnTrainers_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, TrainerManagement);
        }

        //Filter
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            pnlDgvDisplay.Controls.Clear();

            Form selectedForm = null;
            if (cmbFilter.SelectedItem.ToString() == "Members")
            {
                if (membersGridView == null)
                {
                    membersGridView = new frmMemberGridView();
                }
                selectedForm = membersGridView;
            }
            else if (cmbFilter.SelectedItem.ToString() == "Trainers")
            {
                if (trainerGridView == null)
                {
                    trainerGridView = new frmTrainerGridView();
                }
                selectedForm = trainerGridView;
            }
            else if (cmbFilter.SelectedItem.ToString() == "Class")
            {
                if (classGridView == null)
                {
                    classGridView = new frmClassGridView();
                }
                selectedForm = classGridView;
            }

            //Panel Loader
            if (selectedForm != null)
            {
                selectedForm.TopLevel = false;
                selectedForm.Dock = DockStyle.Fill;
                pnlDgvDisplay.Controls.Add(selectedForm);
                selectedForm.BringToFront();
                selectedForm.Show();
            }
        }

        //Transparent Labels
        private void pnlDisplay_Paint(object sender, PaintEventArgs e)
        {
            lblMembersCounter.Parent = btnMembers;
            lblMembersCounter.BackColor = Color.Transparent;
            lblMembers.Parent = btnMembers;
            lblMembers.BackColor = Color.Transparent;
            lblClassesCounter.Parent = btnClass;
            lblClassesCounter.BackColor = Color.Transparent;
            lblTrainersCounter.Parent = btnTrainers;
            lblTrainersCounter.BackColor = Color.Transparent;
            lblTrainers.Parent = btnTrainers;
            lblTrainers.BackColor = Color.Transparent;
            lblClasses.Parent = btnClass;
            lblClasses.BackColor = Color.Transparent;
        }

        private void lblMembersCounter_Click(object sender, EventArgs e)
        {

        }

        private void lblTrainersCounter_Click(object sender, EventArgs e)
        {

        }

        private void frmStaffDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
