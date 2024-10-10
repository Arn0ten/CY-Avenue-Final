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

namespace csCY_Avenue.Admin_Interface.Main
{
    public partial class frmShopManagement : Form
    {
        fncControl Control;
        public frmShopManagement()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        //Add
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var FormAddItem = new frmAddItem();
            Control.blurOverlay(FormAddItem);
        }

        //Edit Item
        private void btnEditItem_Click(object sender, EventArgs e)
        {
            var FormEditItem = new frmEditItem();
            Control.blurOverlay(FormEditItem);
        }

        //Delete
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
