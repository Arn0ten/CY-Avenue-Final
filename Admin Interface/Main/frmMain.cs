using csCY_Avenue.AuthPage;
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
        frmSettings SettingsForm = new frmSettings();

        public frmMain()

        {
            InitializeComponent();
            FormWelcome = new frmWelcome();
            LoadFormInPanel(DashboardForm);
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(DashboardForm);
        }
        private void btnRevenue_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(RevenueForm);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(CustomerManagementForm);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(StaffManagementForm);
        }

        private void btnTrainer_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(TrainerManagementForm);
        }

        private void btnClassesAndManagement_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(ClassesAndScheduleForm);
        }

        private void btnAttendanceTracking_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(AttendanceTrackingForm);
        }

        private void btnBillingAndNotifications_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(BillingAndPaymentsForm);
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(NotificationsForm);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(SettingsForm);
        }

        //Panel loader 
        private void LoadFormInPanel(Form form)
        {           
            if (pnlDisplay.Controls.Count > 0 && pnlDisplay.Controls[0].GetType() == form.GetType())
                return; 

            pnlDisplay.Controls.Clear(); 

            form.TopLevel = false;  
            form.Dock = DockStyle.Fill; 
            pnlDisplay.Controls.Add(form); 
            form.Show(); 
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

        //Dropdown
        private void btnManagement_Click(object sender, EventArgs e)
        {
            tmrManagementButton.Start();
        }

        private void pnlDisplay_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

