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
        frmStaffResetPassword ResetPasswordForm = new frmStaffResetPassword();
        public frmStaffVerificationCode()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, ResetPasswordForm);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, WelcomeForm);
        }
    }
}
