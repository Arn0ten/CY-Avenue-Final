using csCY_Avenue.Custom;

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
        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }
        //Admin Login
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmAdminLogin AdminFormLogin = new frmAdminLogin();
            Control.LoadFormInPanel(pnlDisplay,AdminFormLogin);
        }

        //Admin Signup
        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

    }
}
