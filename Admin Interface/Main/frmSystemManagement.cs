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
    public partial class frmSystemManagement : Form
    {
        fncControl Control;
        public frmSystemManagement()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        private void frmSystemManagement_Load(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {

            ArrayList row = new ArrayList();
            row.Add("123455");
            row.Add("Argie");
            row.Add("Argeie@email.com");
            row.Add("Staff");
            row.Add("False");
            row.Add("True");
            dgvMembers.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("123455");
            row.Add("Arn");
            row.Add("Argeie@email.com");
            row.Add("Admin");
            row.Add("False");
            row.Add("False");
            dgvMembers.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("123455");
            row.Add("Jesus");
            row.Add("Argeie@email.com");
            row.Add("Staff");
            row.Add("True");
            row.Add("True");
            dgvMembers.Rows.Add(row.ToArray());
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                MessageBox.Show($"User has been successfully deleted!",
                                     "Class Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlDisplay_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
