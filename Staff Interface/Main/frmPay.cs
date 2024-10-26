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
using CarlosYulo;
using CarlosYulo.backend.entities;
using CarlosYulo.backend.monolith.client;
using CarlosYulo.backend.monolith.revenue;
using CarlosYulo.preload;
using csCY_Avenue.Admin_Interface.Main;
using csCY_Avenue.Canedo.backend.entities;
using csCY_Avenue.Database;

namespace csCY_Avenue.Staff_Interface.Main
{
    public partial class frmPay : Form
    {
        fncControl Control;

        public string MembershipType { get; set; }
        public MembershipPending _membershipPending;
        private RevenueController _revenueController;
        private ClientController _clientController;
        public bool success;

        //Global procedure para sa notif
        private GlobalProcedure globalProcedure;
        private fncNotificationService notificationService;
        private frmNotifications _frmNotifications;


        public frmPay(MembershipPending membershipPending)
        {
            InitializeComponent();
            Control = new fncControl();
            _membershipPending = membershipPending;
            _revenueController = ServiceLocator.GetService<RevenueController>();
            _clientController = ServiceLocator.GetService<ClientController>();
            Load += FrmPay_Load;
            success = false;

            //Instance sa notif
            globalProcedure = new GlobalProcedure();
            notificationService = new fncNotificationService(globalProcedure);
            _frmNotifications = new frmNotifications();
        }

        private void FrmPay_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        public void LoadForm()
        {
            // Proper null check for nullable integer
            txtInvoiceID.Text = _membershipPending.Id.HasValue ? _membershipPending.Id.Value.ToString() : "N/A";
            txtMemberName.Text = _membershipPending.member_name ?? "N/A";
            txtMembershipID.Text = _membershipPending.membership_id.ToString();
            txtAmountPaid.Text = _membershipPending.price.ToString("0.00");
        }

        //Pay
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
            if (!_revenueController.UpdateMembershipRecordToTrue(_membershipPending.membership_id))
            {
                return;
            }

            var memberSaleReport = _revenueController.GenerateMembershipSales(newMember, MembershipSaleType.NEW_MEMBER);
            if (memberSaleReport == null)
            {
                return;
            }

            //else
            PreloadRevenueData.PreLoadMemberRevenue();

            //crystal report
            var formPaidInvoice = new frmPaidInvoice(_clientController, memberSaleReport, newMember, paymentMethod,
                dtTransactionDate.Value);
            formPaidInvoice.SetMembershipType(MembershipType);
            Control.blurOverlay(formPaidInvoice);

            //Add notif
            notificationService.AddNotification("Payment",
                $"Payment has been successfully received from '{txtMemberName.Text}'. ", txtMemberName.Text);
            MessageBox.Show($"Payment has been successfully completed for {txtMemberName.Text}. Thank you!",
                "Payment Completed!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            success = true;
        }

        //Cancel
        private void btnCancelPayment_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}