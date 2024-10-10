using csCY_Avenue.Admin_Interface.Main;

namespace csCY_Avenue.AuthPage
{
    public partial class frmAdminLogin : Form
    {
        

        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmAdminMain AdminInterface = new frmAdminMain();
            this.Close();
            AdminInterface.ShowDialog();
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
    }
}
