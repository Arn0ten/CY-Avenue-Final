using csCY_Avenue.Custom;
using System;
using System.Collections;
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
    public partial class frmMembersGridView : Form
    {
        fncControl Control;
        public frmMembersGridView()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        private void frmMembersGridView_Load(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {

            ArrayList row = new ArrayList();
            row.Add("Arneabell Bautista");
            row.Add("29");
            row.Add("Male");
            row.Add("02/27/2002");
            row.Add("VIP");
            row.Add("Arn@Yahoo.com");
            row.Add("Active");
            dgvMembers.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("Arneabell Bautista");
            row.Add("29");
            row.Add("Male");
            row.Add("02/27/2002");
            row.Add("VIP");
            row.Add("Arn@Yahoo.com");
            row.Add("Active");
            dgvMembers.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("Arneabell Bautista");
            row.Add("29");
            row.Add("Male");
            row.Add("02/27/2002");
            row.Add("VIP");
            row.Add("Arn@Yahoo.com");
            row.Add("Active");
            dgvMembers.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("Arneabell Bautista");
            row.Add("29");
            row.Add("Male");
            row.Add("02/27/2002");
            row.Add("VIP");
            row.Add("Arn@Yahoo.com");
            row.Add("Active");
            dgvMembers.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("Arneabell Bautista");
            row.Add("29");
            row.Add("Male");
            row.Add("02/27/2002");
            row.Add("VIP");
            row.Add("Arn@Yahoo.com");
            row.Add("Active");
            dgvMembers.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("Arneabell Bautista");
            row.Add("29");
            row.Add("Male");
            row.Add("02/27/2002");
            row.Add("VIP");
            row.Add("Arn@Yahoo.com");
            row.Add("Active");
            dgvMembers.Rows.Add(row.ToArray());
        }

        //Button sa gridview
        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
                if (e.ColumnIndex == 7)
                {
                    var FormRenewMember = new frmRenewMember();
                    Control.blurOverlay(FormRenewMember);
                }
            
        }
    }
}
