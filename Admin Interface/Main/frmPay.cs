using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarlosYulo;
using CarlosYulo.backend;
using CarlosYulo.backend.entities;
using CarlosYulo.backend.monolith.client;
using CarlosYulo.backend.monolith.revenue;
using CarlosYulo.preload;
using csCY_Avenue.Canedo.backend.entities;
using csCY_Avenue.Custom;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmPay : Form
    {
        private fncControl Control;
        public string MembershipType { get; set; }
        public MembershipPending _membershipPending;
        private RevenueController _revenueController;
        private ClientController _clientController;
        public bool success;


        public frmPay(MembershipPending membershipPending)
        {
            InitializeComponent();
            Control = new fncControl();
            _membershipPending = membershipPending;
            _revenueController = ServiceLocator.GetService<RevenueController>();
            _clientController = ServiceLocator.GetService<ClientController>();
            Load += FrmPay_Load;
            success = false;
        }

        private void FrmPay_Load(object sender, EventArgs e)
        {
            LoadForm();
        }


        public void LoadForm()
        {
            string status = _membershipPending.status ? "PAID" : "UNPAID";

            // Proper null check for nullable integer
            txtInvoiceID.Text = _membershipPending.Id.HasValue ? _membershipPending.Id.Value.ToString() : "N/A";
            txtMemberName.Text = _membershipPending.member_name ?? "N/A";
            txtMembershipID.Text = _membershipPending.membership_id.ToString();
            txtAmountPaid.Text = _membershipPending.price.ToString("0.00");
        }


        //Cancel
        private void btnCancelPayment_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Submit
        private void btnSubmitPayment_Click(object sender, EventArgs e)
        {
            Close();
            string paymentMethod = cmbPaymentMethod.GetItemText(cmbPaymentMethod.SelectedItem);

            var newMember = _clientController.SearchById(_membershipPending.membership_id);
            if (newMember == null)
            {
                return;
            }

            Console.WriteLine("Payment Method: " + _membershipPending.membership_id);
            var memberSaleReport = _revenueController.GenerateMembershipSales(newMember, MembershipSaleType.NEW_MEMBER);
            _revenueController.UpdateMembershipRecordToTrue(_membershipPending.membership_id);

            if (memberSaleReport == null)
            {
                return;
            }

            //else
            PreloadRevenueData.PreLoadMemberRevenue();

            //crystal report
            var formPaidInvoice = new frmPaidInvoice(_clientController, memberSaleReport, newMember, paymentMethod, dtTransactionDate.Value);
            formPaidInvoice.SetMembershipType(MembershipType);
            Control.blurOverlay(formPaidInvoice);

            success = true;
        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}