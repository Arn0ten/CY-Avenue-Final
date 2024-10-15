using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using csCY_Avenue.Custom;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmPay : Form
    {
        private fncControl Control;
        public string MembershipType { get; set; } 
        public frmPay()
        {
            InitializeComponent();
            Control = new fncControl();
        }
        

        //Cancel
        private void btnCancelPayment_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Submit
        private void btnSubmitPayment_Click(object sender, EventArgs e)
        {
            this.Close();
            var FormPainInvoice = new frmPaidInvoice();
            Control.blurOverlay(FormPainInvoice);
        }

    }
}
