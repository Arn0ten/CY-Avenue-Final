using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using csCY_Avenue.Canedo.backend.entities;
using csCY_Avenue.Custom;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmViewInvoiceInformation : Form
    {
        public string MembershipType { get; set; }
        public MembershipPending pending;
        private fncControl Control;


        public frmViewInvoiceInformation(MembershipPending pending)
        {
            InitializeComponent();
            this.pending = pending;
            Control = new fncControl();
            Load += FrmViewInvoiceInformation_Load;
        }

        // Event handler for the form's Load event
        private void FrmViewInvoiceInformation_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        
        public void LoadForm()
        {
            string status = pending.status ? "PAID" : "UNPAID";

            // Proper null check for nullable integer
            lblInvoiceID.Text = pending.Id.HasValue ? pending.Id.Value.ToString() : "N/A";
            lblMemberName.Text = pending.member_name ?? "N/A";
            lblMembershipID.Text = pending.membership_id.ToString();
            lblInvoiceDate.Text = pending.create_at.ToString("MMMM dd, yyyy");
            lblStatus.Text = status;

            lblPrice.Text = pending.price.ToString("F2");
            lblMembershipType.Text = pending.membership_type?.ToUpper() ?? "UNKNOWN";
            lblTotalAmountDue.Text = pending.price.ToString("F2");
        }
        
        
        // X (Close)
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Pay
        private void btnInvoicePay_Click(object sender, EventArgs e)
        {
            this.Close();
            // var formPay = new frmPay();
            // formPay.MembershipType = MembershipType;
            // Control.blurOverlay(formPay);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        
        
        // NA PISLIT :<
        private void guna2HtmlLabel11_Click(object sender, EventArgs e)
        {

        }
    }

}
