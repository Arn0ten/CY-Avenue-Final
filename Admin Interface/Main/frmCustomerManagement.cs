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
    public partial class frmCustomerManagement : Form
    {
        public frmCustomerManagement()
        {
            InitializeComponent();
        }

        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                ResetForm();
            }
        }

        // Add
        private void btnAddMember_Click_1(object sender, EventArgs e)
        {
            var FormAddMember = new frmAddMember();
            blurOverlay(FormAddMember);
        }

        //Delete

        //Search

        //Display

        // Edit 
        private void btnEditMember_Click(object sender, EventArgs e)
        {
            enableForm();
        }

        //Save
        private void btnSaveMember_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        //Clear
        private void llblCLearMemberForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearForm();
        }

        //Enabled
        private void enableForm()
        {
            txtEditMemberFullname.ReadOnly = false;
            txtEditMemberPhoneNumber.ReadOnly = false;
            txtEditMemberEmail.ReadOnly = false;
            txtEditMemberAge.Enabled = true;
            txtEditMemberAge.ReadOnly = false;
            txtEditMemberPhoneNumber.Enabled = true;
            txtEditMemberFullname.Enabled = true;
            txtEditMemberEmail.Enabled = true;
            cmbEditMemberGender.Enabled = true;
            dtEditMemberBirthdate.Enabled = true;
            dtEditMembershipStart.Enabled = true;
            dtEditMembershipEnd.Enabled = true;
            btnSaveMember.Enabled = true;
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
            txtEditMemberFullname.ReadOnly = true;
            txtEditMemberPhoneNumber.ReadOnly = true;
            txtEditMemberEmail.ReadOnly = true;
            txtEditMemberAge.Enabled = false;
            txtEditMemberPhoneNumber.Enabled = false;
            txtEditMemberFullname.Enabled = false;
            txtEditMemberEmail.Enabled = false;
            cmbEditMemberGender.Enabled = false;
            dtEditMemberBirthdate.Enabled = false;
            dtEditMembershipStart.Enabled = false;
            dtEditMembershipEnd.Enabled = false;
            btnSaveMember.Enabled = false;
        }

        //Na pindot
        private void pnlDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        //Clear Form
        private void ClearForm()
        {
            txtEditMemberFullname.Text = string.Empty;
            txtEditMemberPhoneNumber.Text = string.Empty;
            txtEditMemberEmail.Text = string.Empty;
            txtEditMemberAge.Text = string.Empty;
            cmbEditMemberGender.SelectedIndex = -1; 
            dtEditMemberBirthdate.Value = DateTime.Today;
            dtEditMembershipStart.Value = DateTime.Today;
            dtEditMembershipEnd.Value = DateTime.Today;         
            ResetForm();
        }
    }
}
