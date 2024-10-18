using csCY_Avenue.Admin_Interface.Main;
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

namespace csCY_Avenue.Staff_Interface.Main
{
    public partial class frmTrainerManagement : Form
    {
        fncControl Control;
        public frmTrainerManagement()
        {
            InitializeComponent();
            Control = new fncControl();
        }


        //Add
        private void btnAddTrainer_Click(object sender, EventArgs e)
        {
            var FormAddTrainer = new frmAddTrainer();
            Control.blurOverlay(FormAddTrainer);
        }
        
        //Edit
        private void btnEditTrainer_Click(object sender, EventArgs e)
        {
            var FormEditTrainer = new frmEditTrainer();
            Control.blurOverlay(FormEditTrainer);
        }

        //Search
        private void btnSearchTrainer_Click(object sender, EventArgs e)
        {

        }

        //Delete
        private void btnDeleteTrainer_Click(object sender, EventArgs e)
        {

        }
    }
}
