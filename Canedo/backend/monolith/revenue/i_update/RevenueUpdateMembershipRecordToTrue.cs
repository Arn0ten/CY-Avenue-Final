using System.Data;
using CarlosYulo.database;
using MySql.Data.MySqlClient;

namespace CarlosYulo.backend.monolith.revenue.i_update;

public class RevenueUpdateMembershipRecordToTrue
{
    private DatabaseConnection dbConnection;

    public RevenueUpdateMembershipRecordToTrue(DatabaseConnection dbConnection)
    {
        this.dbConnection = dbConnection;
    }

    public bool UpdateMembershipRecordToTrue(int membershipId)
    {
        try
        {
            // Check if transaction is null and start it if necessary
            if (dbConnection.transaction == null)
            {
                dbConnection.transaction = dbConnection.mysqlConnection.BeginTransaction();
            }

            using (MySqlCommand command = new MySqlCommand("prcMembershipPendingUpdateToTrueById",
                       dbConnection.mysqlConnection, dbConnection.transaction))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("p_membership_id", membershipId);

                if (command.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Successfully updated Membership Record to True.");
                    dbConnection.transaction.Commit(); // Commit the transaction
                    dbConnection.transaction = null; // Reset the transaction
                    return true;
                }

                Console.WriteLine("Falied updated Membership Record to True.");
                dbConnection.transaction.Rollback(); // Commit the transaction
                dbConnection.transaction = null; // Reset the transaction
                return false;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Falied updated Membership Record to True.");
            Console.WriteLine(e);
            if (dbConnection.transaction != null)
            {
                dbConnection.transaction.Rollback(); // Rollback if there's an exception
                dbConnection.transaction = null;
            }

            throw; // Re-throw the exception for further handling
        }
    }
}