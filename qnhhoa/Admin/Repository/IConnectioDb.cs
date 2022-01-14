

using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Chart.Repository
{
    public interface IConnectionDb
    {
        public MySqlConnection getConnection();
    }

}