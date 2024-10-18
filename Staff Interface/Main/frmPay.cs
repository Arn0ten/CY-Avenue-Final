
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
    public partial class frmPay : Form
    {
        fncControl Control;
        public string MembershipType { get; set; }
        public frmPay()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        //Pay
        private void btnSubmitPayment_Click(object sender, EventArgs e)
        {
            this.Close();
            var formPaidInvoice = new frmPaidInvoice();
            formPaidInvoice.SetMembershipType(MembershipType);
            Control.blurOverlay(formPaidInvoice);
        }

        //Cancel
        private void btnCancelPayment_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
