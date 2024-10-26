using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarlosYulo.backend.entities;

namespace csCY_Avenue.Admin_Interface.Main.AdminShopInterface
{
    public partial class frmShopRevenueReport : Form
    { 
        private List<ItemSales>? _sales;
        private DateTime _from;
        private DateTime _to;
        public frmShopRevenueReport(List<ItemSales> sales, DateTime from, DateTime to)
        {
            InitializeComponent();
            _sales = sales;
            _from = from;
            _to = to;
            loadTotalRevenue();
        }
        
        private void loadTotalRevenue()
        {
            double totalMerchandise = 0, totalEquipment = 0, totalSupplement = 0;

            foreach (var sale in _sales)
            {
                switch (sale.ItemCategory)
                {
                    case "Merchandise":
                        totalMerchandise += sale.ItemTotalSales ?? 0;
                        break;
                    case "Equipment":
                        totalEquipment += sale.ItemTotalSales ?? 0;
                        break;
                    case "Supplement":
                        totalSupplement += sale.ItemTotalSales ?? 0;
                        break;
                }
            }

            Console.WriteLine(totalMerchandise);
            Console.WriteLine(totalEquipment);
            Console.WriteLine(totalSupplement);

            
            lblTotalMerchandise.Text = $"   {totalMerchandise:#,##0.00}";
            lblTotalGear.Text = $"   {totalEquipment:#,##0.00}";
            lblTotalSuplements.Text = $"  {totalSupplement:#,##0.00}";
            // total revenue
            lblTotalRevenueReported.Text = $"   {(totalMerchandise + totalEquipment + totalSupplement):#,##0.00}";
            // date range
            lblDateFrom.Text = _from.ToString("MMMM dd, yyyy");
            lblDateTo.Text = _to.ToString("MMMM dd, yyyy");
        }



        //X
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
