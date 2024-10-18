
using csCY_Avenue.Custom;
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

namespace csCY_Avenue.Staff_Interface.Main
{
    public partial class frmStaffBillingAndTransactions : Form
    {
        fncControl Control;
        public frmStaffBillingAndTransactions()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        private void frmStaffBillingAndTransactions_Load(object sender, EventArgs e)
        {
            update();
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
                string customerType = selectedRow.Cells["MembershipType"].Value.ToString();
                var formViewInvoiceInformation = new frmViewInvoiceDetails();
                formViewInvoiceInformation.MembershipType = customerType;
                Control.blurOverlay(formViewInvoiceInformation);
            }
            else if (e.ColumnIndex == 6)
            {
                var selectedRow = dgvInvoice.Rows[e.RowIndex];
                string customerType = selectedRow.Cells["MembershipType"].Value.ToString();
                var FormPay = new frmPay();
                FormPay.MembershipType = customerType;
                Control.blurOverlay(FormPay);
            }
        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            var FormGenerateInvoice = new frmGenerateInvoice();
            Control.blurOverlay(FormGenerateInvoice);
        }
    }
}
