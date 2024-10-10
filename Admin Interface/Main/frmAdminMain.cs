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
using csCY_Avenue.Admin_Interface.Main.AdminShopInterface;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmAdminMain : Form
    {
        private fncControl Control;
        private bool isCollapsed;
        private frmWelcome FormWelcome;
        frmDahsboard DashboardForm = new frmDahsboard();
        frmRevenue RevenueForm = new frmRevenue();
        frmMemberManagement CustomerManagementForm = new frmMemberManagement();
        frmstaffManagement StaffManagementForm = new frmstaffManagement();
        frmTrainerManagement TrainerManagementForm = new frmTrainerManagement();
        frmClassesAndSchedule ClassesAndScheduleForm = new frmClassesAndSchedule();
        frmAttendanceTracking AttendanceTrackingForm = new frmAttendanceTracking();
        frmBillingAndTransaction BillingAndTransactionForm = new frmBillingAndTransaction();
        frmShopManagement ShopManagementForm = new frmShopManagement();
        frmShopPerksOverview ShopPerksOverviewForm = new frmShopPerksOverview();
        frmNotifications NotificationsForm = new frmNotifications();
        AdminShopInterface.frmAdminShopMain AdminShopManagementForm = new AdminShopInterface.frmAdminShopMain();
        

        public frmAdminMain()
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
            Control.LoadFormInPanel(pnlDisplay, BillingAndTransactionForm);
        }
        private void btnShop_Click(object sender, EventArgs e)
        {
            AdminShopManagementForm.ShowDialog();
        }

        private void btnPerksOverview_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, ShopPerksOverviewForm);
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

