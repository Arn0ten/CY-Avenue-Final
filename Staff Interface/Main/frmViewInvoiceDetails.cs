
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

namespace csCY_Avenue.Staff_Interface
{
    public partial class frmViewInvoiceDetails : Form
    {
        public string MembershipType { get; set; }
        fncControl Control;

        public frmViewInvoiceDetails()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        //Pay
        private void btnInvoicePay_Click(object sender, EventArgs e)
        {
            this.Close();
            var formPay = new frmPay();
            formPay.MembershipType = MembershipType;
            Control.blurOverlay(formPay);
        }

        //X
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
