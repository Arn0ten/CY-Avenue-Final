using csCY_Avenue.backend.entities;

namespace csCY_Avenue.backend.interfaces.employee;

public interface IEmployee
{
}


public interface IEmployeeAttendance
{
    EmployeeAttendance? CheckEmployeeAttendanceDaily(int employeeId, string fullName, DateTime date);
    List<EmployeeAttendance>? CheckEmployeeAttendanceMonthly(int employeeId, string fullName, DateTime month);
    List<EmployeeAttendance>? CheckEmployeeListAttendanceDaily(DateTime date);
}

