using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using csCY_Avenue.Custom;

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmCustomerManagement : Form
    {
        private fncControl Control;
        public frmCustomerManagement()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {

        }

        // Add
        private void btnAddMember_Click_1(object sender, EventArgs e)
        {
            var FormAddMember = new frmAddMember();
            Control.blurOverlay(FormAddMember);
        }

        //Delete
        private void btnDeleteMember_Click(object sender, EventArgs e)
        {

        }

        // Edit 
        private void btnEditMember_Click(object sender, EventArgs e)
        {
            var FormEditMember = new frmEditMember();           
            Control.blurOverlay(FormEditMember);
        }

        //Search



        //Display



        //Na pindot
        private void pnlDisplay_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
