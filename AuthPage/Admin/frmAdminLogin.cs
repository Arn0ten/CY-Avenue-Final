using CarlosYulo;
using CarlosYulo.backend;
using CarlosYulo.backend.monolith.common;
using CarlosYulo.backend.monolith.employee.create;
using CarlosYulo.backend.monolith.systemAccount;
using CarlosYulo.database;
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

        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    var admin = _systemAccount.SearchByEmail(txtEmail.Text);
        //    if (admin != null)
        //    {
        //        if (!_systemAccount.CheckAccountIfAdmin(admin))
        //        {
        //            return;
        //        }

        //        if (!_password.VerifyPassword(admin, txtPassword.Text))
        //        {
        //            MessageBox.Show("Invalid password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        frmAdminMain AdminInterface = new frmAdminMain();
        //        AdminInterface.Show();
        //        this.Hide();

        //    }

        //}

        private void chkShowPassword_CheckedChanged_1(object sender, EventArgs e)
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
            const string adminEmail = "Admin";
            const string adminPassword = "1234";

            if (txtEmail.Text.Trim() == adminEmail && txtPassword.Text.Trim() == adminPassword)
            {
                MessageBox.Show("Login successful. Welcome Admin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmAdminMain AdminInterface = new frmAdminMain();
                AdminInterface.Show();
                this.Hide();
            }
            else
            {              
                var result = MessageBox.Show("Invalid email or password. Do you want to try again?",
                                               "Login Error",
                                               MessageBoxButtons.OKCancel,
                                               MessageBoxIcon.Error);

                if (result == DialogResult.Cancel)
                {

                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Control.LoadFormInPanel(pnlDisplay, WelcomeForm);
        }
    }
}
