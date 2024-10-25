using Autofac;
using Autofac.Extensions.DependencyInjection;
using CarlosYulo.backend;
using CarlosYulo.backend.monolith;
using CarlosYulo.backend.monolith.client;
using CarlosYulo.backend.monolith.client.c_create;
using CarlosYulo.backend.monolith.common;
using CarlosYulo.backend.monolith.create;
using CarlosYulo.backend.monolith.delete;
using CarlosYulo.backend.monolith.employee;
using CarlosYulo.backend.monolith.employee.attendance;
using CarlosYulo.backend.monolith.employee.create;
using CarlosYulo.backend.monolith.employee.delete;
using CarlosYulo.backend.monolith.employee.salary;
using CarlosYulo.backend.monolith.employee.search;
using CarlosYulo.backend.monolith.employee.update;
using CarlosYulo.backend.monolith.item;
using CarlosYulo.backend.monolith.revenue;
using CarlosYulo.backend.monolith.revenue.i_liability;
using CarlosYulo.backend.monolith.schedule;
using CarlosYulo.backend.monolith.schedule.ss_delete;
using CarlosYulo.backend.monolith.schedule.ss_search;
using CarlosYulo.backend.monolith.session.ss_create;
using CarlosYulo.backend.monolith.shop;
using CarlosYulo.backend.monolith.shop.i_revenue;
using CarlosYulo.backend.monolith.systemAccount;
using CarlosYulo.backend.monolith.systemAccount.sy_login;
using CarlosYulo.database;
using csCY_Avenue.AuthPage;
using Autofac.Extensions.DependencyInjection;
using CarlosYulo.backend.monolith.revenue.i_search;
using CarlosYulo.preload;
using csCY_Avenue.Admin_Interface.Main;


namespace CarlosYulo
{
    public static class IoC
    {
        public static IServiceProvider ConfigureServices()
        {
            var builder = new ContainerBuilder();
            RegisterServices(builder);

            var container = builder.Build();

            // Return IServiceProvider from the IContainer
            return new AutofacServiceProvider(container);
        }

        private static void RegisterServices(ContainerBuilder builder)
        {
            // Database
            builder.Register(c =>
                    new DatabaseConnection("localhost", "cy", "root", "123456", "3306"))
                .AsSelf()
                .InstancePerLifetimeScope();

            // Common
            CommonClassDependencies(builder);

            // Controller / Services
            ClientController(builder);
            ClientConcreteDependencies(builder);

            EmployeeController(builder);
            EmployeeConcreteDependencies(builder);

            SystemAccountController(builder);
            SystemAccountConcreteDependencies(builder);

            ItemController(builder);
            ItemConcreteDependencies(builder);

            RevenueController(builder);
            RevenueConcreteDependencies(builder);

            ScheduleController(builder);
            ScheduleConcreteDependencies(builder);

            builder.RegisterType<frmLoadingScreen>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<frmStaffLogin>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<frmAdminMain>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<PreloadRevenueData>().AsSelf().InstancePerLifetimeScope();
        }

        // Common Class Dependencies
        private static void CommonClassDependencies(ContainerBuilder builder)
        {
            builder.RegisterType<ErrorMessageBox>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ImageViewer>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<PasswordHashing>().AsSelf().InstancePerLifetimeScope();
        }

        private static void ClientController(ContainerBuilder builder)
        {
            builder.RegisterType<ClientController>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ClientCreateServices>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ClientUpdateServices>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ClientSearchServices>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ClientDeleteServices>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ClientEmailService>().AsSelf().InstancePerLifetimeScope();
        }

        private static void ClientConcreteDependencies(ContainerBuilder builder)
        {
            builder.RegisterType<ClientCreateMember>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ClientCreateWalkIn>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ClientUpdateDetails>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ClientUpdateMembership>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ClientUpdateProfilePicture>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ClientUpdateStatus>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ClientSearchAll>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ClientSearchById>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ClientSearchByName>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ClientDelete>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ClientDeleteAllExpired>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ClientEmailWelcome>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ClientEmailExpire>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ClientEmailRenewed>().AsSelf().InstancePerLifetimeScope();
        }

        private static void EmployeeController(ContainerBuilder builder)
        {
            builder.RegisterType<EmployeeController>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeOtherServices>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeAttendanceServices>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeSearchServices>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeUpdateServices>().AsSelf().InstancePerLifetimeScope();
        }

        private static void EmployeeConcreteDependencies(ContainerBuilder builder)
        {
            builder.RegisterType<EmployeeCreateNew>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeDelete>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeSalaryUpdate>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeAttendanceCreate>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeAttendanceSearchAll>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeAttendanceSearchDaily>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeAttendanceSearchMonthly>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeSearchAll>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeSearchById>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeSearchByName>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeUpdateDetails>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeUpdateProfilePicture>().AsSelf().InstancePerLifetimeScope();
        }

        private static void SystemAccountController(ContainerBuilder builder)
        {
            // controller
            builder.RegisterType<SystemAccountController>().AsSelf().InstancePerLifetimeScope();
            // services
            builder.RegisterType<SystemAccountOtherServices>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<SystemAccountLoginServices>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<SystemAccountSearchServices>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<SystemAccountUpdateServices>().AsSelf().InstancePerLifetimeScope();
        }

        private static void SystemAccountConcreteDependencies(ContainerBuilder builder)
        {
            builder.RegisterType<SystemAccountCreate>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<SystemAccountDelete>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<SystemAccountEmail>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<SystemAccountCheckAccount>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<SystemAccountCompareVerification>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<SystemAccountVerification>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<SystemAccountVerificationDelete>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<SystemAccountSearchAll>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<SystemAccountSearchByEmail>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<SystemAccountSearchById>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<SystemAccountUpdateDetails>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<SystemAccountUpdatePassword>().AsSelf().InstancePerLifetimeScope();
        }

        private static void ItemController(ContainerBuilder builder)
        {
            builder.RegisterType<ItemController>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ItemCreateServices>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ItemSearchServices>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ItemUpdateServices>().AsSelf().InstancePerLifetimeScope();
        }

        private static void ItemConcreteDependencies(ContainerBuilder builder)
        {
            builder.RegisterType<ItemCreate>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ItemSearchAll>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ItemSearchByCategory>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ItemSearchById>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ItemBuy>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ItemRestockQuantity>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ItemUpdateDetails>().AsSelf().InstancePerLifetimeScope();
        }

        private static void RevenueController(ContainerBuilder builder)
        {
            // controller
            builder.RegisterType<RevenueController>().AsSelf().InstancePerLifetimeScope();
            // services
            builder.RegisterType<RevenueSaleServices>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<RevenueLiabilityServices>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<RevenueSearchServices>().AsSelf().InstancePerLifetimeScope();
        }

        private static void RevenueConcreteDependencies(ContainerBuilder builder)
        {
            builder.RegisterType<RevenueGenerateFinalReport>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<RevenueGeneratePartialReport>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<RevenueGenerateItemSaleReport>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<RevenueGenerateMembershipSalesReport>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<LiabilityTotalMonth>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<LiabilityEmployeeSalary>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<LiabilityItemRestock>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<RevenueSearchFinalByMonth>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<RevenueSearchMemberSalesByMonth>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<RevenueItemSearchAll>().AsSelf().InstancePerLifetimeScope();
        }

        private static void ScheduleController(ContainerBuilder builder)
        {
            // Register the ScheduleController itself
            builder.RegisterType<ScheduleController>().AsSelf();

            // Register schedule services
            builder.RegisterType<ScheduleCreateServices>().AsSelf();
            builder.RegisterType<ScheduleDeleteServices>().AsSelf();
            builder.RegisterType<ScheduleSearchServices>().AsSelf();
        }

        private static void ScheduleConcreteDependencies(ContainerBuilder builder)
        {
            // delete
            builder.RegisterType<ScheduleDeleteAllPrevious>().AsSelf();
            builder.RegisterType<ScheduleDeleteAllByDay>().AsSelf();

            // create
            builder.RegisterType<ScheduleCreateFixed>().AsSelf();
            builder.RegisterType<ScheduleCreatePersonal>().AsSelf();
            builder.RegisterType<ScheduleCreatePersonalClassMembers>().AsSelf();

            // search
            builder.RegisterType<ScheduleSearchAll>().AsSelf();
        }
    }
}