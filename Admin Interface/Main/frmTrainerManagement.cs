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
    public partial class frmTrainerManagement : Form
    {
        private fncControl Control;
        public frmTrainerManagement()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        private void frmTrainerManagement_Load(object sender, EventArgs e)
        {

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

        //Delete
        private void btnDeleteTrainer_Click(object sender, EventArgs e)
        {

        }
    }
}
