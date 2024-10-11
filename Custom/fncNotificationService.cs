using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using csCY_Avenue.Admin_Interface.Main;
using System;
using System.Collections.Generic;
using csCY_Avenue.Database;

namespace csCY_Avenue.Custom
{
    internal class fncNotificationService
    {
        private readonly GlobalProcedure _globalProcedure;

        // Constructor accepting GlobalProcedure instance
        public fncNotificationService(GlobalProcedure db)
        {
            _globalProcedure = db;
        }

        // Add a notification
        public void AddNotification(string type, string message, string relatedEntity)
        {
            string query = "CALL prcAddNotification(@type, @message, @relatedEntity)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(_globalProcedure.strConnection))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@type", type);
                        cmd.Parameters.AddWithValue("@message", message);
                        cmd.Parameters.AddWithValue("@relatedEntity", relatedEntity);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }


        // Get all notifications
        public List<Notification> GetNotifications()
        {
            List<Notification> notifications = new List<Notification>();
            string query = "CALL prcGetNotifications()";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(_globalProcedure.strConnection))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                notifications.Add(new Notification
                                {
                                    NotificationId = reader.GetInt32("id"),
                                    Type = reader.GetString("type"),
                                    Message = reader.GetString("message"),
                                    Date = reader.GetDateTime("date"),
                                    Status = reader.GetString("status")
                                });
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle MySQL-specific exceptions here
                Console.WriteLine($"MySQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle general exceptions here
                Console.WriteLine($"Error: {ex.Message}");
            }

            return notifications;
        }

        // Update notification status
        public void UpdateNotificationStatus(int notificationId, string status)
        {
            string query = "CALL prcUpdateNotificationStatus(@notificationId, @status)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(_globalProcedure.strConnection))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@notificationId", notificationId);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

    }
}