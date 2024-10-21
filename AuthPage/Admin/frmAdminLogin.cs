using CarlosYulo;
using CarlosYulo.backend.monolith.common;
using CarlosYulo.backend.monolith.systemAccount;
using csCY_Avenue.Admin_Interface.Main;
using csCY_Avenue.AuthPage.Admin;
using csCY_Avenue.Custom;

namespace csCY_Avenue.AuthPage
{
    public partial class frmAdminLogin : Form
    {

        fncControl Control;
        frmWelcome WelcomeForm = new frmWelcome();
        private SystemAccountController _systemAccount;
        private PasswordHashing _password;

        public frmAdminLogin()
        {
            InitializeComponent();
            Control = new fncControl();
            _systemAccount = ServiceLocator.GetService<SystemAccountController>();
            _password = ServiceLocator.GetService<PasswordHashing>();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // var admin = _systemAccount.SearchByEmail(txtEmail.Text);
            // if (admin != null)
            // {
            //     if (!_systemAccount.CheckAccountIfAdmin(admin))
            //     {
            //         return;
            //     }
            //     
            //     if(!_password.VerifyPassword(admin, txtPassword.Text))
            //     {
            //         MessageBox.Show("Invalid password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //         return;
            //     }

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



        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
