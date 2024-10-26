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

namespace csCY_Avenue.Staff_Interface.Main.StaffShopInterface
{
    public partial class frmViewTransactions : Form
    {
        private ItemInvoice itemInvoice;
        public frmViewTransactions(ItemInvoice itemInvoice)
        {
            InitializeComponent();
            this.itemInvoice = itemInvoice;
            loadShitAgainFFck();
        }

        private void loadShitAgainFFck()
        {
            // header
            lblInvoiceID.Text = itemInvoice.Id.ToString();
            lblInvoiceDate.Text = itemInvoice.RecordedAt.ToString("MMMM dd, yyyy");
            
            
            // prices
            lblMerchandiseTotal.Text = itemInvoice.Merchandise.ToString("#,##0.##");
            lblEquipmentTotal.Text = itemInvoice.Equipment.ToString("#,##0.##");
            lblSupplementTotal.Text = itemInvoice.Supplement.ToString("#,##0.##");
            lblDiscount.Text = (itemInvoice.Discount * 100).ToString("0") + "%";

            lblTotalAmountDue.Text = itemInvoice.TotalPrice.ToString("#,##0.##");


            // footer
            lblTransactionID.Text = itemInvoice.Id.ToString();
            lblPaymentDate.Text = itemInvoice.RecordedAt.ToString("MMMM dd, yyyy"); 
        }
        
        
        //X
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
