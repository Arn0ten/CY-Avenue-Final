using System.Data;
using CarlosYulo.backend.entities;
using CarlosYulo.database;
using MySql.Data.MySqlClient;

namespace CarlosYulo.backend.monolith.revenue.i_search;

public class RevenueSearchFinalByMonth
{
    private DatabaseConnection dbConnection;

    public RevenueSearchFinalByMonth(DatabaseConnection dbConnection)
    {
        this.dbConnection = dbConnection;
    }

    public FinalRevenueReport? SearchRevenueByMonth(DateTime month, out string message)
    {
        if (month > DateTime.Now)
        {
            message = "Revenue Month Out of Range";
            return null;
        }

        FinalRevenueReport? revenueReport = null;
        try
        {
            using (MySqlCommand command = new MySqlCommand("prcFinalRevenueSearchByMonth", dbConnection.mysqlConnection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("p_date", month);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        revenueReport = MapRevenueReport(reader);
                        message = "Employee search successful";
                        return revenueReport;
                    }

                    message = "No revenue report was found";
                    return null;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private FinalRevenueReport MapRevenueReport(MySqlDataReader reader)
    {
        return new FinalRevenueReport()
        {
            RevenueDate = reader.GetDateTime("revenue_date"),
            OriginalRevenue = reader.GetDouble("original_revenue"),
            TotalLiability = reader.GetDouble("liabilities"),
            FinalRevenue = reader.GetDouble("final_revenue"),
        };
    }

}