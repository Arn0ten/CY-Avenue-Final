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
    public partial class frmShopRevenue : Form
    {
        fncControl Control;
        public frmShopRevenue()
        {           
            InitializeComponent();
            Control = new fncControl();
        }

        private void btnPrintRevenue_Click(object sender, EventArgs e)
        {
            var FormShopRevenueReport = new frmShopRevenueReport();
            Control.blurOverlay(FormShopRevenueReport);
        }
    }
}
