using System;
using System.Data;
using CarlosYulo.database;
using csCY_Avenue.Canedo.backend.entities;
using MySql.Data.MySqlClient;

namespace CarlosYulo.backend.monolith.shop.i_revenue
{
    public class RevenueGenerateItemInvoice
    {
        private DatabaseConnection dbConnection;

        public RevenueGenerateItemInvoice(DatabaseConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public bool GenerateItemInvoice(ItemInvoice itemInvoice, out string message)
        {
            try
            {
                if (dbConnection.transaction is null)
                {
                    dbConnection.transaction = dbConnection.mysqlConnection.BeginTransaction();
                }

                using (MySqlCommand command = new MySqlCommand("prcItemInvoiceCreate", dbConnection.mysqlConnection,
                           dbConnection.transaction))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("p_merchandise", itemInvoice.Merchandise);
                    command.Parameters.AddWithValue("p_equipment", itemInvoice.Equipment);
                    command.Parameters.AddWithValue("p_supplement", itemInvoice.Supplement);
                    command.Parameters.AddWithValue("p_discount", itemInvoice.Discount);
                    command.Parameters.AddWithValue("p_total", itemInvoice.TotalPrice);

                    // Execute and read the result
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate the itemInvoice object with the retrieved data
                            itemInvoice.Id = reader.GetInt32("id");
                            itemInvoice.Merchandise = reader.GetDouble("merchandise");
                            itemInvoice.Equipment = reader.GetDouble("equipment");
                            itemInvoice.Supplement = reader.GetDouble("supplement");
                            itemInvoice.Discount = reader.GetDouble("discount");
                            itemInvoice.TotalPrice = reader.GetDouble("total");
                            itemInvoice.RecordedAt = reader.GetDateTime("recorded_at");
                        }
                    }
                }

                // Commit the transaction
                dbConnection.transaction.Commit();
                dbConnection.transaction = null;
            }
            catch (Exception e)
            {
                // Rollback the transaction in case of an error
                if (dbConnection.transaction != null)
                {
                    dbConnection.transaction.Rollback();
                    dbConnection.transaction = null;
                }

                Console.WriteLine(e);
                message = e.Message; // Set the message to the exception message
                return false; // Indicate failure
            }

            message = string.Empty; // No errors
            return true; // Indicate success
        }
    }
}