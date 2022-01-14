using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using MySql.Data.MySqlClient;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Admin.Controllers
{
    public class UserController : Controller
    {
        public IActionResult AddUser()
        {
            return View();
        }
        public IActionResult Index()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            //StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=cosmetic;");
            return View(context.GetUser());
        }
        public IActionResult GetUserbyRole()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            //StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=cosmetic;");
            context.GetUserbyRole();
            return RedirectToAction("Index", "User");
        }
        public IActionResult DeleteUser(string Id)
        {
            // ViewData["id"] = Id;
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            context.DeleteUser(Id);
            return RedirectToAction("Index","User");
        }
        public IActionResult ViewUser(string Id)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            User ur = context.ViewDN(Id);
            ViewData.Model = ur;
            return View();
        }
        public IActionResult UpdateUser(User ur)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            context.UpdateUser(ur);
            return RedirectToAction("Index", "User");
        }
        public IActionResult InsertUser(User ur)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            context.InsertDN(ur);
            return RedirectToAction("Index", "User");
        }
        public IActionResult Search(string key)
        {
            string ok = "%" + key + "%";
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            return View(context.SearchUser(ok));
        }
    }
}
