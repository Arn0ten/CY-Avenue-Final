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

namespace csCY_Avenue.Staff_Interface.Main.StaffShopInterface
{
    public partial class frmStaffShopMain : Form
    {
        fncControl Control;
        frmShopForm ShopMainForm = new frmShopForm();
        frmShopPerksOverview ShopPerksOverview = new frmShopPerksOverview();


        public frmStaffShopMain()
        {
            InitializeComponent();
            Control = new fncControl();
            Control.LoadFormInPanel(pnlDisplay, ShopMainForm);
        }

        private void btnShopManagement_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, ShopMainForm);
        }

        private void btnPerksOverview_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, ShopPerksOverview);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
