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
using System.Windows.Forms.VisualStyles;

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
            dgvInvoice.CellPainting += dgvInvoice_CellPainting;
        }

        private void frmShopTransactions_Load(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            dgvInvoice.Rows.Clear(); 

            foreach (var invoice in itemInvoices)
            {
                dgvInvoice.Rows.Add(
                    invoice.Id,
                    invoice.TotalPrice,
                    (invoice.Discount * 100).ToString("0.##") + "%",
                    invoice.RecordedAt.ToString("MMMM dd, yyyy"),
                    "Paid"
                );
            }
        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0) 
            {
                var selectedInvoice = itemInvoices[e.RowIndex];

                var FormViewTransaction = new frmViewTransactions(selectedInvoice);
                Control.blurOverlay(FormViewTransaction);
            }
        }


        private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dgvInvoice_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            string cellValue = e.Value.ToString();
            e.CellStyle.Font = new Font("Nirmala UI", 9, FontStyle.Bold);

            if (e.ColumnIndex == dgvInvoice.Columns["clmView"].Index && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var buttonRect = e.CellBounds;
                buttonRect.Inflate(-2, -2);
                ButtonRenderer.DrawButton(e.Graphics, buttonRect, PushButtonState.Normal);
                e.Graphics.FillRectangle(Brushes.Blue, buttonRect);
                TextRenderer.DrawText(e.Graphics, "View", e.CellStyle.Font, buttonRect, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                e.Handled = true;
            }
        }
    }
}