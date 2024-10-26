using System.Data;
using CarlosYulo.database;
using csCY_Avenue.Canedo.backend.entities;
using MySql.Data.MySqlClient;
using Exception = System.Exception;

namespace CarlosYulo.backend.monolith.client;

public class ClientAttendanceSearchByDay
{
    private DatabaseConnection dbConnection;

    public ClientAttendanceSearchByDay(DatabaseConnection dbConnection)
    {
        this.dbConnection = dbConnection;
    }

    private bool CheckCondition(DateTime attendanceDate, out string message)
    {
        message = string.Empty;
        
        if (attendanceDate == DateTime.MinValue || attendanceDate.Date > DateTime.Now.Date)
        {
            message = "Attendance date cannot be null or in the future.";
            return false;
        }
        
        return true;
    }

    public List<ClientAttendance> SearchClientAttendanceByDay(DateTime attendanceDate, out string message)
    {
        message = string.Empty;
        
        if (!CheckCondition(attendanceDate, out message))
        {
            return new List<ClientAttendance>(); // Return empty list if validation fails
        }

        var clients = new List<ClientAttendance>();
        
        try
        {
            using (var command = new MySqlCommand("prcClientAttendanceSearchAllByDay", dbConnection.mysqlConnection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("p_date", attendanceDate);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clients.Add(MapAttendance(reader));
                    }

                    if (clients.Count > 0)
                    {
                        message = "Client search successful";
                    }
                    else
                    {
                        message = "No attendance records found for the given date.";
                    }
                }
            }

            return clients;
        }
        catch (Exception e)
        {
            message = "An error occurred while fetching attendance data: " + e.Message;
            Console.WriteLine(message);
            return new List<ClientAttendance>(); // Return empty list on exception
        }
    }

    private ClientAttendance MapAttendance(MySqlDataReader reader)
    {
        return new ClientAttendance()
        {
            ClientId = reader.GetInt32("membership_id"),
            ClientName = reader.GetString("member_name"),
            Date = reader.GetDateTime("date"),
            CheckInTime = reader.GetDateTime("check_in_time"),
            Status = reader.GetString("attendance_status"),
        };
    }
}
