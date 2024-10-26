using Autofac;
using CarlosYulo;
using CarlosYulo.backend;
using CarlosYulo.backend.monolith.employee;
using CarlosYulo.backend.monolith.employee.create;
using CarlosYulo.database;
using CarlosYulo.preload;
using csCY_Avenue.Admin_Interface.Main;
using csCY_Avenue.AuthPage;
using csCY_Avenue.Staff_Interface.Main;

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
            PreloadRevenueData.PreLoad();
            PreloadItemData.PreloadItems();
            PreloadPayPending.PreUnpaidLoad();
            PreloadClassSchedule.PreLoadSchedule();
            List<EmployeeAttendance> y = PreloadAttendanceData.All;
            
            foreach (var v in y)
            {
                Console.WriteLine(v.ToString());
            }
            
            var mainForm = ServiceLocator.GetService<frmLoadingScreen>();
            var add = ServiceLocator.GetService<frmAdminMain>();
            var Emp = ServiceLocator.GetService<frmStaffMain>();
            EmployeeCreateNew test = new EmployeeCreateNew(ServiceLocator.GetService<DatabaseConnection>());


            Application.Run(add);
        }
    }
}