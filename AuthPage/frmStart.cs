using csCY_Avenue.Custom;

namespace csCY_Avenue.AuthPage
{
    public partial class frmStart : Form
    {
        fncControl Control;
        frmWelcome WelcomeForm = new frmWelcome();

        public frmStart()
        {
            InitializeComponent();
            Control = new fncControl();
            Control.LoadFormInPanel(pnlDisplay, WelcomeForm);
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

        private void pnlDisplay_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}