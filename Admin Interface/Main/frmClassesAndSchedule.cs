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
    public partial class frmClassesAndSchedule : Form
    {
        public frmClassesAndSchedule()
        {
            InitializeComponent();
        }

        private void frmClassesAndSchedule_Load(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                ResetForm();
            }
        }

        //Add
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            var FormAddClass = new frmAddClass();
            blurOverlay(FormAddClass);
        }

        //Edit
        private void btnEditClass_Click(object sender, EventArgs e)
        {
            enableForm();
        }

        //Delete
        private void btnDeleteClass_Click(object sender, EventArgs e)
        {

        }

        //Save
        private void btnSaveClass_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        //Search
        private void btnSearchClass_Click(object sender, EventArgs e)
        {

        }

        //Clear
        private void llblCLearClassForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearForm();
        }

        //Enabled
        private void enableForm()
        {
            txtEditClassName.ReadOnly = false;
            cmbEditClassTrainer.Enabled = true;
            dtEditClassSchedule.Enabled = true;
            txtEditClassName.Enabled = true;
            txtEditClassCapacity.Enabled = false;
            btnSaveClass.Enabled = true;
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
            txtEditClassName.ReadOnly = true;
            cmbEditClassTrainer.Enabled = false;
            dtEditClassSchedule.Enabled = false;
            txtEditClassName.Enabled = false;
            txtEditClassCapacity.Enabled = false;
            btnSaveClass.Enabled = false;
        }

        //Clear Form
        private void ClearForm()
        {
            txtEditClassName.Text = string.Empty;
            cmbEditClassTrainer.SelectedIndex = -1;
            dtEditClassSchedule.Value = DateTime.Today;
            txtEditClassCapacity.Text = string.Empty;
            ResetForm();
        }

        //Na pindot
        private void txtEditClassName_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
