using System.Data;
using CarlosYulo.database;
using csCY_Avenue.Canedo.backend.entities;
using MySql.Data.MySqlClient;

namespace CarlosYulo.backend.monolith.client;

public class ClientAttendanceSearchAll
{
    private DatabaseConnection dbConnection;

    public ClientAttendanceSearchAll(DatabaseConnection dbConnection)
    {
        this.dbConnection = dbConnection;
    }

    public List<ClientAttendance> SearchClientAttendanceAll()
    {
        var client = new List<ClientAttendance>();

        try
        {
            // encase with 'using' to ensure proper dispose
            using (var command = new MySqlCommand("prcClientAttendanceSearchAll", dbConnection.mysqlConnection))
            {
                command.CommandType = CommandType.StoredProcedure;
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // retrieve rows and set in object
                    while (reader.Read())
                    {
                        client.Add(MapAttendance(reader));
                    }

                    Console.WriteLine("Retrieving CLIENTS ATTENDANCE multiple rows in list successfully");
                }
            }

            return client;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return client;
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