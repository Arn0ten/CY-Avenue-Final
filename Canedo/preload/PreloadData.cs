using CarlosYulo.backend;
using CarlosYulo.backend.entities.class_session;
using CarlosYulo.backend.monolith.client;
using CarlosYulo.backend.monolith.employee;
using CarlosYulo.backend.monolith.employee.search;
using CarlosYulo.backend.monolith.schedule;

namespace CarlosYulo.preload;

public class PreloadData
{
    public static List<Client> Clients { get;  set; }
    public static List<Client> Members { get;  set; }
    public static List<Employee> Employee { get; set; }
    // public static List<ClassSession> Classes { get; private set; }

    private static readonly ClientController _clientController = ServiceLocator.GetService<ClientController>();
    private static readonly EmployeeController _employeeController = ServiceLocator.GetService<EmployeeController>();
    // private static readonly ScheduleController _scheduleController = ServiceLocator.GetService<ScheduleController>();

    public static void PreLoad()
    {
        try
        {
            Clients = _clientController.SearchAll("all");
            Members = _clientController.SearchAll("members");
            Employee = _employeeController.SearchAll(EmployeTypeEnum.ALL);
            // Classes = _scheduleController.LoadAllClasses(); 

            Console.WriteLine("Preload completed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during data preload: {ex.Message}");
        }
    }

    public static void PreLoadClients()
    {
        try
        {
            Clients = _clientController.SearchAll("all");
            Console.WriteLine("Preload completed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during data preload: {ex.Message}");
        }
    }

    public static void PreLoadMembers()
    {
        try
        {
            Members = _clientController.SearchAll("members");
            Console.WriteLine("Preload completed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during data preload: {ex.Message}");
        }
    }

    public static void PreLoadEmployees()
    {
        try
        {
            Employee = _employeeController.SearchAll(EmployeTypeEnum.ALL);
            Console.WriteLine("Preload completed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during data preload: {ex.Message}");
        }
    }


    public static void UpdateClientsAdd(Client client)
    {
        Clients.Add(client);
    }

    public static void UpdateMembersAdd(Client client)
    {
        Members.Add(client);
    }

    public static void UpdateEmployeeAdd(Employee employee)
    {
        Employee.Add(employee);
    }
}