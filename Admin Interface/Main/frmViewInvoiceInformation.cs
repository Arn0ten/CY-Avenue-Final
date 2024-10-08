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
    public partial class frmViewInvoiceInformation : Form
    {
        private fncControl Control;
        public frmViewInvoiceInformation()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        //X
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Pay
        private void btnInvoicePay_Click(object sender, EventArgs e)
        {
            this.Close();
            var FormPay = new frmPay();
            Control.blurOverlay(FormPay);

        }

    }
}
