using System.Data;
using CarlosYulo.backend.entities;
using CarlosYulo.database;
using MySql.Data.MySqlClient;

namespace CarlosYulo.backend.monolith.revenue.i_search;

public class RevenueItemSearchAll
{
    private DatabaseConnection dbConnection;
    private string prc;


    public RevenueItemSearchAll(DatabaseConnection dbConnection)
    {
        this.dbConnection = dbConnection;
    }

    public List<ItemSales> SearchItemSalesBetweenDays(DateTime start, DateTime end, out string message)
    {
        prc = "prcRevenueItemSaleSearchBetweenDays";
        return Search(start, end, out message);
    }

    public List<ItemSales> SearchItemSalesByDays(DateTime day, out string message)
    {
        prc = "prcRevenueItemSaleSearchByDay";
        return Search(day, DateTime.Now, out message);
    }


    public List<ItemSales> SearchItemSalesByMonth(DateTime month, out string message)
    {
        prc = "prcRevenueItemSaleSearchByMonth";
        return Search(month, DateTime.Now, out message);
    }

    public List<ItemSales> SearchItemSalesAll(out string message)
    {
        prc = "prcRevenueItemSaleSearchAll";
        return Search(DateTime.Now, DateTime.Now, out message);
    }


    private List<ItemSales> Search(DateTime time1, DateTime time2, out string message)
    {
        var itemSales = new List<ItemSales>();
        
        try
        {
            if (dbConnection is null)
            {
                dbConnection.transaction = dbConnection.mysqlConnection.BeginTransaction();
            }

            using (MySqlCommand command = new MySqlCommand(prc, dbConnection.mysqlConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                if (prc == "prcRevenueItemSaleSearchBetweenDays")
                {
                    command.Parameters.AddWithValue("p_start_date", time1);
                    command.Parameters.AddWithValue("p_end_date", time2);
                    command.Parameters.AddWithValue("p_recorded_status", null);
                }
                else if (prc == "prcRevenueItemSaleSearchByDay")
                {
                    command.Parameters.AddWithValue("p_day", time1);
                }
                else if (prc == "prcRevenueItemSaleSearchByMonth")
                {
                    command.Parameters.AddWithValue("p_month", time1);
                }
                else if (prc == "prcRevenueItemSaleSearchAll")
                {
                    command.Parameters.AddWithValue("p_recorded_status", null);
                }


                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        message = "No revenue report was found";
                        return itemSales;
                    }

                    while (reader.Read())
                    {
                        itemSales.Add(ItemMapRevenueReport(reader));
                        message = "Employee search successful";
                    }

                    message = "revenue report was found";
                    return itemSales;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private ItemSales ItemMapRevenueReport(MySqlDataReader reader)
    {
        return new ItemSales()
        {
            ItemSaleDate = reader.GetDateTime("sold_at"),
            ItemSalesId = reader.GetInt32("item_id"),
            ItemName = reader.GetString("item_name"),
            ItemCategory = reader.GetString("item_category"),
            ItemTotalSales = reader.GetDouble("sale"),
            ItemQuantitiesSold = reader.GetInt32("quantity_sold"),
            ItemPriceSold = reader.GetDouble("price")
        };
    }
}