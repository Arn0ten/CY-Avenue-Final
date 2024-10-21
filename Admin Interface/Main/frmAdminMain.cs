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
using CarlosYulo.preload;
using CarlosYulo.backend;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmAdminMain : Form
    {
        private List<Client> clients = PreloadData.Clients;
        private List<Employee> trainers = PreloadData.Employees;


        private fncControl Control;
        private bool isCollapsed;
        private frmStart FormWelcome;
        frmDashboard DashboardForm = new frmDashboard();
        frmRevenue RevenueForm = new frmRevenue();
        frmSystemManagement SystemManagementForm = new frmSystemManagement();
        frmMemberManagement CustomerManagementForm = new frmMemberManagement();
        frmstaffManagement StaffManagementForm = new frmstaffManagement();
        frmTrainerManagement TrainerManagementForm = new frmTrainerManagement();
        frmAttendanceMember MembersAttendanceForm = new frmAttendanceMember();
        frmAttendanceStaff StaffsAttendanceForm = new frmAttendanceStaff();
        frmAttendanceTrainer TrainersAttendanceForm = new frmAttendanceTrainer();
        frmClassesAndSchedule ClassesAndScheduleForm = new frmClassesAndSchedule();
        frmBillingAndTransaction BillingAndTransactionForm = new frmBillingAndTransaction();
        frmShopManagement ShopManagementForm = new frmShopManagement();
        frmShopPerksOverview ShopPerksOverviewForm = new frmShopPerksOverview();
        frmNotifications NotificationsForm = new frmNotifications();
        AdminShopInterface.frmAdminShopMain AdminShopManagementForm = new AdminShopInterface.frmAdminShopMain();


        public frmAdminMain()
        {
            InitializeComponent();
            FormWelcome = new frmStart();
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

        private void btnBillingAndNotifications_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, BillingAndTransactionForm);
        }
        private void btnShop_Click(object sender, EventArgs e)
        {
            AdminShopManagementForm.ShowDialog();
        }
        private void btnWelcomeAdmin_Click(object sender, EventArgs e)
        {
            SystemManagementForm.ShowDialog();
        }
        private void btnPerksOverview_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, ShopPerksOverviewForm);
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, NotificationsForm);
        }
        private void btnAttendanceMember_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, MembersAttendanceForm);
        }

        private void btnAttendanceStaff_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, StaffsAttendanceForm);
        }

        private void btnAttendanceTrainer_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, TrainersAttendanceForm);
        }



        //Dropdown Management
        private void btnManagement_Click(object sender, EventArgs e)
        {
            tmrManagementButton.Start();
        }

        //Dropdown Attendance
        private void btnAttendance_Click(object sender, EventArgs e)
        {
            tmrAttendanceButton.Start();
        }

        //Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            frmStart StartForm = new frmStart();
            StartForm.Show();
            this.Hide();
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
        //Na pindot
        private void pnlDisplay_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}

