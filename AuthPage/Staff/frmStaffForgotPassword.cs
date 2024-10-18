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
        frmStaffVerificationCode VerificationCodeForm = new frmStaffVerificationCode();

        public frmStaffForgotPassword()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, VerificationCodeForm);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, WelcomeForm);
        }
    }
}
