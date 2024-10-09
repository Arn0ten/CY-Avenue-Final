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

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmDahsboard : Form
    {
        private fncControl Control;
        private frmMembersGridView membersGridView;
        private frmStaffGridView staffGridView;
        private frmTrainerGridView trainerGridView;
        private frmClassGridView classGridView;
        private frmAttendanceGridView attendanceGridView;
        private frmBillingGridView billingGridView;
        frmRevenue RevenueForm = new frmRevenue();
        frmMemberMainForm MemberMainForm = new frmMemberMainForm();
        frmstaffManagement StaffManagementForm = new frmstaffManagement();
        frmTrainerMainForm TrainerMainForm = new frmTrainerMainForm();
        

        public frmDahsboard()
        {
            InitializeComponent();
            cmbFilter.SelectedIndex = 0;
            Control = new fncControl();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, MemberMainForm);
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
    }
}
