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

namespace csCY_Avenue.Staff_Interface.Main.StaffShopInterface
{
    public partial class frmShopRevenue : Form
    {
        fncControl Control;

        private RevenueController _revenueController;
        private List<ItemSales> itemSales = PreloadRevenueData.ItemPendingSales;
        private List<ItemSales> filteditemSales = PreloadRevenueData.ItemPendingSales;

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

        private void LoadRevenueGrid()
        {
            dgvShopRevenue.Rows.Clear(); 
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
            dgvShopRevenue.Rows.Clear(); 
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


        private void btnPrintRevenue_Click(object sender, EventArgs e)
        {
            if (filteditemSales == null)
            {
                MessageBox.Show("No revenues rows founded");
                return;
            }

            var RevenueReport = new frmShopRevenueReport(filteditemSales, dtFrom.Value, dtTo.Value);
            Control.blurOverlay(RevenueReport);
        }

        private void dgvShopRevenue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnFilterItemRevenue_Click_1(object sender, EventArgs e)
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