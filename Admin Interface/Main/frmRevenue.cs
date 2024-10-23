using csCY_Avenue.Custom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarlosYulo;
using CarlosYulo.backend.entities;
using CarlosYulo.backend.monolith.revenue;
using CarlosYulo.preload;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmRevenue : Form
    {
        private RevenueController _revenueController;
        private List<MembershipSale> membershipSales = PreloadRevenueData.MembershipSales;
        private List<MembershipSale> filtedMembershipSales = PreloadRevenueData.MembershipSales;
        fncControl Control;


        public frmRevenue()
        {
            InitializeComponent();
            Control = new fncControl();
            _revenueController = ServiceLocator.GetService<RevenueController>();
            membershipSales = PreloadRevenueData.MembershipSales;
            Load += frmRevenue_Load;
        }

        private void frmRevenue_Load(object sender, EventArgs e)
        {
            LoadRevenueGrid();
        }

        //
        private void AutoLoadNewMembersRevenue()
        {
            PreloadAttendanceData.PreLoadAttendanceAll();
            membershipSales = PreloadRevenueData.MembershipSales;
            LoadRevenueGrid();
        }


        // LOAD THIS SHIT
        private void LoadRevenueGrid()
        {
            dgvRevenue.Rows.Clear(); // Clear the existing rows
            double totalshit = 0;

            foreach (var staff in membershipSales)
            {
                int rowIndex = dgvRevenue.Rows.Add();
                DataGridViewRow row = dgvRevenue.Rows[rowIndex];

                totalshit += staff.price ?? 0;

                row.Cells["clmTransactionDate"].Value = staff.sold_at?.ToString("yyyy MMMM dd");
                row.Cells["clmMemberName"].Value = staff.member_name;
                row.Cells["clmType"].Value = staff.membership_type;
                row.Cells["clmAmount"].Value = staff.price;
            }

            lblTotalRevenue.Text = totalshit.ToString("C2", new System.Globalization.CultureInfo("en-PH"));
        }

        // LOAD FILTERED DATAGRID
        public void LoadFilteredRevenueGrid(List<MembershipSale> attendance)
        {
            dgvRevenue.Rows.Clear(); // Clear the existing rows
            double totalshit = 0;

            foreach (var staff in attendance)
            {
                int rowIndex = dgvRevenue.Rows.Add();
                DataGridViewRow row = dgvRevenue.Rows[rowIndex];

                totalshit += staff.price ?? 0;

                row.Cells["clmTransactionDate"].Value = staff.sold_at?.ToString("yyyy MMMM dd");
                row.Cells["clmMemberName"].Value = staff.member_name;
                row.Cells["clmType"].Value = staff.membership_type;
                row.Cells["clmamount"].Value = staff.price;
            }

            lblTotalRevenue.Text = totalshit.ToString("C2", new System.Globalization.CultureInfo("en-PH"));
        }


        private void btnPrintRevenue_Click(object sender, EventArgs e)
        {
            if (filtedMembershipSales == null)
            {
                MessageBox.Show("No revenues rows founded");
                return;
            }

            var FormRevenueReport = new frmRevenueReport(filtedMembershipSales, dtFrom.Value, dtTo.Value);
            Control.blurOverlay(FormRevenueReport);
        }

        private void btnFilterGymRevenue_Click(object sender, EventArgs e)
        {
            var result = _revenueController.SearchMemberRevenueBetweenDays(dtFrom.Value, dtTo.Value);
            LoadFilteredRevenueGrid(result);
            filtedMembershipSales = result;
        }

        // NA PINDOT RANI
        private void dgvRevenue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}