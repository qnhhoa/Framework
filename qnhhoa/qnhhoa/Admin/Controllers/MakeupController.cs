using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Controllers
{
    public class MakeupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult addMakeup()
        {
            return View();
        }
    }
}
