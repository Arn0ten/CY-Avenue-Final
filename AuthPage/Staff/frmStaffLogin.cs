using CarlosYulo.backend.monolith.client;
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
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarlosYulo;
using CarlosYulo.backend.monolith.common;
using CarlosYulo.backend;
using CarlosYulo.backend.monolith.systemAccount;

namespace csCY_Avenue.AuthPage
{
    public partial class frmStaffLogin : Form
    {
        fncControl Control;
        frmWelcome WelcomeForm = new frmWelcome();
        frmStaffForgotPassword ForgotPasswordForm = new frmStaffForgotPassword();

        // backend functions
        private SystemAccountController _systemAccountController;
        private PasswordHashing _passwordHashing;

        public frmStaffLogin()
        {
            InitializeComponent();
            Control = new fncControl();

            // backend
            _systemAccountController = ServiceLocator.GetService<SystemAccountController>();
            _passwordHashing = ServiceLocator.GetService<PasswordHashing>();
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
            // var account = _systemAccountController.SearchByEmail(txtEmail.Text);
            // if (account != null)
            // {
            //     if (!_systemAccountController.CheckAccountIfStaff(account))
            //     {
            //         return;
            //     }

                // if (!_passwordHashing.VerifyPassword(account, txtPassword.Text))
                // {
                //     MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //     return;
                // }
                
                // MessageBox.Show("Login successful. Welcome " + account.UserName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Console.WriteLine("logged in" + account);
                frmStaffMain StaffInterface = new frmStaffMain();
                StaffInterface.Show();
                Hide();
            }
        

        private void llbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, ForgotPasswordForm);
        }
    }
}