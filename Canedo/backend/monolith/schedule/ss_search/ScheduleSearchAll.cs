using System.Data;
using CarlosYulo.backend.entities.class_session;
using CarlosYulo.database;
using MySql.Data.MySqlClient;

namespace CarlosYulo.backend.monolith.schedule.ss_search;

public class ScheduleSearchAll
{
    private DatabaseConnection dbConnection;

    public ScheduleSearchAll(DatabaseConnection dbConnection)
    {
        this.dbConnection = dbConnection;
    }

    private string procedure(ClassSessionType type)
    {
        return type switch
        {
            ClassSessionType.FIXED => "prcFixedSessionSearchAll",
            ClassSessionType.PERSONAL => "prcPersonalSessionSearchAll",
            ClassSessionType.ALL => "prcFixedSessionSearchAll",
            _ => "prcFixedSessionSearchAll"
        };
    }


    public List<ClassSession>? SearchSchedulesAll(ClassSessionType type, out string message)
    {
        List<ClassSession> classSessions = new List<ClassSession>();
        string prc = procedure(type);


        try
        {
            if (dbConnection.transaction == null)
            {
                dbConnection.transaction = dbConnection.mysqlConnection.BeginTransaction();
            }

            using (MySqlCommand command = new MySqlCommand(prc, dbConnection.mysqlConnection,
                       dbConnection.transaction))
            {
                command.CommandType = CommandType.StoredProcedure;
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        classSessions.Add(MapSessionMembers(reader, type));
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


    public ClassSession MapSessionMembers(MySqlDataReader reader, ClassSessionType type)
    {
        string sessionType = type switch
        {
            ClassSessionType.FIXED => "Fixed",
            ClassSessionType.PERSONAL => "Personal",
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };


        return new ClassSession()
        {
            SessionType = sessionType,

            SessionId = reader.IsDBNull(reader.GetOrdinal("session_id"))
                ? null
                : reader.GetInt32(reader.GetOrdinal("session_id")),
            SessionTitle = reader.IsDBNull(reader.GetOrdinal("session_title"))
                ? null
                : reader.GetString(reader.GetOrdinal("session_title")),
            SessionDescription = reader.IsDBNull(reader.GetOrdinal("session_description"))
                ? null
                : reader.GetString(reader.GetOrdinal("session_description")),
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