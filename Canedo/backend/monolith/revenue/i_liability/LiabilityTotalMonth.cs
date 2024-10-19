using System.Data;
using CarlosYulo.backend.entities;
using CarlosYulo.database;
using MySql.Data.MySqlClient;

namespace CarlosYulo.backend.monolith.revenue.i_liability;

public class LiabilityTotalMonth
{
    private DatabaseConnection dbConnection;

    public LiabilityTotalMonth(DatabaseConnection dbConnection)
    {
        this.dbConnection = dbConnection;
    }


    public GeneralLiabilityReport? GenerateLiabilityReport(DateTime date, out string message)
    {
        GeneralLiabilityReport report = null;
        message = string.Empty; 

        try
        {
            // Begin transaction only if no existing transaction 
            if (dbConnection.transaction is null)
            {
                dbConnection.transaction = dbConnection.mysqlConnection.BeginTransaction();
            }

            using (MySqlCommand command = new MySqlCommand("prcLiabilityMonthlyReport",
                       dbConnection.mysqlConnection,
                       dbConnection.transaction))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("p_date", date);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        dbConnection.transaction.Rollback();
                        dbConnection.transaction = null;
                        message = "No records found";
                        return null;
                    }

                    if (reader.Read())
                    {
                        report = new GeneralLiabilityReport
                        {
                            IncurredAt = reader.GetDateTime("incurred_at"),
                            TotalSalaryCost = reader.GetDouble("salary_cost"),
                            TotalItemRestockCost = reader.GetDouble("item_restock_cost"),
                            TotalCost = reader.GetDouble("total_liability")
                        };
                    }
                }

                dbConnection.transaction.Commit();
                dbConnection.transaction = null;
            }
        }
        catch (Exception e)
        {
            // Rollback transaction on error
            if (dbConnection.transaction != null)
            {
                dbConnection.transaction.Rollback();
                dbConnection.transaction = null;
            }

            Console.WriteLine(e);
            message = e.Message; // Assign the error message
            return null; // Return null in case of an error
        }

        return report; // Return the populated report

    }
}