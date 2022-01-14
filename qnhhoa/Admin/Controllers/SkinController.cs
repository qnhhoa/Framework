using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using MySql.Data.MySqlClient;
namespace Admin.Controllers
{
    public class SkinController : Controller
    {
        public IActionResult Index()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;

            //StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=cosmetic;");
            return View(context.GetSkin());
        }
        public IActionResult DeleteSkin(string Id)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            context.DeleteSkin(Id);
            return RedirectToAction("Index", "Skin");
        }
        public IActionResult ViewSkin(string Id)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            Skin sk = context.ViewSkin(Id);
            ViewData.Model = sk;
            return View();
        }
        public IActionResult UpdateSkin(Skin sk)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            context.UpdateSkin(sk);
            return RedirectToAction("Index", "Skin");
        }
        public IActionResult InsertSkin(Skin sk)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            context.InsertSkin(sk);
            return RedirectToAction("Index","Skin");
        }
        public IActionResult AddSkin()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            return View(context.GetBrand());
        }
        public IActionResult Search(string key)
        {
            string ok = "%" + key + "%";
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            return View(context.SearchSkin(ok));
        }
    }
}
