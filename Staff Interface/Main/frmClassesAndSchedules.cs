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
    public partial class frmClassesAndSchedules : Form
    {
        fncControl Control;
        public frmClassesAndSchedules()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        //Add
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            var AddClass = new frmAddClass();
            Control.blurOverlay(AddClass);
        }

        //Edit
        private void btnEditClass_Click(object sender, EventArgs e)
        {
            var EditClass = new frmEditClass();
            Control.blurOverlay(EditClass);
        }

        //Delete
        private void btnDeleteClass_Click(object sender, EventArgs e)
        {

        }

        //Search
        private void btnSearchClass_Click(object sender, EventArgs e)
        {

        }
    }
}
