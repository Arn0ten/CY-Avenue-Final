using csCY_Avenue.database;
using csCY_Avenue.backend.entities;
using csCY_Avenue.backend.interfaces.client;
using csCY_Avenue.backend.interfaces.generic;
using csCY_Avenue.backend.monolith;
using csCY_Avenue.backend.monolith.client;
using csCY_Avenue.backend.monolith.common;
using csCY_Avenue.backend.monolith.employee;
using csCY_Avenue.backend.monolith.systemAccount;
using Microsoft.Extensions.DependencyInjection;

namespace csCY_Avenue
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            DependencyInjection(services);

            var serviceProvider = services.BuildServiceProvider();

            var dbConnector = serviceProvider.GetService<DatabaseConnector>();
            if (dbConnector.TestConnection())
            {
                Console.WriteLine("Connection successful!");
            }
            else
            {
                Console.WriteLine("Failed to connect to the database.");
                return; // Exit the application if the connection fails
            }
            
            //gitanggal nako kay walay form 1 ang front end!!!!!!!!!!!!!!!!!!!!11111111

            //var mainForm = serviceProvider.GetService<Form1>();
            //if (mainForm != null)
            //{
            //    Application.Run(mainForm);
            //}
            //else
            //{
            //    Console.WriteLine("Failed to create the main form.");
            //}
        }

        // DEPENDENCY INJECTION / INVERSION OF CONTROL... IOC 
        private static void DependencyInjection(IServiceCollection services)
        {
            // Database
            services.AddScoped<DatabaseConnector>(
                provider =>
                    new DatabaseConnector(
                        "localhost",
                        "cy",
                        "root",
                        "123456",
                        "3306"));

            // Client Concrete Classes
            services.AddScoped<ICreate<Client>, ClientCreate>();
            services.AddScoped<IUpdate<Client>, ClientUpdate>();
            services.AddScoped<IDelete<Client>, ClientDelete>();
            services.AddScoped<ISearch<Client, string>, ClientSearch>();
            services.AddScoped<IClientUpdate, ClientUpdate>();
            services.AddScoped<IClientCreate, ClientCreate>();
            services.AddScoped<IClientEmail, ClientEmail>();

            // Employee Concrete Classes
            services.AddScoped<ISearch<Employee, int?>, EmployeeSearch>();

            // SystemAccount Concrete Classes
            services.AddScoped<IDelete<SystemAccount>, SystemAccountDelete>();
            services.AddScoped<ICreate<SystemAccount>, SystemAccountCreate>();

            // Concrete Classes
            services.AddScoped<ClientSearch>();
            services.AddScoped<PasswordHashing>();
            services.AddScoped<SystemAccountSearch>();
            services.AddScoped<SystemAccountDelete>();
            services.AddScoped<SystemAccountCreate>();
            services.AddScoped<ImageViewer>();

            // Test Classes
            


            // Register EmailSendBase to its concrete class
            services.AddScoped<EmailSendBase, ClientEmail>();
            services.AddScoped<ClientEmail>();

            // Register your services
            services.AddScoped<ClientService>();
            services.AddScoped<EmployeeService>();

            // Form 1
        }
    }
}