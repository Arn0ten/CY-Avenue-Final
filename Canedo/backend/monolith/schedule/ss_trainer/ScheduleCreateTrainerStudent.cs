using System.Data;
using CarlosYulo.backend.entities.class_session;
using CarlosYulo.database;
using MySql.Data.MySqlClient;

namespace CarlosYulo.backend.monolith.schedule.ss_trainer;

public class ScheduleCreateTrainerStudent
{
    private DatabaseConnection dbConnection;


    public ScheduleCreateTrainerStudent(DatabaseConnection dbConnection)
    {
        this.dbConnection = dbConnection;
    }

    public bool CreateStudent(TrainerStudent? trainerStudent, out string message)
    {
        if (trainerStudent is null)
        {
            message = "No trainer selected";
            return false;
        }

        List<string> missingFields = new List<string>();
        ValidateFields(trainerStudent, missingFields);

        if (missingFields.Any())
        {
            message = $"Missing fields: {string.Join(", ", missingFields)}";
            return false;
        }


        try
        {
            if (dbConnection.transaction == null)
            {
                dbConnection.transaction = dbConnection.mysqlConnection.BeginTransaction();
            }

            using (MySqlCommand command = new MySqlCommand("prcTrainerStudentCreate", dbConnection.mysqlConnection,
                       dbConnection.transaction))
            {
                command.CommandType = CommandType.StoredProcedure;
                NewScheduleFixedMap(command, trainerStudent);

                command.ExecuteNonQuery();

                dbConnection.transaction.Commit();
                dbConnection.transaction = null;
                message = $"New student {trainerStudent.StudentName} created successfully for {trainerStudent.StudentName}";
                return true;
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

    private void NewScheduleFixedMap(MySqlCommand command, TrainerStudent student)
    {
        command.Parameters.AddWithValue("p_trainer_id", student.TrainerId);
        command.Parameters.AddWithValue("p_trainer_name", student.TrainerName?.TrimEnd());
        command.Parameters.AddWithValue("p_student_id", student.StudentId);
        command.Parameters.AddWithValue("p_student_name", student.StudentName?.TrimEnd());
        command.Parameters.AddWithValue("p_joined_at", student.StartDate);
        command.Parameters.AddWithValue("p_status", student.Status);
    }

    private void ValidateFields(TrainerStudent student, List<string> missingFields)
    {
        if (string.IsNullOrWhiteSpace(student.TrainerName))
        {
            missingFields.Add("Trainer Name");
        }

        if (string.IsNullOrWhiteSpace(student.StudentName))
        {
            missingFields.Add("Student Name");
        }

        if (student.TrainerId == null)
        {
            missingFields.Add("Trainer ID");
        }

        if (student.StudentId == null)
        {
            missingFields.Add("Student ID");
        }
    }
}