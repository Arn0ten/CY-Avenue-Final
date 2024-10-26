using System.Data;
using CarlosYulo.database;
using csCY_Avenue.Canedo.backend.entities;
using MySql.Data.MySqlClient;

namespace CarlosYulo.backend.monolith.client;

public class ClientAttendanceCreate
{
    private DatabaseConnection dbConnection;

    public ClientAttendanceCreate(DatabaseConnection dbConnection)
    {
        this.dbConnection = dbConnection;
    }

    public bool CreateAttendance(ClientAttendance clientAttendance, out string message)
    {
        List<string> missingFields = new List<string>();
        ValidateFields(clientAttendance, missingFields);

        // Create error message
        if (missingFields.Count > 0)
        {
            message = "Please fill out the following missing fields: " + string.Join(", ", missingFields);
            return false;
        }

        try
        {
            if (dbConnection.transaction == null)
            {
                dbConnection.transaction = dbConnection.mysqlConnection.BeginTransaction();
            }

            using (MySqlCommand command = new MySqlCommand("prcClientAttendanceCreate", dbConnection.mysqlConnection,
                       dbConnection.transaction))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("p_membership_id", clientAttendance.ClientId);
                command.Parameters.AddWithValue("p_member_name", clientAttendance.ClientName);
                command.Parameters.AddWithValue("p_date", clientAttendance.Date);
                command.Parameters.AddWithValue("p_check_in_time", clientAttendance.CheckInTime);
                command.Parameters.AddWithValue("p_attendance_status", clientAttendance.Status?.TrimEnd());

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    dbConnection.transaction.Commit();
                    dbConnection.transaction = null;
                    message = $"Attendance {clientAttendance.ClientName} created successfully";
                    return true;
                }

                dbConnection.transaction.Rollback();
                dbConnection.transaction = null;
                message = "Failed to create attendance";
                return false;
            }
        }
        catch (Exception e)
        {
            if (dbConnection.transaction != null)
            {
                dbConnection.transaction.Rollback();
                dbConnection.transaction = null;
            }

            Console.WriteLine(e);
            message = e.Message;
            return false;
        }
    }

    private void ValidateFields(ClientAttendance client, List<string> missingFields)
    {
        // Check if Date is valid
        if (client.Date == DateTime.MinValue)
        {
            missingFields.Add("Date is required.");
        }

        // Check if CheckInTime is valid
        if (client.CheckInTime == DateTime.MinValue)
        {
            missingFields.Add("Check-in time is required.");
        }
        else if (client.CheckInTime.TimeOfDay > DateTime.Now.TimeOfDay)
        {
            missingFields.Add("Check-in time cannot be in the future.");
        }
    }
}