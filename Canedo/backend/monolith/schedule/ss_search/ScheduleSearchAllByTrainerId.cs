using System.Data;
using CarlosYulo.backend.entities.class_session;
using CarlosYulo.database;
using MySql.Data.MySqlClient;

namespace CarlosYulo.backend.monolith.schedule.ss_search;

public class ScheduleSearchAllByTrainerId
{
    private DatabaseConnection dbConnection;

    public ScheduleSearchAllByTrainerId(DatabaseConnection dbConnection)
    {
        this.dbConnection = dbConnection;
    }


    public List<ClassSession>? SearchSchedulesAllById(int trainerId, out string message)
    {
        List<ClassSession> classSessions = new List<ClassSession>();


        try
        {
            if (dbConnection.transaction == null)
            {
                dbConnection.transaction = dbConnection.mysqlConnection.BeginTransaction();
            }

            using (MySqlCommand command = new MySqlCommand("prcPersonalSessionSearchTrainerId",
                       dbConnection.mysqlConnection,
                       dbConnection.transaction))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("p_trainer_id", trainerId);
                
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        classSessions.Add(MapSessionMembers(reader));
                    }
                }
            }

            dbConnection.transaction.Commit();
            dbConnection.transaction = null;
            message = string.Empty;
            return classSessions;
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
            return null;
        }
    }


    public ClassSession MapSessionMembers(MySqlDataReader reader)
    {
        return new ClassSession()
        {
            SessionType = "Personal",

            SessionId = reader.IsDBNull(reader.GetOrdinal("session_id"))
                ? null
                : reader.GetInt32(reader.GetOrdinal("session_id")),
            SessionTitle = reader.IsDBNull(reader.GetOrdinal("session_title"))
                ? null
                : reader.GetString(reader.GetOrdinal("session_title")),
            TrainerId = reader.IsDBNull(reader.GetOrdinal("trainer_id"))
                ? null
                : reader.GetInt32(reader.GetOrdinal("trainer_id")),
            TrainerName = reader.IsDBNull(reader.GetOrdinal("trainer"))
                ? null
                : reader.GetString(reader.GetOrdinal("trainer")),
            SessionRoomNumber = reader.IsDBNull(reader.GetOrdinal("room"))
                ? null
                : reader.GetInt32(reader.GetOrdinal("room")),
            SessionStartAt = reader.IsDBNull(reader.GetOrdinal("start_at"))
                ? null
                : reader.GetDateTime(reader.GetOrdinal("start_at")),
            SessionEndAt = reader.IsDBNull(reader.GetOrdinal("end_at"))
                ? null
                : reader.GetDateTime(reader.GetOrdinal("end_at"))
        };
    }
}