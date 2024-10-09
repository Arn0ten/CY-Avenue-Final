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
    public partial class frmstaffManagement : Form
    {
        private fncControl Control;
        public frmstaffManagement()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        private void frmstaffManagement_Load(object sender, EventArgs e)
        {

        }
        //Add
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            var FormAddStaff = new frmAddStaff();
            Control.blurOverlay(FormAddStaff);
        }

        //Edit
        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            var FormEditStaff = new frmEditStaff();
            Control.blurOverlay(FormEditStaff);
        }

        //Delete
        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {

        }

        //Na pindot
        private void pnlDisplay_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
