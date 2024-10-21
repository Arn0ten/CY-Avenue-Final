using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace csCY_Avenue.AuthPage
{
    public partial class frmLoadingScreen : Form
    {
        frmStart StartForm = new frmStart();
      //  GlobalProcedure globalprocedure = new GlobalProcedure(); 

        public frmLoadingScreen()
        {
            InitializeComponent();
        }

        private void frmLoadingScreen_Load(object sender, EventArgs e)
        {
            // Set transparent background for labels
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
            InitializeConfiguration();  
            worker.ReportProgress(20);
            
            
            // bool isConnected = globalprocedure.fncConnectToDatabase();
            bool isConnected = false;
            if (isConnected)
            {
                worker.ReportProgress(50);  
            }
            else
            {
                worker.ReportProgress(30); 
               
            }
            LoadResources(); 
            worker.ReportProgress(70);
            InitializeUIComponents();
            worker.ReportProgress(90);
            PerformFinalSetup();  
            worker.ReportProgress(100);
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

        private void LoadResources()
        {
           
            Thread.Sleep(1000); 
        }

        private void InitializeConfiguration()
        {
           
            Thread.Sleep(500); 
        }

        private void InitializeUIComponents()
        {

            Thread.Sleep(500);  
        }

        private void PerformFinalSetup()
        {

            Thread.Sleep(500);  
        }
    }
}
