using csCY_Avenue.Admin_Interface.Main;
using csCY_Avenue.Custom;
using csCY_Avenue.Staff_Interface.Main.StaffShopInterface;
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
    public partial class frmPurchase : Form
    {
        fncControl Control;
        frmPaidPurchase PaidPurchaseForm = new frmPaidPurchase();
        public frmPurchase()
        {
            InitializeComponent();
            Control = new fncControl();
        }


        //X
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Purchase
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            this.Close();
            var FormPaidPurchase = new frmPaidPurchase();
            Control.blurOverlay(FormPaidPurchase);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            var FormBuyItem = new frmShopBuyItem();
            FormBuyItem.Show();
        }
    }
}
