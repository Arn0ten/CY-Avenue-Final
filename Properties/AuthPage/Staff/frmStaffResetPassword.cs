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
using CarlosYulo;
using CarlosYulo.backend;
using CarlosYulo.backend.monolith.systemAccount;

namespace csCY_Avenue.AuthPage.Admin
{
    public partial class frmStaffResetPassword : Form
    {
        fncControl Control;
        frmWelcome WelcomeForm = new frmWelcome();

        // backend
        public SystemAccount account { get; set; }
        private SystemAccountController _systemAccount;


        public frmStaffResetPassword()
        {
            InitializeComponent();
            Control = new fncControl();
            _systemAccount = ServiceLocator.GetService<SystemAccountController>();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, WelcomeForm);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!_systemAccount.ChangePasswordInForgetPassword(account, txtNewPassword.Text, txtConfirmPassword.Text))
            {
                return;
            }
            
            MessageBox.Show("Password Changed Successfully");
            Control.LoadFormInPanel(pnlDisplay, WelcomeForm);
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtNewPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtNewPassword.PasswordChar = '•';
                txtConfirmPassword.PasswordChar = '•';
            }
        }
    }
}