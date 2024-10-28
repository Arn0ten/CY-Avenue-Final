using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace csCY_Avenue.AuthPage
{
    public partial class frmLoadingScreen : Form
    {
        private frmStart StartForm = new frmStart();
        private Random random = new Random();

        public frmLoadingScreen()
        {
            InitializeComponent();
        }

        private void frmLoadingScreen_Load(object sender, EventArgs e)
        {
            SetLabelTransparency();
            BackgroundWorker bgWorker = new BackgroundWorker();
            bgWorker.WorkerReportsProgress = true;
            bgWorker.DoWork += BgWorker_DoWork;
            bgWorker.ProgressChanged += BgWorker_ProgressChanged;
            bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;
            bgWorker.RunWorkerAsync();
        }

        private void SetLabelTransparency()
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
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int progress = 0;

            while (progress < 100)
            {
                progress += random.Next(5, 15);
                if (progress > 100) progress = 100; 
                worker.ReportProgress(progress);

                Thread.Sleep(random.Next(200, 500)); 
            }
        }

        private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prgBar.Value = e.ProgressPercentage;
            lblPercent.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Hide();
            StartForm.ShowDialog();
        }
    }
}
