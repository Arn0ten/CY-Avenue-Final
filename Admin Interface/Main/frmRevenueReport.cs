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

namespace csCY_Avenue.Admin_Interface
{
    public partial class frmRevenueReport : Form
    {
        private List<MembershipSale>? _sales;
        private DateTime _from;
        private DateTime _to;

        public frmRevenueReport(List<MembershipSale> sales, DateTime from, DateTime to)
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
                switch (sale.membership_type)
                {
                    case "Basic":
                        totalBasic += sale.price.Value;
                        break;
                    case "VIP":
                        totalVip += sale.price.Value;
                        break;
                    case "Walk-in":
                        totalWalkIn += sale.price.Value;
                        break;
                }
            }
            Console.WriteLine(totalBasic);
            Console.WriteLine(totalVip);
            Console.WriteLine(totalWalkIn);
            
            // FORMAT ALL THE SHITS
            lblTotalRegular.Text = totalBasic.ToString();
            lblTotalVIP.Text = totalVip.ToString();
            lblTotalWalkIn.Text = totalWalkIn.ToString();
            // total revenue
            lblTotalRevenueReported.Text = (totalBasic +  totalVip + totalWalkIn).ToString();
            // from -> to
            lblDateFrom.Text = _from.ToString("MMMM/dd/yyyy");
            lblDateTo.Text = _to.ToString("MMMM/dd/yyyy");
        }

        private void frmRevenueReport_Load(object sender, EventArgs e)
        {
        }

        //Close
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}