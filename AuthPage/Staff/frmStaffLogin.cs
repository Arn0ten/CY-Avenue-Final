using csCY_Avenue.Admin_Interface.Main;
using csCY_Avenue.AuthPage.Admin;
using csCY_Avenue.Custom;
using csCY_Avenue.Staff_Interface.Main;
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
    public partial class frmStaffLogin : Form
    {
        fncControl Control;
        frmWelcome WelcomeForm = new frmWelcome();
        frmStaffForgotPassword ForgotPasswordForm = new frmStaffForgotPassword();
        public frmStaffLogin()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, WelcomeForm);
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmStaffMain StaffInterface = new frmStaffMain();
            StaffInterface.Show();
            this.Hide();
        }

        private void llbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, ForgotPasswordForm);
        }
    }
}
