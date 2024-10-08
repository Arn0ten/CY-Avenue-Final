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
            var FormEditStaff = new frmEditStaff();
            blurOverlay(FormEditStaff);
        }

        //Delete
        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {

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

        //Na pindot
        private void pnlDisplay_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
