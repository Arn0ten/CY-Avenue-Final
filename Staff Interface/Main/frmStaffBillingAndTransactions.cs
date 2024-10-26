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
using System.Windows.Forms.VisualStyles;
using CarlosYulo.preload;
using csCY_Avenue.Admin_Interface.Main;
using csCY_Avenue.Canedo.backend.entities;

namespace csCY_Avenue.Staff_Interface.Main
{
    public partial class frmStaffBillingAndTransactions : Form
    {
        private List<MembershipPending> MembershipPendingSales = PreloadPayPending.MembershipPendingSales;
        fncControl Control;

        public frmStaffBillingAndTransactions()
        {
            InitializeComponent();
            Control = new fncControl();
            Load += frmStaffBillingAndTransactions_Load;
            dgvInvoice.CellPainting += dgvInvoice_CellClick;
        }

        private void frmStaffBillingAndTransactions_Load(object sender, EventArgs e)
        {
            LoadPendingSales();
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
                    pending.status ? "Paid" : "Unpaid"
                );
            }
        }




        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (!MembershipPendingSales[e.RowIndex].status)
                {
                    MessageBox.Show("Membership has not yet completed their payment!", "Can't view invoice",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                var formViewInvoiceInformation = new frmViewInvoiceInformation(MembershipPendingSales[e.RowIndex]);
                Control.blurOverlay(formViewInvoiceInformation);
            }
            else if (e.ColumnIndex == 5)
            {
                if (MembershipPendingSales[e.RowIndex].status)
                {
                    MessageBox.Show("Member has already completed the payment for their membership!", "Paid",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                var FormPay = new frmPay(MembershipPendingSales[e.RowIndex]);
                Control.blurOverlay(FormPay);

                if (FormPay.success)
                {
                    var selectedPending = (MembershipPendingSales[e.RowIndex]);
                    selectedPending.status = true;
                    LoadPendingSales();
                }
            }
            // else if (e.ColumnIndex == 7)
            // {
            //     //   _revenueController.
            //
            //
            //     var FormPay = new frmPay(MembershipPendingSales[e.RowIndex]);
            //     Control.blurOverlay(FormPay);
            // }
        }


        //Design para sa mga member type aron mo achop
        private void dgvInvoice_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvInvoice.Columns[e.ColumnIndex].Name == "MembershipType")
            {
                if (e.Value != null)
                {
                    string cellValue = e.Value.ToString();
                    e.CellStyle.Font = new Font("Nirmala UI", 10, FontStyle.Bold);


                    switch (cellValue)
                    {
                        case "VIP":
                            e.CellStyle.ForeColor = Color.DarkOrange;
                            break;
                        case "Basic":
                            e.CellStyle.ForeColor = Color.DarkBlue;
                            break;
                        case "Walk-in":
                            e.CellStyle.ForeColor = Color.Gray;
                            break;
                        default:
                            e.CellStyle.ForeColor = Color.Black;
                            break;
                    }
                }
            }
        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dgvInvoice.Columns["Pay"].Index && e.RowIndex >= 0)
            {
                string cellValue = e.Value.ToString();
                e.CellStyle.Font = new Font("Nirmala UI", 9, FontStyle.Bold);
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var buttonRect = e.CellBounds;
                buttonRect.Inflate(-2, -2);
                ButtonRenderer.DrawButton(e.Graphics, buttonRect, PushButtonState.Normal);
                e.Graphics.FillRectangle(Brushes.Green, buttonRect);
                TextRenderer.DrawText(e.Graphics, "Pay", e.CellStyle.Font, buttonRect, Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                e.Handled = true;
            }
            else if (e.ColumnIndex == dgvInvoice.Columns["View"].Index && e.RowIndex >= 0)
            {
                string cellValue = e.Value.ToString();
                e.CellStyle.Font = new Font("Nirmala UI", 9, FontStyle.Bold);
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var buttonRect = e.CellBounds;
                buttonRect.Inflate(-2, -2);
                ButtonRenderer.DrawButton(e.Graphics, buttonRect, PushButtonState.Normal);
                e.Graphics.FillRectangle(Brushes.Blue, buttonRect);
                TextRenderer.DrawText(e.Graphics, "View", e.CellStyle.Font, buttonRect, Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                e.Handled = true;
            }
        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            var FormGenerateInvoice = new frmGenerateInvoice();
            Control.blurOverlay(FormGenerateInvoice);

            PreloadPayPending.PreUnpaidLoad();
            MembershipPendingSales = PreloadPayPending.MembershipPendingSales;
            LoadPendingSales();
        }


    }
}