using CarlosYulo;
using CarlosYulo.backend;
using CarlosYulo.backend.monolith.systemAccount;
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
    public partial class frmStaffVerificationCode : Form
    {
        fncControl Control;
        frmWelcome WelcomeForm = new frmWelcome();

        // backend
        private SystemAccountController _systemAccountController;

        public SystemVerification verification { get; set; }
        public SystemAccount account { get; set; }

        public frmStaffVerificationCode()
        {
            InitializeComponent();
            Control = new fncControl();
            _systemAccountController = ServiceLocator.GetService<SystemAccountController>();
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!_systemAccountController.CompareVerification(verification, account, txtVerificationCode.Text))
            {
                return;
            }
            Console.WriteLine(verification.ToString());
            Console.WriteLine(account.ToString());
            
            frmStaffResetPassword ResetPasswordForm = new frmStaffResetPassword();
            ResetPasswordForm.account = account;
            Control.LoadFormInPanel(pnlDisplay, ResetPasswordForm);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, WelcomeForm);
        }
    }
}