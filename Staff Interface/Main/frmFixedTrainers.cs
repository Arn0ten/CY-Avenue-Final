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

namespace csCY_Avenue.Staff_Interface.Main
{
    public partial class frmFixedTrainers : Form
    {
        fncControl Control;
        public frmFixedTrainers()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        private void frmFixedTrainers_Load(object sender, EventArgs e)
        {
            update();
        }
        private void update()
        {

            ArrayList row = new ArrayList();
            row.Add("1234");
            row.Add("Arneabell");
            row.Add("21");
            row.Add("Male");
            row.Add("02/27/2002");
            row.Add("Arn@email.com");
            row.Add("Active");
            dgvFixedTrainers.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1234");
            row.Add("Arneabell");
            row.Add("21");
            row.Add("Male");
            row.Add("02/27/2002");
            row.Add("Arn@email.com");
            row.Add("Active");
            dgvFixedTrainers.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1234");
            row.Add("Arneabell");
            row.Add("21");
            row.Add("Male");
            row.Add("02/27/2002");
            row.Add("Arn@email.com");
            row.Add("Active");
            dgvFixedTrainers.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1234");
            row.Add("Arneabell");
            row.Add("21");
            row.Add("Male");
            row.Add("02/27/2002");
            row.Add("Arn@email.com");
            row.Add("Active");
            dgvFixedTrainers.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1234");
            row.Add("Arneabell");
            row.Add("21");
            row.Add("Male");
            row.Add("02/27/2002");
            row.Add("Arn@email.com");
            row.Add("Active");
            dgvFixedTrainers.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1234");
            row.Add("Arneabell");
            row.Add("21");
            row.Add("Male");
            row.Add("02/27/2002");
            row.Add("Arn@email.com");
            row.Add("Active");
            dgvFixedTrainers.Rows.Add(row.ToArray());
        }
        private void dgvFixedTrainers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                var FormFixedTrainerAssignedMembers = new frmFixedTrainerAssignedMembers();
                Control.blurOverlay(FormFixedTrainerAssignedMembers);
            }
            else if (e.ColumnIndex == 8)
            {
                var FormFixedTrainerClasses = new frmFixedTrainerClasses();
                Control.blurOverlay(FormFixedTrainerClasses);
            }
        }
    }
}
