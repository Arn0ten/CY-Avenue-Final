using CarlosYulo.backend;
using CarlosYulo.backend.monolith.client;
using CarlosYulo.backend.monolith.employee;

namespace CarlosYulo.preload;

public class PreloadAttendanceData
{
    public static List<EmployeeAttendance> All { get; set; }
    public static List<EmployeeAttendance> CurrentMonth { get; set; }
    public static List<EmployeeAttendance> CurrentDay { get; set; }
    
    private static readonly ClientController _clientController = ServiceLocator.GetService<ClientController>();
    private static readonly EmployeeController _employeeController = ServiceLocator.GetService<EmployeeController>();

    public static void preLoadAllAttendance()
    {
        All = _employeeController.SearchAllAttendances(DateTime.Today, AttendanceType.ALL);
        CurrentMonth = _employeeController.SearchAllAttendances(DateTime.Today, AttendanceType.ALL_MONTHLY);
        CurrentDay = _employeeController.SearchAllAttendances(DateTime.Today, AttendanceType.ALL_DAILY);
    }
    
    public static void PreLoadAttendanceAll()
    {
        try
        {
            All = _employeeController.SearchAllAttendances(new DateTime(), AttendanceType.ALL);
            Console.WriteLine("Preload completed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during data preload: {ex.Message}");
        }
    }
    
    public static void PreLoadAttendanceCurrentMonth()
    {
        try
        {
            All = _employeeController.SearchAllAttendances(new DateTime(), AttendanceType.ALL);
            Console.WriteLine("Preload completed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during data preload: {ex.Message}");
        }
    }
    
    public static void PreLoadAttendanceCurrentDay()
    {
        try
        {
            CurrentDay = _employeeController.SearchAllAttendances(DateTime.Today, AttendanceType.ALL_DAILY);
            Console.WriteLine("Preload completed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during data preload: {ex.Message}");
        }
    }

    public static void UpdateAll(EmployeeAttendance employeeAttendance)
    {
        All.Add(employeeAttendance);
    }
    
    public static void UpdateMonth(EmployeeAttendance employeeAttendance)
    {
        CurrentMonth.Add(employeeAttendance);
    }
    
    public static void UpdateDay(EmployeeAttendance employeeAttendance)
    {
        CurrentDay.Add(employeeAttendance);
    }
    
    
}