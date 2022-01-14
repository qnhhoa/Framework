using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Controllers
{
    public class SkinController : Controller
    {
        //GET: Skin
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult addskin()
        {
            return View();
        }
    }
}
