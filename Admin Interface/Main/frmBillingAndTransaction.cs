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
            row.Add("Unpaid");
            dgvInvoice.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1234");
            row.Add("sdfsd");
            row.Add("P90");
            row.Add("02/27/2002");
            row.Add("Unpaid");
            dgvInvoice.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1234");
            row.Add("sdfdsf");
            row.Add("P90");
            row.Add("02/27/2002");
            row.Add("Unpaid");
            dgvInvoice.Rows.Add(row.ToArray());

            row.Add("1234");
            row.Add("Arneabell");
            row.Add("P90");
            row.Add("02/27/2002");
            row.Add("Unpaid");
            dgvInvoice.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1234");
            row.Add("sdfsd");
            row.Add("P90");
            row.Add("02/27/2002");
            row.Add("Unpaid");
            dgvInvoice.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1234");
            row.Add("sdfdsf");
            row.Add("P90");
            row.Add("02/27/2002");
            row.Add("Unpaid");
            dgvInvoice.Rows.Add(row.ToArray());

        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                var FormViewInvoiceInformation = new frmViewInvoiceInformation();
                Control.blurOverlay(FormViewInvoiceInformation);
            }
            else if (e.ColumnIndex == 5)
            {
                var FormPay = new frmPay();
                Control.blurOverlay(FormPay);
            }
        }

        private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
