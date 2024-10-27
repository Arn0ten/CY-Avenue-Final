using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace csCY_Avenue.Database
{
    internal class GlobalProcedure
    {
        public string servername;
        public string databasename;
        public string username;
        public string password;
        public string port;
        public MySqlConnection conLaundry;
        public string strConnection;
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter dataAdapter;

        public GlobalProcedure()
        {
            servername = "localhost";
            databasename = "cy";
            username = "root";
            password = "root";
            port = "3306";

            strConnection = "Server=" + servername + ";" +
                            "Database=" + databasename + ";" +
                            "User=" + username + ";" +
                            "Password=" + password + ";" +
                            "Port=" + port + ";" +
                            "Convert Zero Datetime=true";

            conLaundry = new MySqlConnection(strConnection);
            sqlCommand = new MySqlCommand(strConnection, conLaundry);
        }

        public bool fncConnectToDatabase()
        {
            try
            {
                if (conLaundry.State == System.Data.ConnectionState.Closed)
                {
                    conLaundry.Open();
                    return true;
                }
                return false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Error Message: " + err.Message);
                return false;
            }
        }

        public void checkDatabaseConnection()
        {
            fncConnectToDatabase();
        }

        public DataTable SearchClient(string searchTerm)
        {
            DataTable searchResults = new DataTable();
            try
            {
                checkDatabaseConnection();
                sqlCommand = new MySqlCommand("prcSearchClient", conLaundry);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("searchTerm", searchTerm);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCommand);
                dataAdapter.Fill(searchResults);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message);
            }
            finally
            {
                conLaundry.Close();
            }
            return searchResults;
        }

        public DataTable SearchEmployee(string searchTerm)
        {
            DataTable searchResults = new DataTable();
            try
            {
                fncConnectToDatabase();
                sqlCommand = new MySqlCommand("prcSearchEmployee", conLaundry);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("searchTerm", searchTerm);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCommand);
                dataAdapter.Fill(searchResults);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message);
            }
            finally
            {
                conLaundry.Close();
            }
            return searchResults;
        }

        // New method to search for trainers
        public DataTable SearchTrainer(string searchTerm)
        {
            DataTable searchResults = new DataTable();
            try
            {
                fncConnectToDatabase();
                sqlCommand = new MySqlCommand("prcSearchEmployee", conLaundry); 
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("searchTerm", searchTerm);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCommand);
                dataAdapter.Fill(searchResults);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message);
            }
            finally
            {
                conLaundry.Close();
            }
            return searchResults;
        }

        public DataTable SearchItem(string searchTerm)
        {
            DataTable searchResults = new DataTable();
            try
            {
                fncConnectToDatabase();
                sqlCommand = new MySqlCommand("prcSearchItem", conLaundry);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("searchTerm", searchTerm);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCommand);
                dataAdapter.Fill(searchResults);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message);
            }
            finally
            {
                conLaundry.Close();
            }
            return searchResults;
        }

    }
}
