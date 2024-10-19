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
    public partial class frmLoadingScreen : Form
    {
        frmStart StartForm = new frmStart();
        public frmLoadingScreen()
        {
            InitializeComponent();
        }

        private void frmLoadingScreen_Load(object sender, EventArgs e)
        {
            lblText.Parent = picYulo;
            lblText.BackColor = Color.Transparent;
            lblText1.Parent = picYulo;
            lblText1.BackColor = Color.Transparent;
            lblText2.Parent = picYulo;
            lblText2.BackColor = Color.Transparent;
            lblLoading.Parent = picYulo;
            lblLoading.BackColor = Color.Transparent;
            lblPercent.Parent = picYulo;
            lblPercent.BackColor = Color.Transparent;
            tmrLoading.Start();
        }

        private void tmrLoading_Tick(object sender, EventArgs e)
        {
            if (prgBar.Value < 100)
            {

                prgBar.Value += 1;

                lblPercent.Text = prgBar.Value.ToString() + "%";
            }
            else
            {
                tmrLoading.Stop();
                this.Hide();
                StartForm.ShowDialog();
            }
        }
    }
}
