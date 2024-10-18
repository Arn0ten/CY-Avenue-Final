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
    public partial class frmMemberManagement : Form
    {
        fncControl Control;


        public frmMemberManagement()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        //Add
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            var FormAddMember = new frmAddMember();
            Control.blurOverlay(FormAddMember);
        }

        //Edit
        private void btnEditMember_Click(object sender, EventArgs e)
        {
            var FormEditMember = new frmEditMember();
            Control.blurOverlay(FormEditMember);
        }

        //Search
        private void btnSearchMember_Click(object sender, EventArgs e)
        {

        }

        //Delete
        private void btnDeleteMember_Click(object sender, EventArgs e)
        {

        }
    }
}
