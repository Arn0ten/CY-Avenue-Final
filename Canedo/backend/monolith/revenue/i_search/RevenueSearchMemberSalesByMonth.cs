using System.Data;
using CarlosYulo.backend.entities;
using CarlosYulo.database;
using MySql.Data.MySqlClient;

namespace CarlosYulo.backend.monolith.revenue.i_search;

public class RevenueSearchMemberSalesByMonth
{
    private DatabaseConnection dbConnection;
    private string prc = "prcMembershipSalesSearch";

    public RevenueSearchMemberSalesByMonth(DatabaseConnection dbConnection)
    {
        this.dbConnection = dbConnection;
    }

    public List<MembershipSale>? SearchMemberRevenueAll(out string message)
    {
        prc = "prcMembershipSalesSearchAll";
        // DateTime.Now is nothing, no impact
        return search(DateTime.Now, DateTime.Now, out message);
    }

    public List<MembershipSale>? SearchMemberRevenueByMonth(DateTime month, out string message)
    {
        prc = "prcMembershipSalesSearch";
        // DateTime.Now is nothing, no impact
        return search(month, DateTime.Now, out message);
    }

    public List<MembershipSale>? SearchMemberRevenueBetweenDays(DateTime start, DateTime end, out string message)
    {
        prc = "prcMembershipSalesSearchByDateRange";
        // DateTime.Now is nothing, no impact
        return search(start, end, out message);
    }


    public List<MembershipSale>? search(DateTime month, DateTime end, out string message)
    {
        if (month > DateTime.Now && prc == "prcMembershipSalesSearch")
        {
            message = "Revenue Month Out of Range";
            return null;
        }

        List<MembershipSale> result = new List<MembershipSale>();
        try
        {
            using (MySqlCommand command =
                   new MySqlCommand(prc, dbConnection.mysqlConnection))
            {
                command.CommandType = CommandType.StoredProcedure;
                
                if (prc == "prcMembershipSalesSearch")
                {
                    command.Parameters.AddWithValue("p_date", month);
                }
                else if (prc == "prcMembershipSalesSearchByDateRange")
                {
                    command.Parameters.AddWithValue("p_start_date", month);
                    command.Parameters.AddWithValue("p_end_date", end);
                }

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        message = "No revenue report was found";
                        return result;
                    }

                    while (reader.Read())
                    {
                        MembershipSale revenueReport = MapRevenueReport(reader);
                        result.Add(revenueReport);
                    }

                    message = "No revenue report was found";
                    return result;
                }
            }
        }
        catch (Exception ex)
        {
            message = "Revenue Month Out of Range";
            Console.WriteLine(ex);
            throw;
        }
    }

    private MembershipSale MapRevenueReport(MySqlDataReader reader)
    {
        return new MembershipSale()
        {
            member_id = reader.GetInt32("member_id"),
            member_name = reader.GetString("member_name"),
            membership_type = reader.GetString("membership_type"),
            price = reader.GetDouble("price"),
            status = reader.GetString("status"),
            sold_at = reader.GetDateTime("sold_at"),
        };
    }
}