using csCY_Avenue.AuthPage;
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
    public partial class frmMain : Form
    {
        private fncControl Control;
        private bool isCollapsed;
        private frmWelcome FormWelcome;
        frmDahsboard DashboardForm = new frmDahsboard();
        frmRevenue RevenueForm = new frmRevenue();
        frmCustomerManagement CustomerManagementForm = new frmCustomerManagement();
        frmstaffManagement StaffManagementForm = new frmstaffManagement();
        frmTrainerManagement TrainerManagementForm = new frmTrainerManagement();
        frmClassesAndSchedule ClassesAndScheduleForm = new frmClassesAndSchedule();
        frmAttendanceTracking AttendanceTrackingForm = new frmAttendanceTracking();
        frmBillingAndPayments BillingAndPaymentsForm = new frmBillingAndPayments();
        frmNotifications NotificationsForm = new frmNotifications();
       
        public frmMain()
        {
            InitializeComponent();
            FormWelcome = new frmWelcome();
            Control = new fncControl();
            Control.LoadFormInPanel(pnlDisplay, DashboardForm);
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, DashboardForm);
        }
        private void btnRevenue_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, RevenueForm);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, CustomerManagementForm);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, StaffManagementForm);
        }

        private void btnTrainer_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, TrainerManagementForm);
        }

        private void btnClassesAndManagement_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, ClassesAndScheduleForm);
        }

        private void btnAttendanceTracking_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, AttendanceTrackingForm);
        }

        private void btnBillingAndNotifications_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, BillingAndPaymentsForm);
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, NotificationsForm);
        }

        //Dropdown
        private void btnManagement_Click(object sender, EventArgs e)
        {
            tmrManagementButton.Start();
        }


        //Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            FormWelcome.Show();
            this.Close();
        }

        private void tmrManagementButton_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pnlManagementButton.Height += 10;
                if (pnlManagementButton.Size == pnlManagementButton.MaximumSize)
                {
                    tmrManagementButton.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                pnlManagementButton.Height -= 10;
                if (pnlManagementButton.Size == pnlManagementButton.MinimumSize)
                {
                    tmrManagementButton.Stop();
                    isCollapsed = true;
                }
            }
        }

        //Na pindot
        private void pnlDisplay_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

