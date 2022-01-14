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
    public class BlogController : Controller
    {
        public IActionResult addBlog()
        {
            return View();
        }
        public IActionResult Index()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            //StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=cosmetic;");
            return View(context.GetBlog());
        }
        
        public IActionResult DeleteBlog(string Id)
        {
            // ViewData["id"] = Id;
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            context.DeleteBlog(Id);
            return RedirectToAction("Index", "Blog");
        }
        public IActionResult ViewBlog(string Id)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            Blog ur = context.ViewBlog(Id);
            ViewData.Model = ur;
            return View();
        }
        public IActionResult UpdateBlog(Blog ur)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            context.UpdateBlog(ur);
            return RedirectToAction("Index", "Blog");
        }
        public IActionResult InsertBlog(Blog ur)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            context.InsertBlog(ur);
            return RedirectToAction("Index", "Blog");
        }
        public IActionResult Search(string key)
        {
            string ok = "%" + key + "%";
            StoreContext context = HttpContext.RequestServices.GetService(typeof(Admin.Models.StoreContext)) as StoreContext;
            return View(context.SearchBlog(ok));
        }
    }
}
