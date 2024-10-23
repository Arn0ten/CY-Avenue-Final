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

namespace csCY_Avenue.Admin_Interface.Main.AdminShopInterface
{
    public partial class frmShopRevenue : Form
    {
        private RevenueController _revenueController;
        private List<ItemSales> itemSales = PreloadRevenueData.ItemSales;
        private List<ItemSales> filteditemSales = PreloadRevenueData.ItemSales;

        fncControl Control;

        public frmShopRevenue()
        {
            InitializeComponent();
            Control = new fncControl();
            _revenueController = ServiceLocator.GetService<RevenueController>();
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
            itemSales = PreloadRevenueData.ItemSales;
            LoadRevenueGrid();
        }


        private void LoadRevenueGrid()
        {
            dgvShopRevenue.Rows.Clear(); // Clear the existing rows
            double totalshit = 0;

            foreach (var sales in itemSales)
            {
                totalshit += sales.ItemTotalSales ?? 0;


                int rowIndex = dgvShopRevenue.Rows.Add();
                DataGridViewRow row = dgvShopRevenue.Rows[rowIndex];

                row.Cells["clmTransactionDate"].Value = sales.ItemSaleDate?.ToString("MMMM dd yyyy");
                row.Cells["clmProduct"].Value = sales.ItemName;
                row.Cells["clmCategory"].Value = sales.ItemCategory;
                row.Cells["clmOriginalPrice"].Value = sales.ItemPriceSold;
                row.Cells["clmQuantity"].Value = sales.ItemQuantitiesSold;
                row.Cells["clmTotalSales"].Value = sales.ItemTotalSales;
            }

            lblTotalRevenue.Text = totalshit.ToString("C2", new System.Globalization.CultureInfo("en-PH"));
        }


        // LOAD FILTERED DATAGRID
        public void LoadFilteredRevenueGrid(List<ItemSales> attendance)
        {
            dgvShopRevenue.Rows.Clear(); // Clear the existing rows
            double totalshit = 0;

            foreach (var sales in attendance)
            {
                totalshit += sales.ItemTotalSales ?? 0;

                int rowIndex = dgvShopRevenue.Rows.Add();
                DataGridViewRow row = dgvShopRevenue.Rows[rowIndex];

                row.Cells["clmTransactionDate"].Value = sales.ItemSaleDate?.ToString("MMMM dd yyyy");
                row.Cells["clmProduct"].Value = sales.ItemName;
                row.Cells["clmCategory"].Value = sales.ItemCategory;
                row.Cells["clmOriginalPrice"].Value = sales.ItemPriceSold;
                row.Cells["clmQuantity"].Value = sales.ItemQuantitiesSold;
                row.Cells["clmTotalSales"].Value = sales.ItemTotalSales;
            }

            lblTotalRevenue.Text = totalshit.ToString("C2", new System.Globalization.CultureInfo("en-PH"));
        }


        private void btnPrintRevenue_Click(object sender, EventArgs e)
        {
            if (filteditemSales == null)
            {
                MessageBox.Show("No revenues rows founded");
                return;
            }

            var FormShopRevenueReport = new frmShopRevenueReport(filteditemSales, dtFrom.Value, dtTo.Value);
            Control.blurOverlay(FormShopRevenueReport);
        }

        private void btnFilterItemRevenue_Click(object sender, EventArgs e)
        {
            if (dtFrom.Value.Date > dtTo.Value.Date)
            {
                MessageBox.Show("Date end should not beforehand.");
                return;
            }

            var result = _revenueController.SearchItemSalesBetweenDays(dtFrom.Value, dtTo.Value);
            LoadFilteredRevenueGrid(result);
            filteditemSales = result;
        }
    }
}