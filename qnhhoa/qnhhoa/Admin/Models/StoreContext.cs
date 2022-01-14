using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
namespace Admin.Models
{
    public class StoreContext
    {
        public string ConnectionString { get; set; }//biết thành viên 

        public StoreContext(string connectionString) //phuong thuc khoi tao
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection() //lấy connection 
        {
            return new MySqlConnection(ConnectionString);
        }
        public List<Body> GetSP()
        {
            List<Body> list = new List<Body>();

            //MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=;port=3306;database=cosmetic;");
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from sanpham";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Body()
                        {
                            SPID = reader["SpID"].ToString(),
                            Photo = reader["TenSP"].ToString(),
                            Brand = reader["TenSP"].ToString(),
                            Cost = reader["GiaSP"].ToString(),
                            Description = reader["MoTa"].ToString(),
                            Qty = Convert.ToInt32(reader["SL"])
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public StoreContext()
        {
        }
    }
}
