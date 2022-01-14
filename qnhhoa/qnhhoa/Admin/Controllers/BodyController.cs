using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using MySql.Data.MySqlClient;

namespace Admin.Controllers
{
    public class BodyController : Controller
    {
        public IActionResult Index()
        {
            ViewData.Model = new Body();
            return View();
        }
        public IActionResult addBody()
        {
            return View();
        }
    }
}
