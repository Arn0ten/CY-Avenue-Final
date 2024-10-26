using System.Data;
using CarlosYulo.database;
using csCY_Avenue.Canedo.backend.entities;
using MySql.Data.MySqlClient;

namespace CarlosYulo.backend.monolith.shop.i_revenue;

public class RevenueGeneratePendingMembership
{
    private DatabaseConnection dbConnection;


    public RevenueGeneratePendingMembership(DatabaseConnection dbConnection)
    {
        this.dbConnection = dbConnection;
    }

    public MembershipPending? GeneratePendingMembership(Client client)
    {
        if (client is null)
        {
            return null;
        }

        MembershipPending pending = new MembershipPending();
        double price = client.MembershipTypeId switch
        {
            1 => 850,
            2 => 1250,
            3 => 75,
            _ => 850
        };

        try
        {
            if (dbConnection.transaction is null)
            {
                dbConnection.transaction = dbConnection.mysqlConnection.BeginTransaction();
            }

            using (MySqlCommand command = new MySqlCommand("prcMembershipPendingCreate",
                       dbConnection.mysqlConnection,
                       dbConnection.transaction))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("p_membership_id", client.MembershipId);
                command.Parameters.AddWithValue("p_member_name", client.FullName);
                command.Parameters.AddWithValue("p_membership_type", client.Membership);
                command.Parameters.AddWithValue("p_price", price);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        pending.membership_id = reader.GetInt32("membership_id");
                        pending.member_name = reader.GetString("member_name");
                        pending.membership_type = reader.GetString("membership_type");
                        pending.price = reader.GetDouble("price");
                        pending.create_at = reader.GetDateTime("created_at");
                        pending.status = reader.GetBoolean("status");
                    }
                }

                dbConnection.transaction.Commit();
                dbConnection.transaction = null;
                return pending;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            dbConnection.transaction.Rollback();
            dbConnection.transaction = null;
            throw;
        }
    }
}