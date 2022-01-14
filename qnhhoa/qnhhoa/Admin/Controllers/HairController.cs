using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Controllers
{
    public class HairController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult addHair()
        {
            return View();
        }
    }
}
