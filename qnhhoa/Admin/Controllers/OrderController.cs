using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using MySql.Data.MySqlClient;
namespace Admin.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            //StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=cosmetic;");
            /*            ViewBag.cthd = context.Viewcthd();*/
            return View(context.GetOrder());
        }
        public IActionResult DeleteOrder(string Id)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            context.DeleteOrder(Id);
            return RedirectToAction("Index", "Order");
        }
        public IActionResult ViewOrder(string Id)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            Order or = context.ViewOrder(Id);
            ViewData.Model = or;
            List<Order> cthd = context.ViewCthd(Id).ToList();
            Console.WriteLine(cthd);
            ViewBag.data = cthd;
            return View();
        }
        public IActionResult Viewcthd(string Id)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;            
/*            Console.WriteLine(or);
            ViewData.Model = or;*/
            return View(context.ViewCthd(Id));
        }
        public IActionResult DeleteCthd(string Id,string Ok)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            context.DeleteCthd(Id,Ok);
            return RedirectToAction("Index", "Order");
        }
        public IActionResult UpdateOrder(Order or)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            context.UpdateOrder(or);
            return RedirectToAction("Index", "Order");
        }
        public IActionResult Search(string key)
        {
            string ok = "%" + key + "%";
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            return View(context.SearchOrder(ok));
        }
    }
}
