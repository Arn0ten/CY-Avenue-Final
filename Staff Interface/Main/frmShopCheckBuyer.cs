using csCY_Avenue.Custom;
using csCY_Avenue.Staff_Interface.Main;
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
    public partial class frmShopCheckBuyer : Form
    {
        fncControl Control;

        public frmShopCheckBuyer()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        //X
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnProceed_Click(object sender, EventArgs e)
        {
            this.Close();
            var FormBuyItem = new frmShopBuyItem();
            FormBuyItem.Show();
        }
    }
}
