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
        StaffShopInterface.frmStaffShopMain StaffShopInterface = new StaffShopInterface.frmStaffShopMain();
        public frmStaffMain()
        {
            InitializeComponent();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            StaffShopInterface.ShowDialog();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {

        }

        private void btnClassesAndManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnAttendanceTracking_Click(object sender, EventArgs e)
        {

        }

        private void btnBillingAndTransactions_Click(object sender, EventArgs e)
        {

        }

        private void btnPerksOverview_Click(object sender, EventArgs e)
        {

        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
