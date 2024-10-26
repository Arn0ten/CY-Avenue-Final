using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csCY_Avenue.Staff_Interface.Main.StaffShopInterface
{
    public partial class frmPaidPurchase : Form
    {
        private double merchandise;
        private double equipment;
        private double supplement;

        public frmPaidPurchase(double merchandise, double equipment, double supplement)
        {
            InitializeComponent();
            this.merchandise = merchandise;
            this.equipment = equipment;
            this.supplement = supplement;
            Load += frmPaidPurchase_Load;
        }

        private void frmPaidPurchase_Load(object sender, EventArgs e)
        {
            loadCrystalReport();
        }

        private void loadCrystalReport()
        {
            lblPaymentDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            lblInvoiceDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            
            lblTotalMerchandise.Text = merchandise.ToString("N2");
            lblTotalGear.Text = equipment.ToString("N2");
            lblTotalSuplements.Text = supplement.ToString("N2");

            double total = merchandise + equipment + supplement;
            lblTotalAmountDue.Text = total.ToString("N2");
        }
        
        //X
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}