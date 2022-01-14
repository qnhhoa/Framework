using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using MySql.Data.MySqlClient;

namespace Admin.Controllers
{
    public class MakeupController : Controller
    {
        public IActionResult Index()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;

            //StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=cosmetic;");
            return View(context.GetMakeup());
        }
        public IActionResult DeleteMakeup(string Id)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            context.DeleteMakeup(Id);
            return RedirectToAction("Index", "Makeup");
        }
        public IActionResult ViewMakeup(string Id)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            Makeup mk = context.ViewMakeup(Id);
            ViewData.Model = mk;
            return View();
        }
        public IActionResult UpdateMakeup(Makeup mk)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            context.UpdateMakeup(mk);
            return RedirectToAction("Index", "Makeup");
        }
        public IActionResult InsertMakeup(Makeup mk)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            context.InsertMakeup(mk);
            return RedirectToAction("Index", "Makeup");
        }
        public IActionResult AddMakeup()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            return View(context.GetBrand());
        }
        public IActionResult Search(string key)
        {
            string ok = "%" + key + "%";
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            return View(context.SearchMakeup(ok));
        }
    }
}
