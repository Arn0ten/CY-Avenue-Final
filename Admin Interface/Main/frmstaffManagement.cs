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
    public partial class frmstaffManagement : Form
    {
        public frmstaffManagement()
        {
            InitializeComponent();
        }

        private void frmstaffManagement_Load(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                ResetForm();
            }
        }
        //Add
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            var FormAddStaff = new frmAddStaff();
            blurOverlay(FormAddStaff);
        }

        //Edit
        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            enableForm();
        }

        //Delete
        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {

        }

        //Save
        private void btnSaveStaff_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        //CLearForm
        private void llblCLearStaffForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearForm();
        }

        //Enabled
        private void enableForm()
        {
            txtEditStaffFullname.ReadOnly = false;
            txtEditStaffPhoneNumber.ReadOnly = false;
            txtEditStaffEmail.ReadOnly = false;
            txtEditStaffAge.Enabled = true;
            txtEditStaffAge.ReadOnly = false;
            txtEditStaffPhoneNumber.Enabled = true;
            txtEditStaffFullname.Enabled = true;
            txtEditStaffEmail.Enabled = true;
            cmbEditStaffGender.Enabled = true;
            cmbEditStaffRole.Enabled = true;
            dtEditStaffBirthdate.Enabled = true;
            btnSaveStaff.Enabled = true;
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
            txtEditStaffFullname.ReadOnly = true;
            txtEditStaffPhoneNumber.ReadOnly = true;
            txtEditStaffEmail.ReadOnly = true;
            txtEditStaffAge.Enabled = false;
            txtEditStaffPhoneNumber.Enabled = false;
            txtEditStaffFullname.Enabled = false;
            txtEditStaffEmail.Enabled = false;
            cmbEditStaffGender.Enabled = false;
            cmbEditStaffRole.Enabled = false;
            dtEditStaffBirthdate.Enabled = false;
            btnSaveStaff.Enabled = false;
        }

        //Clear Form
        private void ClearForm()
        {
            txtEditStaffFullname.Text = string.Empty;
            txtEditStaffPhoneNumber.Text = string.Empty;
            txtEditStaffEmail.Text = string.Empty;
            txtEditStaffAge.Text = string.Empty;
            cmbEditStaffGender.SelectedIndex = -1;
            cmbEditStaffRole.SelectedIndex = -1;
            dtEditStaffBirthdate.Value = DateTime.Today;
            ResetForm();
        }


        //Na pindot
        private void pnlDisplay_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
