using csCY_Avenue.Admin_Interface.Main;
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
    public partial class frmStaffMain : Form
    {
        private fncControl Control;
        private bool isCollapsed;
        StaffShopInterface.frmStaffShopMain StaffShopInterface = new StaffShopInterface.frmStaffShopMain();
        frmStaffDashboard StaffDashboardForm = new frmStaffDashboard();
        frmStaffRevenue StaffRevnueForm = new frmStaffRevenue();
        frmStaffClassesAndSchedules StaffClassesAndSchedulesForm = new frmStaffClassesAndSchedules();
        frmStaffBillingAndTransactions StaffBillingAndTransactionsForm = new frmStaffBillingAndTransactions();
        frmStaffNotifications StaffNotificationsForm = new frmStaffNotifications();
        frmShopPerksOverview PerksOverviewForm = new frmShopPerksOverview();

        public frmStaffMain()
        {
            InitializeComponent();
            Control = new fncControl();
            Control.LoadFormInPanel(pnlDisplay, StaffDashboardForm);
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            StaffShopInterface.ShowDialog();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, StaffDashboardForm);
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, StaffRevnueForm);
        }

        private void btnAttendanceMember_Click(object sender, EventArgs e)
        {

        }

        private void btnAttendanceTrainer_Click(object sender, EventArgs e)
        {

        }

        private void btnClassesAndManagement_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, StaffClassesAndSchedulesForm);
        }

        private void btnBillingAndTransactions_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, StaffClassesAndSchedulesForm);
        }

        private void btnPerksOverview_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, PerksOverviewForm);
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, StaffNotificationsForm);
        }



        //Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Management Dropdown
        private void btnManagement_Click(object sender, EventArgs e)
        {
            tmrManagementButton.Start();
        }

        //Attendance Dropdown
        private void btnAttendance_Click(object sender, EventArgs e)
        {
            tmrAttendanceButton.Start();
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

        private void tmrAttendanceButton_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pnlAttendanceButton.Height += 10;
                if (pnlAttendanceButton.Size == pnlAttendanceButton.MaximumSize)
                {
                    tmrAttendanceButton.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                pnlAttendanceButton.Height -= 10;
                if (pnlAttendanceButton.Size == pnlAttendanceButton.MinimumSize)
                {
                    tmrAttendanceButton.Stop();
                    isCollapsed = true;
                }
            }
        }


    }
}
