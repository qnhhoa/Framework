using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Chart.Repository
{
    public class ConnectionDb : IConnectionDb
    {
        public MySqlConnection getConnection()
        {
            String connString = "Server=" + "localhost" + ";Database=" + "cosmetic"
                   + ";port=" + "3306" + ";User Id=" + "root" + ";password=" + "";

            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                return conn;
            }
            catch (Exception e)
            {
                return null;
            }


        }
    }
}