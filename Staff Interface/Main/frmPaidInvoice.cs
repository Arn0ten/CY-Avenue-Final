using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarlosYulo.backend;
using CarlosYulo.backend.entities;
using CarlosYulo.backend.monolith.client;

namespace csCY_Avenue.Staff_Interface.Main
{
    public partial class frmPaidInvoice : Form
    {
        private MembershipSale _membershipSale;
        private ClientController _clientController;
        private Client _newMember;
        private string _paymentMethod;
        private DateTime _transactionDate;

        public frmPaidInvoice(ClientController clientController, MembershipSale MembershipSale, Client newMember,
            string paymentMethod, DateTime transactionDate)
        {
            InitializeComponent();
            _membershipSale = MembershipSale;
            _clientController = clientController;
            _newMember = newMember;
            _paymentMethod = paymentMethod;
            _transactionDate = transactionDate;
            Load += FrmPaidInvoice_Load;
        }

        private void FrmPaidInvoice_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        public void LoadForm()
        {
            // Proper null check for nullable integer
            lblInvoiceID.Text = _membershipSale.Id.HasValue ? _membershipSale.Id.Value.ToString() : "N/A";
            lblMemberName.Text = _membershipSale.member_name ?? "N/A";
            lblMembershipID.Text = _membershipSale.member_id.ToString();
            lblInvoiceDate.Text = _membershipSale.sold_at?.ToString("MMMM dd, yyyy");

            lblTotalAmount.Text = _membershipSale.price?.ToString("F2");
            lblMembershipType.Text = _membershipSale.membership_type?.ToUpper() ?? "UNKNOWN";
            lblTotalAmountDue.Text = _membershipSale.price?.ToString("F2");

            lblTransactionID.Text = _membershipSale.Id.HasValue ? _membershipSale.Id.Value.ToString() : "N/A";
            lblPaymentMethod.Text = _paymentMethod;
            lblPaymentDate.Text = _membershipSale.sold_at?.ToString("MMMM dd, yyyy");
        }


        // Method to set the membership type on the label
        public void SetMembershipType(string customerType)
        {
            lblMembershipType.Text = customerType;
        }

        //Class
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWelcomeEmail_Click(object sender, EventArgs e)
        {
            if (_newMember == null)
            {
                return;
            }

            MessageBox.Show("Welcome email has been successfully sent.", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _clientController.SendEmail(_newMember, EmailType.WELCOME_NEW_MEMBER);
        }
    }
}