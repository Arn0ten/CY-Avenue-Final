using csCY_Avenue.Admin_Interface.Main;
using csCY_Avenue.AuthPage.Admin;
using csCY_Avenue.Custom;

namespace csCY_Avenue.AuthPage
{
    public partial class frmAdminLogin : Form
    {

        fncControl Control;
        frmWelcome WelcomeForm = new frmWelcome();
        

        public frmAdminLogin()
        {
            InitializeComponent();
            Control = new fncControl();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmAdminMain AdminInterface = new frmAdminMain();
            AdminInterface.Show();
            this.Hide();

        }

        // Show Password 
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, WelcomeForm);
        }

    }
}
