namespace csCY_Avenue.AuthPage
{
    public partial class frmWelcome : Form
    {

        public frmWelcome()
        {
            InitializeComponent();

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

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            frmAdminLogin AdminFormLogin = new frmAdminLogin();
            LoadFormInPanel(AdminFormLogin);
        }
        //Admin Login
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        //Admin Signup
        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }


        //Panel loader 
        private void LoadFormInPanel(Form form)
        {

            pnl.Controls.Clear();
            if (form != null && !form.IsDisposed)
            {
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                pnl.Controls.Add(form);
                form.Show();
            }
        }

    }
}
