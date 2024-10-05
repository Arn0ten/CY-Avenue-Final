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
        public frmTrainerManagement()
        {
            InitializeComponent();
        }

        private void frmTrainerManagement_Load(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                ResetForm();
            }
        }

        //Add
        private void btnAddTrainer_Click(object sender, EventArgs e)
        {
            var FormAddTrainer = new frmAddTrainer();
            blurOverlay(FormAddTrainer);
        }

        //Delete
        private void btnDeleteTrainer_Click(object sender, EventArgs e)
        {

        }

        //Save
        private void btnSaveTrainer_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        //Edit
        private void btnEditTrainer_Click(object sender, EventArgs e)
        {
            enableForm();
        }

        //Clear
        private void llblCLearTrainerForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearForm();
        }
        //Enabled
        private void enableForm()
        {
            txtEditTrainerFullname.ReadOnly = false;          
            txtEditTrainerPhoneNumber.ReadOnly = false;
            txtEditTrainerEmail.ReadOnly = false;
            txtEditTrainerAge.Enabled = true;
            txtEditTrainerAge.ReadOnly = false;
            txtEditTrainerPhoneNumber.Enabled = true;
            txtEditTrainerFullname.Enabled = true;
            txtEditTrainerEmail.Enabled = true;
            cmbEditTrainerGender.Enabled = true;
            dtEditTrainerBirthdate.Enabled = true;
            btnSaveTrainer.Enabled = true;
        }

        // Blur Dialog
        public void blurOverlay(Form formDialog, Color backgroundColor = default)
        {
            var overlayForm = new Form
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = 0.5d,
                BackColor = backgroundColor == default ? Color.Black : backgroundColor,
                Size = new Size(1366, 768),
                Location = new Point(0, 0),
                ShowInTaskbar = false,
                TopMost = true
            };
            overlayForm.Show();
            formDialog.Owner = overlayForm;
            formDialog.TopMost = true;
            formDialog.ShowDialog();
            overlayForm.Dispose();

        }

        // Method to reset and disable form controls
        public void ResetForm()
        {
            txtEditTrainerFullname.ReadOnly = true;
            txtEditTrainerPhoneNumber.ReadOnly = true;
            txtEditTrainerEmail.ReadOnly = true;
            txtEditTrainerAge.Enabled = false;
            txtEditTrainerPhoneNumber.Enabled = false;
            txtEditTrainerFullname.Enabled = false;
            txtEditTrainerEmail.Enabled = false;
            cmbEditTrainerGender.Enabled = false;
            dtEditTrainerBirthdate.Enabled = false;
            btnSaveTrainer.Enabled = false;
        }

        //Clear Form
        private void ClearForm()
        {
            txtEditTrainerFullname.Text = string.Empty;
            txtEditTrainerPhoneNumber.Text = string.Empty;
            txtEditTrainerEmail.Text = string.Empty;
            txtEditTrainerAge.Text = string.Empty;
            cmbEditTrainerGender.SelectedIndex = -1;
            dtEditTrainerBirthdate.Value = DateTime.Today;
            ResetForm();
        }
    }
}
