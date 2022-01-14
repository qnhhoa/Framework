using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using MySql.Data.MySqlClient;
namespace Admin.Controllers
{
    public class HairController : Controller
    {
        public IActionResult Index()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            return View(context.GetHair());
        }
        public IActionResult DeleteHair(string Id)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            context.DeleteHair(Id);
            return RedirectToAction("Index", "Hair");
        }
        public IActionResult ViewHair(string Id)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            Hair hr = context.ViewHair(Id);
            ViewData.Model = hr;
            return View();
        }
        public IActionResult UpdateHair(Hair hr)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            context.UpdateHair(hr);
            return RedirectToAction("Index", "Hair");
        }
        public IActionResult InsertHair(Hair hr)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            context.InsertHair(hr);
            return RedirectToAction("Index", "Hair");
        }
        public IActionResult AddHair()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            return View(context.GetBrand());
        }
        public IActionResult Search(string key)
        {
            string ok = "%" + key + "%";
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            return View(context.SearchHair(ok));
        }
    }
}
