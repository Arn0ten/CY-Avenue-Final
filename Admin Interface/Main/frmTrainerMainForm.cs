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
    public partial class frmTrainerMainForm : Form
    {
        private frmFixedTrainers FixedTrainersGridView;
        private frmPersonalTrainers PersonalTrainersGridView;
        public frmTrainerMainForm()
        {
            InitializeComponent();
            cmbTrainerMainFormGridViewFilter.SelectedIndex = 0;
        }

        private void cmbTrainerMainFormGridViewFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlDisplay.Controls.Clear();

            Form selectedForm = null;
            if (cmbTrainerMainFormGridViewFilter.SelectedItem.ToString() == "Fixed Trainers")
            {
                if (FixedTrainersGridView == null)
                {
                    FixedTrainersGridView = new frmFixedTrainers();
                }
                selectedForm = FixedTrainersGridView;
            }
            else if (cmbTrainerMainFormGridViewFilter.SelectedItem.ToString() == "Personal Trainers")
            {
                if (PersonalTrainersGridView == null)
                {
                    PersonalTrainersGridView = new frmPersonalTrainers();
                }
                selectedForm = PersonalTrainersGridView;
            }

            //Panel Loader
            if (selectedForm != null)
            {
                selectedForm.TopLevel = false;
                selectedForm.Dock = DockStyle.Fill;
                pnlDisplay.Controls.Add(selectedForm);
                selectedForm.BringToFront();
                selectedForm.Show();
            }
        }
    }
}
