using Autofac;
using CarlosYulo;
using CarlosYulo.backend;
using CarlosYulo.backend.monolith.employee;
using CarlosYulo.backend.monolith.employee.create;
using CarlosYulo.database;
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
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ServiceLocator.ServiceProvider = IoC.ConfigureServices();

            PreloadData.PreLoad();
            PreloadAttendanceData.preLoadAllAttendance();
            foreach (var v in PreloadAttendanceData.All)
            {
                Console.WriteLine(v.ToString());
            }
            

            var mainForm = ServiceLocator.GetService<frmLoadingScreen>();
            var add = ServiceLocator.GetService<frmAdminMain>();

            EmployeeCreateNew test = new EmployeeCreateNew(ServiceLocator.GetService<DatabaseConnection>());


            Application.Run(add);
        }
    }
}