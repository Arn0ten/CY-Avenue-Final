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
using CarlosYulo.preload;
using csCY_Avenue.Canedo.backend.entities;

namespace csCY_Avenue.Staff_Interface.Main.StaffShopInterface
{
    public partial class frmShopTransactions : Form
    {
        private List<ItemInvoice> itemInvoices;
        fncControl Control;

        public frmShopTransactions()
        {
            InitializeComponent();
            Control = new fncControl();
            PreloadRevenueData.PreLoadItemRevenue();
            itemInvoices = PreloadRevenueData.ItemInvoices;
        }

        private void frmShopTransactions_Load(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            dgvInvoice.Rows.Clear(); // Clear any existing rows

            foreach (var invoice in itemInvoices)
            {
                dgvInvoice.Rows.Add(
                    invoice.Id,
                    invoice.TotalPrice,
                    (invoice.Discount * 100).ToString("0.##") + "%", // Convert to percentage format
                    invoice.RecordedAt.ToString("MMMM dd, yyyy"),
                    "Paid"
                );
            }
        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0) // Ensure the click is on a valid row
            {
                var selectedInvoice = itemInvoices[e.RowIndex];

                var FormViewTransaction = new frmViewTransactions(selectedInvoice);
                Control.blurOverlay(FormViewTransaction);
            }
        }


        private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}