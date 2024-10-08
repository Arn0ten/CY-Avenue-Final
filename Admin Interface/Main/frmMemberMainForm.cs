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
    public partial class frmMemberMainForm : Form
    {
        private fncControl Control;
        public frmMemberMainForm()
        {
            InitializeComponent();
            Control = new fncControl();
        }


        private void frmMemberMainForm_Load(object sender, EventArgs e)
        {
            update();
        }
        private void update()
        {

            ArrayList row = new ArrayList();
            row.Add("1234");
            row.Add("Arneabell");
            row.Add("VIP");
            row.Add("Active");
            dgvMembers.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1234");
            row.Add("Arneabell");
            row.Add("VIP");
            row.Add("Active");
            dgvMembers.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1234");
            row.Add("Arneabell");
            row.Add("VIP");
            row.Add("Active");
            dgvMembers.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1234");
            row.Add("Arneabell");
            row.Add("VIP");
            row.Add("Active");
            dgvMembers.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1234");
            row.Add("Arneabell");
            row.Add("VIP");
            row.Add("Active");
            dgvMembers.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1234");
            row.Add("Arneabell");
            row.Add("VIP");
            row.Add("Active");
            dgvMembers.Rows.Add(row.ToArray());
        }

        //Button sa gridview
        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var FormMemberDetails = new frmMemberDetails();
                Control.blurOverlay(FormMemberDetails);
            }
            else if (e.ColumnIndex == 5)
            {
                var FormAttendanceHistory = new frmMemberAttendanceHistory();
                Control.blurOverlay(FormAttendanceHistory);
            }
            else if (e.ColumnIndex == 6)
            {
                var FormTransactionHistory = new frmMemberTransactionHistory();
                Control.blurOverlay(FormTransactionHistory);
            }
        }

        //Na pindot
        private void pnlDisplay_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
