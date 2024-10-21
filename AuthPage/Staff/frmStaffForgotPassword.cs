using CarlosYulo;
using CarlosYulo.backend;
using CarlosYulo.backend.monolith.systemAccount;
using CarlosYulo.backend.monolith.systemAccount.sy_login;
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

namespace csCY_Avenue.AuthPage.Admin
{
    public partial class frmStaffForgotPassword : Form
    {
        fncControl Control;
        frmWelcome WelcomeForm = new frmWelcome();

        private SystemAccountController _systemAccountController;


        public frmStaffForgotPassword()
        {
            InitializeComponent();
            Control = new fncControl();
            _systemAccountController = ServiceLocator.GetService<SystemAccountController>();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SystemAccount? account = _systemAccountController.SearchByEmail(txtEmail.Text);
            if (account != null)
            {
                if (!_systemAccountController.CheckAccountIfStaff(account))
                {
                    MessageBox.Show("Invalid account role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SystemVerification verification;
                if(!_systemAccountController.GenerateSystemAccountVerificationAndSave(account, out verification))
                {
                    return;
                }
                
                // if(!_systemAccountController.SendVerificationCodeEmail(verification, account.Email))
                // {
                //     return;
                // }
                
                
                frmStaffVerificationCode frmVerification = new frmStaffVerificationCode();
                frmVerification.verification = verification;
                frmVerification.account = account;
                Control.LoadFormInPanel(pnlDisplay, frmVerification);
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, WelcomeForm);
        }
    }
}
