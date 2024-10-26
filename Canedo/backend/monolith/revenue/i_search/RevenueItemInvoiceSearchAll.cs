using System;
using System.Collections.Generic;
using System.Data;
using CarlosYulo.database;
using csCY_Avenue.Canedo.backend.entities;
using MySql.Data.MySqlClient;

namespace CarlosYulo.backend.monolith.revenue.i_search
{
    public class RevenueItemInvoiceSearchAll
    {
        private readonly DatabaseConnection dbConnection;

        public RevenueItemInvoiceSearchAll(DatabaseConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public List<ItemInvoice> SearchAllItemInvoice()
        {
            List<ItemInvoice> itemInvoices = new List<ItemInvoice>();

            try
            {
                // Open a transaction if it doesn't already exist
                if (dbConnection.transaction == null)
                {
                    dbConnection.transaction = dbConnection.mysqlConnection.BeginTransaction();
                }

                using (MySqlCommand command = new MySqlCommand("prcItemInvoiceSearchAll", dbConnection.mysqlConnection, dbConnection.transaction))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Execute the stored procedure and read the results
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create a new ItemInvoice object and populate its properties
                            ItemInvoice itemInvoice = new ItemInvoice
                            {
                                Id = reader.GetInt32("id"),
                                Merchandise = reader.GetDouble("merchandise"),
                                Equipment = reader.GetDouble("equipment"),
                                Supplement = reader.GetDouble("supplement"),
                                Discount = reader.GetDouble("discount"),
                                TotalPrice = reader.GetDouble("total"),
                                RecordedAt = reader.GetDateTime("recorded_at")
                            };

                            // Add the itemInvoice to the list
                            itemInvoices.Add(itemInvoice);
                        }
                    }
                }

                // Commit the transaction after successful execution
                dbConnection.transaction.Commit();
                dbConnection.transaction = null; // Reset the transaction
            }
            catch (Exception e)
            {
                // Rollback the transaction in case of an error
                if (dbConnection.transaction != null)
                {
                    dbConnection.transaction.Rollback();
                    dbConnection.transaction = null; // Reset the transaction
                }

                Console.WriteLine(e);
                throw;
            }

            return itemInvoices; // Return the list of item invoices
        }
    }
}
