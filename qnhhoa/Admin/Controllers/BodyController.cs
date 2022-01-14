using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using System.Data;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Admin.Controllers
{
    public class BodyController : Controller
    {
        public IActionResult Test()
        {
            return View();
        }
        public IActionResult Index()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            dynamic d = context.GetBody();

            //Console.WriteLine(d.Photomain);
            return View(d);

        }
        public IActionResult Search(string key)
        {
            string ok = "%" + key + "%";
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            return View(context.SearchBody(ok));
        }
        public IActionResult DeleteBody(string Id)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            context.DeleteBody(Id);
            return RedirectToAction("Index", "Body");
        }
        public IActionResult ViewBody(string Id)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            Body bd = context.ViewBody(Id);
            ViewData.Model = bd;
            return View();
        }
        public IActionResult UpdateBody(Body bd)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            context.UpdateBody(bd);
            return RedirectToAction("Index", "Body");
        }
        public IActionResult InsertBody(Body bd)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            context.InsertBody(bd);
            return RedirectToAction("Index", "Body");
        }
        public IActionResult AddBody()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            return View(context.GetBrand());
        }
    }
}
