using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using MySql.Data.MySqlClient;
using System.IO;

namespace Admin.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            //StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=cosmetic;");
            return View(context.GetBlog());
        }
        public class Ratio
        {
            public int Male { get; set; }
            public int Female { get; set; }
            public int Other { get; set; }
        }
        public IActionResult Charts()
        {
            return View();
        }
    }
}
