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
    public partial class frmShopMainForm : Form
    {
        fncControl Control;
        public frmShopMainForm()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            var FormShopCheckBuyer= new frmShopCheckBuyer();
            Control.blurOverlay(FormShopCheckBuyer);
        }
    }
}
