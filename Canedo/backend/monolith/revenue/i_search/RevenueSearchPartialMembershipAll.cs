using System.Data;
using CarlosYulo.database;
using csCY_Avenue.Canedo.backend.entities;
using MySql.Data.MySqlClient;

namespace CarlosYulo.backend.monolith.revenue.i_search;

public class RevenueSearchPartialMembershipAll
{
    private DatabaseConnection dbConnection;

    public RevenueSearchPartialMembershipAll(DatabaseConnection dbConnection)
    {
        this.dbConnection = dbConnection;
    }

    public List<MembershipPending> SearchPartialMembersAll()
    {
        var pendings = new List<MembershipPending>();

        try
        {
            if (dbConnection.transaction is null)
            {
                dbConnection.transaction = dbConnection.mysqlConnection.BeginTransaction();
            }

            using (MySqlCommand command = new MySqlCommand("prcMembershipPendingSearchAll",
                       dbConnection.mysqlConnection,
                       dbConnection.transaction))
            {
                command.CommandType = CommandType.StoredProcedure;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Create a new MembershipPending object for each record
                        var pending = new MembershipPending
                        {
                            Id = reader.GetInt32("id"),
                            membership_id = reader.GetInt32("membership_id"),
                            member_name = reader.GetString("member_name"),
                            membership_type = reader.GetString("membership_type"),
                            price = reader.GetDouble("price"),
                            create_at = reader.GetDateTime("created_at"),
                            status = reader.GetBoolean("status")
                        };

                        // Add the object to the list
                        pendings.Add(pending);
                    }
                }

                dbConnection.transaction.Commit();
                dbConnection.transaction = null;
                return pendings;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            if (dbConnection.transaction != null)
            {
                dbConnection.transaction.Rollback();
                dbConnection.transaction = null;
            }

            throw;
        }
    }
}