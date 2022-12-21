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

namespace WebApplication1.Controllers
{
    [ApiController]
    public class SignupController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public SignupController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpPost]
        [Route("signup")]
        public JsonResult Post(Signup reg)
        {
            string query = @"
                           insert into dangnhap
                            (Username,password,HoTen,SDT,DiaChi,cRole,Email,picture)
                           values (@Username,@password,@HoTen,@SDT,@diaChi,@cRole,@Email,@picture)
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            MySqlDataReader myReader;
            using (MySqlConnection myCon = new MySqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Username", reg.Username);
                    myCommand.Parameters.AddWithValue("@password", reg.password);
                    myCommand.Parameters.AddWithValue("@HoTen", reg.HoTen);
                    myCommand.Parameters.AddWithValue("@SDT", reg.SDT);
                    myCommand.Parameters.AddWithValue("@DiaChi", reg.DiaChi);
                    myCommand.Parameters.AddWithValue("@cRole", 1);
                    myCommand.Parameters.AddWithValue("@Email", reg.Email);
                    myCommand.Parameters.AddWithValue("@picture", "");
                    myReader = myCommand.ExecuteReader(); ;
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("add success");
        }

        [HttpPost]
        [Route("google")]
        public IActionResult LoginGoogle(Signup reg)
        {
            string query = @"
                            select * from
                            dangnhap where Username = @Username
                            ";
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            using (MySqlConnection myCon = new MySqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("Username", reg.Username);
                    var ok = myCommand.ExecuteNonQuery();
                    Console.WriteLine(ok);
                    if (ok < 0)
                    {
                        string query1 = @"
                           insert into dangnhap
                            (Username,HoTen,cRole,Email,picture)
                           values (@Username,@HoTen,@cRole,@Email,@picture)
                            ";
                        using (MySqlCommand myCommand1 = new MySqlCommand(query1, myCon))
                        {
                            myCommand.Parameters.AddWithValue("@Username", reg.Username);
                            myCommand.Parameters.AddWithValue("@HoTen", reg.HoTen);
                            myCommand.Parameters.AddWithValue("@cRole", 1);
                            myCommand.Parameters.AddWithValue("@Email", reg.Email);
                            myCommand.Parameters.AddWithValue("@picture", reg.picture);
                            myCommand1.ExecuteNonQuery();
                        }
                        myCon.Close();
                    }
                    return Ok();
                }

                return BadRequest();
            }
        }
    }
}
