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
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public UserController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpPost]
        [Route("/user1/login")]
        public ActionResult Checkusr(User user)
        {
            Console.WriteLine(user.Username);
           Console.WriteLine(user.Password);
            string query = @"
                            select * from
                            dangnhap where Username = @Username and Password = @password
                            ";
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            MySqlDataReader myReader;
            using (MySqlConnection myCon = new MySqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("Username", user.Username);
                    myCommand.Parameters.AddWithValue("password", user.Password);
                    myReader = myCommand.ExecuteReader();
                    Console.WriteLine(myReader.HasRows);
                    if (myReader.HasRows) return Ok();
                    myReader.Close();
                    myCon.Close();
                }
            }
            return BadRequest();
        }
        [HttpGet]
        [Route("pay/{Username}")]
        public JsonResult Payment(string Username)
        {
            string query = @"
                            select * from
                            dangnhap where Username = @Username
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            MySqlDataReader myReader;
            using (MySqlConnection myCon = new MySqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Username", Username);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }
    }
}

