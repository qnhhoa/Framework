using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Admin.Models
{
    public class ConDB
    {
        private string ConString = "server=127.0.0.1; username=root; password=''; database='cosmetic'";
        public MySqlConnection myConnection;

        public ConDB()
        {
            myConnection = new MySqlConnection(ConString);
            myConnection.Open();
        }

        public DataTable GetData(string _sqlCommand)
        {
            MySqlCommand command = new MySqlCommand(_sqlCommand, myConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void ExecuteQuery(string _sqlCommnad)
        {
            MySqlCommand command = new MySqlCommand("", myConnection);
            command.CommandText = _sqlCommnad;
            command.CommandType = CommandType.Text;
            command.Connection = myConnection;
            command.ExecuteNonQuery();
        }
    }
}
