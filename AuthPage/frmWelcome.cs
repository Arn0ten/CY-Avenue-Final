using csCY_Avenue.Custom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csCY_Avenue.AuthPage
{
    public partial class frmWelcome : Form
    {
        fncControl Control;
        string selectedUserType;

        public frmWelcome()
        {
            InitializeComponent();
            Control = new fncControl();
            cmbUser.SelectedIndex = cmbUser.Items.IndexOf("Admin");
            selectedUserType = "Admin"; 
            lblUser.Text = selectedUserType;
        }

        // Handle ComboBox selection change
        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUserType = cmbUser.SelectedItem.ToString(); 
            lblUser.Text = selectedUserType; 
        }

        // Login button click event
        private void btnLoginForm_Click(object sender, EventArgs e)
        {
            if (selectedUserType == "Admin")
            {
                frmAdminLogin AdminFormLogin = new frmAdminLogin();
                Control.LoadFormInPanel(pnlDisplay, AdminFormLogin);
            }
            else if (selectedUserType == "Staff")
            {
                frmStaffLogin StaffFormLogin = new frmStaffLogin();
                
                Control.LoadFormInPanel(pnlDisplay, StaffFormLogin);
            }
        }

        // Signup button click event
        private void btnSignupForm_Click(object sender, EventArgs e)
        {
            if (selectedUserType == "Admin")
            {
                frmAdminSignup AdminFormSignup = new frmAdminSignup();
                Control.LoadFormInPanel(pnlDisplay, AdminFormSignup);
            }
            else if (selectedUserType == "Staff")
            {
                frmStaffSignup StaffFormSignup = new frmStaffSignup();
                Control.LoadFormInPanel(pnlDisplay, StaffFormSignup);
            }
        }
    }
}
