using System;
using System.Collections;
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
    public partial class frmBillingAndTransaction : Form
    {
        private fncControl Control;

        public frmBillingAndTransaction()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        private void frmBillingAndPayments_Load(object sender, EventArgs e)
        {
            update();
        }

        //Generate
        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            var FormGenerateInvoice = new frmGenerateInvoice();
            Control.blurOverlay(FormGenerateInvoice);
        }
        private void update()
        {

            ArrayList row = new ArrayList();
            row.Add("1234");
            row.Add("Arneabell");
            row.Add("P90");
            row.Add("02/27/2002");
            row.Add("Walk-In");
            row.Add("Unpaid");
            dgvInvoice.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1234");
            row.Add("sdfsd");
            row.Add("P90");
            row.Add("02/27/2002");
            row.Add("Regular");
            row.Add("Unpaid");
            dgvInvoice.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1234");
            row.Add("sdfdsf");
            row.Add("P90");
            row.Add("02/27/2002");
            row.Add("Walk-In");
            row.Add("Unpaid");
            dgvInvoice.Rows.Add(row.ToArray());

            row.Add("1234");
            row.Add("Arneabell");
            row.Add("P90");
            row.Add("02/27/2002");
            row.Add("Regular");
            row.Add("Unpaid");
            dgvInvoice.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1234");
            row.Add("sdfsd");
            row.Add("P90");
            row.Add("02/27/2002");
            row.Add("Walk-In");
            row.Add("Unpaid");
            dgvInvoice.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1234");
            row.Add("sdfdsf");
            row.Add("P90");
            row.Add("02/27/2002");
            row.Add("VIP");
            row.Add("Unpaid");
            dgvInvoice.Rows.Add(row.ToArray());

        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                var selectedRow = dgvInvoice.Rows[e.RowIndex];
                string customerType = selectedRow.Cells["MembershipType"].Value.ToString(); // Get MembershipType

                var formViewInvoiceInformation = new frmViewInvoiceInformation();
                formViewInvoiceInformation.MembershipType = customerType; // Pass MembershipType
                Control.blurOverlay(formViewInvoiceInformation);
            }
            else if (e.ColumnIndex == 6)
            {
                var selectedRow = dgvInvoice.Rows[e.RowIndex];

                // Check the membership type (assuming "MembershipType" is the correct column name)
                string customerType = selectedRow.Cells["MembershipType"].Value.ToString(); // Adjust the cell name as necessary

                // Create and show the frmPay
                var FormPay = new frmPay();
                FormPay.MembershipType = customerType; // Set the membership type before showing the form
                Control.blurOverlay(FormPay);
            }
        }

        private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
