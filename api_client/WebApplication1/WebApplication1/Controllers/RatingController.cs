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
    public class RatingController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public RatingController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        [Route("rating/{id}")]
        public JsonResult getRating(int id)
        {

            string query = @"SELECT avg(Rating) as rt from danhgia where SpID=@Id";
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");

            DataTable table = new DataTable();

            MySqlDataReader myReader;

            using (MySqlConnection myCon = new MySqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, myCon))
                {
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
        [Route("submitrt")]
        public IActionResult Post(Rating rt)
        {
            string query = @"
                           INSERT INTO danhgia(Username,SpID,Rating) VALUES (@User,@Id,@Rate)
                            ";
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            MySqlDataReader myReader;
            using (MySqlConnection myCon = new MySqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@User", rt.User);
                    myCommand.Parameters.AddWithValue("@Id", rt.Id);
                    myCommand.Parameters.AddWithValue("@Rate", rt.Rate);
                    var ok = myCommand.ExecuteNonQuery();
                    Console.WriteLine(ok);
                    if (ok > 0)
                    {
                        return Ok();
                    }
                    myCon.Close();
                }
            }
            return BadRequest();
        }
        [HttpPost]
        [Route("checkPayment")]
        public IActionResult CheckPayment(Rating rt)
        {
            string query = @"
                            select * from
                            hoadon,cthd where hoadon.MaHD = cthd.MaHD and Username = @User and SpID = @Id
                            ";
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            MySqlDataReader myReader;
            using (MySqlConnection myCon = new MySqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("User", rt.User);
                    myCommand.Parameters.AddWithValue("Id", rt.Id);
                    myReader = myCommand.ExecuteReader();
                    Console.WriteLine(myReader.HasRows);
                    if (myReader.HasRows) return Ok("true");
                    myReader.Close();
                    myCon.Close();
                }
            }
            /*myReader = myCommand.ExecuteReader();
            var ok = myCommand.ExecuteNonQuery();
            Console.WriteLine(ok);
            if (ok > 0)
            {
                string query1 = $"INSERT INTO danhgia(Username,SpID,Rating) VALUES('{pay.Username}', '{pay.SpID}', @Rate);";
                using (MySqlCommand myCommand3 = new MySqlCommand(query1, myCon))
                {

                    myCommand3.CommandText = query1;
                    myCommand.Parameters.AddWithValue("@Rate", pay.Rate);
                    myReader.Close();
                }
                myCon.Close();
            }
            return Ok();
        }*/
            return BadRequest("false");
            }
        }
}

