using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace Admin.Controllers
{
    public class HomeController : Controller
    {
/*        public string ConnectionString { get; set; }

        public HomeController(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }*/
        private ConDB conDB = new ConDB();
/*        private readonly IConfiguration _configuration;*/
/*        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }*/
        public IActionResult Index()
        {
                return View();
        }
        [HttpPost]
        public IActionResult Login(string Email, string password)
        {
            DataTable dt = conDB.GetData($"select * from dangnhap where Email = '{Email}' and password = '{password}';"); ;
            if (dt.Rows.Count == 0)
            {
                /*                if (dt.Rows[0]["password"].ToString() == (password))
                                {
                                    HttpContext.Session.SetString("login", "1");

                                }*/
                /*                Console.WriteLine(dt);
                                return BadRequest("false");*/
                return RedirectToAction("Index", "Login");
            }
            /*            return Ok("true");*/
            Login lg = new Login();
            lg.Email = Email;
            return RedirectToAction("Index", "Home");
        }
        /*[HttpPost]
        public ActionResult Login(Login user)
        {
            Console.WriteLine(user.Username);
            Console.WriteLine(user.password);
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
                    myCommand.Parameters.AddWithValue("password", user.password);
                    myReader = myCommand.ExecuteReader();
                    Console.WriteLine(myReader.HasRows);
                    if (myReader.HasRows) return Ok();
                    myReader.Close();
                    myCon.Close();
                }
            }
            return BadRequest();
        }*/
    }
}
