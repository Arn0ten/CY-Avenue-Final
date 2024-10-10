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

namespace csCY_Avenue.Admin_Interface.Main.AdminShopInterface
{
    public partial class frmMain : Form
    {
        fncControl Control;
        frmShopPerksOverview ShopPerksOverviewForm = new frmShopPerksOverview();
        frmShopManagement ShopManagement = new frmShopManagement();
        public frmMain()
        {
            InitializeComponent();
            Control = new fncControl();
            Control.LoadFormInPanel(pnlDisplay, ShopManagement);
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnShopRevenue_Click(object sender, EventArgs e)
        {

        }

        private void btnShopManagement_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, ShopManagement);
        }

        private void btnShopBillingAndTransactions_Click(object sender, EventArgs e)
        {

        }

        private void btnPerksOverview_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, ShopPerksOverviewForm);
        }
    }
}
