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
        public frmWelcome()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        //Admin Login
        private void btnLoginForm_Click(object sender, EventArgs e)
        {
            frmAdminLogin AdminFormLogin = new frmAdminLogin();
            Control.LoadFormInPanel(pnlDisplay, AdminFormLogin);
        }

        
        private void btnSignupForm_Click(object sender, EventArgs e)
        {

        }
    }
}
