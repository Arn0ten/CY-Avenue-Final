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
    public partial class frmShopBuyItem : Form
    {
        fncControl Control;
        public frmShopBuyItem()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        //X
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Back
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            var FormShopCheckBuyer = new frmShopCheckBuyer();
            FormShopCheckBuyer.Show();
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            this.Close();
            var FormPurchase = new frmPurchase();
            Control.blurOverlay(FormPurchase);
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

        }
    }
}
