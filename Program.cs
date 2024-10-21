using Autofac;
using CarlosYulo;
using CarlosYulo.preload;
using csCY_Avenue.Admin_Interface.Main;
using csCY_Avenue.AuthPage;

namespace csCY_Avenue
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ServiceLocator.ServiceProvider = IoC.ConfigureServices();
            
            PreloadData.PreLoad(); 
            
            var mainForm = ServiceLocator.GetService<frmLoadingScreen>();
            var add = ServiceLocator.GetService<frmAdminMain>();

            Application.Run(add);
        }
    }
}