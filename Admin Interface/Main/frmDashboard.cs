using CarlosYulo;
using CarlosYulo.backend;
using CarlosYulo.backend.entities;
using CarlosYulo.backend.monolith.revenue;
using CarlosYulo.preload;
using csCY_Avenue.Custom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using csCY_Avenue.Database;
using MySql.Data.MySqlClient;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmDashboard : Form
    {
        private fncControl Control;
        private GlobalProcedure _globalProcedure;
        // panel table
        private frmMembersGridView membersGridView;
        private frmStaffGridView staffGridView;
        private frmTrainerGridView trainerGridView;

        frmRevenue RevenueForm = new frmRevenue();
        // frmMemberMainForm MemberMainForm = new frmMemberMainForm();
        frmMemberManagement MemberManagement = new frmMemberManagement();
        frmstaffManagement StaffManagementForm = new frmstaffManagement();
        frmTrainerMainForm TrainerMainForm = new frmTrainerMainForm();

        // backend
        private List<Client> clients = PreloadData.Clients;
        private List<Employee> trainers = PreloadData.Employees;
        private RevenueController _revenue;
        // private FinalRevenueReport revenueReport;


        public frmDashboard()
        {
            InitializeComponent();
            cmbFilter.SelectedIndex = 0;
            Control = new fncControl();

            // object
            _revenue = ServiceLocator.GetService<RevenueController>();

            clients = PreloadData.Clients;
            trainers = PreloadData.Employees;
            _globalProcedure = new GlobalProcedure();
            LoadDashBoard();
        }

        private void LoadDashBoard()
        {
            // sa taas
            lblMembersCounter.Text = PreloadData.Clients.Count.ToString();
            lblStaffsCounter.Text = PreloadData.Employees
                        .Count(e => e.EmployeeTypeId == 1 || e.EmployeeTypeId == 2)
                         .ToString();
            lblTrainersCounter.Text = PreloadData.Employees
                      .Count(e => e.EmployeeTypeId == 3 || e.EmployeeTypeId == 4)
                      .ToString();

            // REVENUE
            //..current
            FinalRevenueReport currentReport = _revenue.SearchRevenueByMonthPreload(DateTime.Now);
            if (currentReport != null && currentReport.FinalRevenue.HasValue)
            { lblRevenueCurrentMonth.Text = "₱ " + currentReport.FinalRevenue.Value.ToString("N2"); }
            else
            { lblRevenueCurrentMonth.Text = "Current Month: No Revenue"; }
            //..previous
            FinalRevenueReport lastMonthReport = _revenue.SearchRevenueByMonthPreload(DateTime.Now.AddDays(-30));
          

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
                                case "Walk-In":
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

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, StaffManagementForm);
        }
        
        private void btnTrainers_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, TrainerMainForm);
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
                    membersGridView = new frmMembersGridView();
                }
                selectedForm = membersGridView;
            }
            else if (cmbFilter.SelectedItem.ToString() == "Staffs")
            {
                if (staffGridView == null)
                {
                    staffGridView = new frmStaffGridView();
                }
                selectedForm = staffGridView;
            }
            else if (cmbFilter.SelectedItem.ToString() == "Trainers")
            {
                if (trainerGridView == null)
                {
                    trainerGridView = new frmTrainerGridView();
                }
                selectedForm = trainerGridView;
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

        //Transparent na label
        private void pnlDisplay_Paint(object sender, PaintEventArgs e)
        {
            lblMembersCounter.Parent = btnMembers;
            lblMembersCounter.BackColor = Color.Transparent;
            lblMembers.Parent = btnMembers;
            lblMembers.BackColor = Color.Transparent;
            lblStaffsCounter.Parent = btnStaff;
            lblStaffsCounter.BackColor = Color.Transparent;
            lblStaffs.Parent = btnStaff;
            lblStaffs.BackColor = Color.Transparent;
            lblTrainersCounter.Parent = btnTrainers;
            lblTrainersCounter.BackColor = Color.Transparent;
            lblTrainers.Parent = btnTrainers;
            lblTrainers.BackColor = Color.Transparent;
        }

        private void lblMembersCounter_Click(object sender, EventArgs e)
        {

        }

        private void lblRevenueCurrentMonth_Click(object sender, EventArgs e)
        {

        }

        private void lblRevenueLastMonth_Click(object sender, EventArgs e)
        {

        }

        private void lblTrainersCounter_Click(object sender, EventArgs e)
        {

        }
    }
}
