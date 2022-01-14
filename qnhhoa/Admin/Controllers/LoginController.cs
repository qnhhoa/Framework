using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;

namespace Admin.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewLogin(string Email)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            Login log = context.ViewLogin(Email);
            ViewData.Model = log;
            return View();
        }
    }
}
