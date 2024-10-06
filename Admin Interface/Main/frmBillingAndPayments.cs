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

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmBillingAndPayments : Form
    {
        public frmBillingAndPayments()
        {
            InitializeComponent();
        }

        private void frmBillingAndPayments_Load(object sender, EventArgs e)
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
            if (e.ColumnIndex==6)
            {
                var FormViewInvoiceInformation = new frmViewInvoiceInformation();
                blurOverlay(FormViewInvoiceInformation);
            }else if (e.ColumnIndex == 5)
            {
                var FormPay = new frmPay();

                blurOverlay(FormPay);
            }
        }

        // Blur Dialog
        public void blurOverlay(Form formDialog, Color backgroundColor = default)
        {
            var overlayForm = new Form
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = 0.5d,
                BackColor = backgroundColor == default ? Color.Black : backgroundColor,
                Size = new Size(1366, 768),
                Location = new Point(0, 0),
                ShowInTaskbar = false,
                TopMost = true
            };
            overlayForm.Show();
            formDialog.Owner = overlayForm;
            formDialog.TopMost = true;
            formDialog.ShowDialog();
            overlayForm.Dispose();

        }
    }
}
