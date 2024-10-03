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
    public partial class frmDahsboard : Form
    {
        private frmMembersGridView membersGridView;
        private frmStaffGridView staffGridView;
        private frmTrainerGridView trainerGridView;


        public frmDahsboard()
        {
            InitializeComponent();
            cmbFilter.SelectedIndex = 0;
        }

        //Filter
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            pnlDgvDisplay.Controls.Clear();

            Form selectedForm = null;
            if (cmbFilter.SelectedItem.ToString() == "Members")
            {
                if (membersGridView == null)
                {
                    membersGridView = new frmMembersGridView();
                }
                selectedForm = membersGridView;
            }
            else if (cmbFilter.SelectedItem.ToString() == "Staffs")
            {
                if (staffGridView == null)
                {
                    staffGridView = new frmStaffGridView();
                }
                selectedForm = staffGridView;
            }
            else if (cmbFilter.SelectedItem.ToString() == "Trainers")
            {
                if (trainerGridView == null)
                {
                    trainerGridView = new frmTrainerGridView();
                }
                selectedForm = trainerGridView;
            }

            //Panel Loader
            if (selectedForm != null)
            {
                selectedForm.TopLevel = false;
                selectedForm.Dock = DockStyle.Fill;
                pnlDgvDisplay.Controls.Add(selectedForm);
                selectedForm.BringToFront();
                selectedForm.Show();
            }
        }

        //Transparent na label
        private void pnlDisplay_Paint(object sender, PaintEventArgs e)
        {
            lblMembersCounter.Parent = btnMembers;
            lblMembersCounter.BackColor = Color.Transparent;
            lblMembers.Parent = btnMembers;
            lblMembers.BackColor = Color.Transparent;
            lblStaffsCounter.Parent = btnStaff;
            lblStaffsCounter.BackColor = Color.Transparent;
            lblStaffs.Parent = btnStaff;
            lblStaffs.BackColor = Color.Transparent;
            lblTrainersCounter.Parent = btnTrainers;
            lblTrainersCounter.BackColor = Color.Transparent;
            lblTrainers.Parent = btnTrainers;
            lblTrainers.BackColor = Color.Transparent;
            lblRevenueCounter.Parent = btnRevenue;
            lblRevenueCounter.BackColor = Color.Transparent;
            lblRevenues.Parent = btnRevenue;
            lblRevenues.BackColor = Color.Transparent;
        }

        //Napindot

    }
}
