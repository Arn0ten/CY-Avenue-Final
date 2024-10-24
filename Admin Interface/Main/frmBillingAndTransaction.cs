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
using CarlosYulo;
using CarlosYulo.backend;
using CarlosYulo.backend.monolith.revenue;
using CarlosYulo.backend.monolith.shop;
using CarlosYulo.preload;
using csCY_Avenue.Canedo.backend.entities;
using csCY_Avenue.Custom;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmBillingAndTransaction : Form
    {
        private List<MembershipPending> MembershipPendingSales = PreloadPayPending.MembershipPendingSales;

        private fncControl Control;

        public frmBillingAndTransaction()
        {
            InitializeComponent();
            Control = new fncControl();
            Load += frmBillingAndPayments_Load;
        }
        
        private void frmBillingAndPayments_Load(object sender, EventArgs e)
        {
            LoadPendingSales();
        }

        //Generate
        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            var FormGenerateInvoice = new frmGenerateInvoice();
            Control.blurOverlay(FormGenerateInvoice);
        }
        
        private void LoadPendingSales()
        {
            dgvInvoice.Rows.Clear();

            foreach (var pending in MembershipPendingSales)
            {
                dgvInvoice.Rows.Add(
                    pending.member_name,
                    pending.price,
                    pending.create_at.ToString("MMMM dd, yyyy"),
                    pending.membership_type,
                    pending.status
                );
            }
        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 7)
            {
                var formViewInvoiceInformation = new frmViewInvoiceInformation(MembershipPendingSales[e.RowIndex]);
                Control.blurOverlay(formViewInvoiceInformation);
            }
            else if (e.ColumnIndex == 6)
            {
                
                
                var FormPay = new frmPay(MembershipPendingSales[e.RowIndex]);
                Control.blurOverlay(FormPay);
            }
        }

        private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtSearchInvoice_TextChanged(object sender, EventArgs e)
        {
        }
    }
}