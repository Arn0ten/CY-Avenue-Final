using System.Data;
using CarlosYulo.backend.entities.class_session;
using CarlosYulo.database;
using MySql.Data.MySqlClient;

namespace CarlosYulo.backend.monolith.schedule.ss_trainer;

public class ScheduleSearchTrainerStudent
{
    private DatabaseConnection dbConnection;

    public ScheduleSearchTrainerStudent(DatabaseConnection dbConnection)
    {
        this.dbConnection = dbConnection;
    }

    public List<TrainerStudent> GetTrainerStudents(int trainerId, out string message)
    {
        if (trainerId.ToString().Length != 6)
        {
            message = "Invalid trainer ID";
            return new List<TrainerStudent>();
            ;
        }

        List<TrainerStudent> classSessions = new List<TrainerStudent>();

        try
        {
            if (dbConnection.transaction == null)
            {
                dbConnection.transaction = dbConnection.mysqlConnection.BeginTransaction();
            }

            using (MySqlCommand command = new MySqlCommand("prcTrainerStudentsSearchByTrainerId",
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


    public TrainerStudent MapSessionMembers(MySqlDataReader reader)
    {
        return new TrainerStudent()
        {
            TrainerId = reader.IsDBNull(reader.GetOrdinal("trainer_id"))
                ? null
                : reader.GetInt32(reader.GetOrdinal("trainer_id")),
            TrainerName = reader.IsDBNull(reader.GetOrdinal("trainer_name"))
                ? null
                : reader.GetString(reader.GetOrdinal("trainer_name")),
            StudentId = reader.IsDBNull(reader.GetOrdinal("student_id"))
                ? null
                : reader.GetInt32(reader.GetOrdinal("student_id")),
            StudentName = reader.IsDBNull(reader.GetOrdinal("student_name"))
                ? null
                : reader.GetString(reader.GetOrdinal("student_name")),
            StartDate = reader.IsDBNull(reader.GetOrdinal("joined_at"))
                ? null
                : reader.GetDateTime(reader.GetOrdinal("joined_at")),
            Status = reader.IsDBNull(reader.GetOrdinal("status"))
                ? null
                : reader.GetString(reader.GetOrdinal("status")),
        };
    }
}