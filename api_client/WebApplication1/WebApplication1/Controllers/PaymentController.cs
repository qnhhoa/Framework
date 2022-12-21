using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using WebApplication1.Models;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Reflection;

namespace WebApplication1.Controllers
{
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public PaymentController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        [Route("payment/{id}")]
        public JsonResult getById(string id)
        {

            string query = @"SELECT Photo,hoadon.MaHD,cthd.*,sanpham.TenSP,Trangthai, TongTien,GiaSP from hoadon, sanpham, cthd, donhang where cthd.SpID = sanpham.SpID and hoadon.MaHD = donhang.MaHD and hoadon.MaHD=cthd.MaHD and Username = @Id order by hoadon.MaHD desc";
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");

            DataTable table = new DataTable();

            MySqlDataReader myReader;

            using (MySqlConnection myCon = new MySqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, myCon))
                {
                    Console.WriteLine(query);
                    myCommand.Parameters.AddWithValue("@Id", id);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }       
        [HttpPost]
        [Route("/payment/pay1")]
        public ActionResult Checkusr(Payment pay)
        {
            string query = @"INSERT INTO hoadon (Username,Address,PhoneNumber,Fullname,Note,TongTien,Method) 
                                VALUES (@Username,@Address,@PhoneNumber,@FullName,@Note,@TongTien,@Method)                         
                            ";
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            using (MySqlConnection myCon = new MySqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("Username", pay.Username);
                    myCommand.Parameters.AddWithValue("Address", pay.Address);
                    myCommand.Parameters.AddWithValue("PhoneNumber", pay.PhoneNumber);
                    myCommand.Parameters.AddWithValue("Fullname", pay.FullName);
                    myCommand.Parameters.AddWithValue("Note", pay.Note);
                    myCommand.Parameters.AddWithValue("TongTien", pay.TongTien);
                    myCommand.Parameters.AddWithValue("Method", pay.Method);
                    var ok = myCommand.ExecuteNonQuery();
                    Console.WriteLine(ok);
                    if (ok > 0)
                    { 
                 
                        string query1 = $"SELECT MaHD FROM hoadon Where Username='{pay.Username}' and MaHD>=ALL(SELECT MaHD FROM hoadon);";

                        string query2 = @"INSERT INTO donhang(MaHD,Trangthai,NgayNH) VALUES (@MaHD,'Pickup',@NgayNH)                         
                                                ";
                        using (MySqlCommand myCommand3 = new MySqlCommand(query1, myCon))
                        {

                            myCommand3.CommandText = query1;
                            myCommand3.CommandType = CommandType.Text;
                            int maxid = Convert.ToInt16(myCommand3.ExecuteScalar().ToString());
                            using (MySqlCommand myCommand1 = new MySqlCommand(query2, myCon))
                            {
                                myCommand1.Parameters.AddWithValue("MaHD", maxid);
                                myCommand1.Parameters.AddWithValue("NgayNH", pay.NgayNH);
                                var ok1 = myCommand1.ExecuteNonQuery();
                                if (ok1 > 0)
                                {
                                   
                                    string querycthd = @"INSERT INTO cthd(MaHD, SpID, SL) VALUES (@MaHD, @SpID,@SL)";
                                    foreach (Product item in pay.Listproduct)
                                    {
                                       
                            
                                        using (MySqlCommand cmdCthd = new MySqlCommand(querycthd, myCon))
                                        {        
                                            cmdCthd.Parameters.AddWithValue("MaHD", maxid);
                                            cmdCthd.Parameters.AddWithValue("SpID", item.spID);
                                            cmdCthd.Parameters.AddWithValue("SL", item.SL);
                                            cmdCthd.ExecuteNonQuery();
                                         

                                        }

                                    }
                                 
                                   

                                }
                            }

                        }

                    }

                    myCon.Close();
                }
                return Ok();
            }
            return BadRequest();
        }
    }
}
