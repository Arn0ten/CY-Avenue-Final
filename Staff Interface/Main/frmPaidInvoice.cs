using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csCY_Avenue.Staff_Interface.Main
{
    public partial class frmPaidInvoice : Form
    {
        public frmPaidInvoice()
        {
            InitializeComponent();
        }
        // Method to set the membership type on the label
        public void SetMembershipType(string customerType)
        {
            lblMembershipType.Text = customerType;
        }

        //Class
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
