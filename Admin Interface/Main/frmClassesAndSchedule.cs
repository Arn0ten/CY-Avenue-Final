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
    public partial class frmClassesAndSchedule : Form
    {
        private fncControl Control;
        public frmClassesAndSchedule()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        private void frmClassesAndSchedule_Load(object sender, EventArgs e)
        {

        }

        //Add
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            var FormAddClass = new frmAddClass();
            Control.blurOverlay(FormAddClass);
        }

        //Edit
        private void btnEditClass_Click(object sender, EventArgs e)
        {
            var FormEditClass = new frmEditClass();
            Control.blurOverlay(FormEditClass);
        }

        //Delete
        private void btnDeleteClass_Click(object sender, EventArgs e)
        {

        }

        //Search
        private void btnSearchClass_Click(object sender, EventArgs e)
        {

        }

        //Na pindot
        private void txtEditClassName_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
