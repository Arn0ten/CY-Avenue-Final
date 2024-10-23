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
            double totalBasic = 0, totalVip = 0, totalWalkIn = 0;
            
            foreach (var sale in _sales)
            {
                switch (sale.ItemCategory)
                {
                    case "Merchandise":
                        totalBasic += sale.ItemTotalSales ?? 0;
                        break;
                    case "Equipment":
                        totalVip += sale.ItemTotalSales ?? 0;
                        break;
                    case "Supplement":
                        totalWalkIn += sale.ItemTotalSales ?? 0;
                        break;
                }
            }
            Console.WriteLine(totalBasic);
            Console.WriteLine(totalVip);
            Console.WriteLine(totalWalkIn);
            
            // FORMAT ALL THE SHITS
            lblTotalMerchandise.Text = totalBasic.ToString();
            lblTotalGear.Text = totalVip.ToString();
            lblTotalSuplements.Text = totalWalkIn.ToString();
            // total revenue
            lblTotalRevenueReported.Text = (totalBasic +  totalVip + totalWalkIn).ToString();
            // from -> to
            lblDateFrom.Text = _from.ToString("MMMM, dd yyyy");
            lblDateTo.Text = _to.ToString("MMMM, dd yyyy");
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
