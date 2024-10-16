using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            databasename = "CarlosYulo";
            username = "root";
            password = "password";
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
    }
}
