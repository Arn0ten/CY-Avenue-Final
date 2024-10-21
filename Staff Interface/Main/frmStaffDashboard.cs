using CarlosYulo.backend;
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

namespace csCY_Avenue.Staff_Interface.Main
{
    public partial class frmStaffDashboard : Form
    {
        fncControl Control;
        private frmMemberGridView membersGridView;
        private frmTrainerGridView trainerGridView;
        private frmClassGridView classGridView;
        private frmAttendanceGridView attendanceGridView;
        private frmBillingGridView billingGridView;
        frmMemberManagement MemberManagement = new frmMemberManagement();
        frmClassesAndSchedules ClassesAndSchedulesManagement = new frmClassesAndSchedules();
        frmTrainerMainForm TrainerManagement = new frmTrainerMainForm();

        public frmStaffDashboard()
        {
            InitializeComponent();
            cmbFilter.SelectedIndex = 0;
            Control = new fncControl();

            lblMembersCounter.Text = PreloadData.Clients.Count.ToString();

            lblTrainersCounter.Text = PreloadData.Employee
                      .Count(e => e.EmployeeTypeId == 3 || e.EmployeeTypeId == 4)
                      .ToString();
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
            else if (cmbFilter.SelectedItem.ToString() == "Attendance")
            {
                if (attendanceGridView == null)
                {
                    attendanceGridView = new frmAttendanceGridView();
                }
                selectedForm = attendanceGridView;
            }
            else if (cmbFilter.SelectedItem.ToString() == "Payment")
            {
                if (billingGridView == null)
                {
                    billingGridView = new frmBillingGridView();
                }
                selectedForm = billingGridView;
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
    }
}
