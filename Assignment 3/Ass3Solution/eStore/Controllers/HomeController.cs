using DataAccess.Repository;
using eStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _db;
        public HomeController(IProductRepository db) => _db = db;


        public IActionResult Index()
        {
            var prods = _db.GetList();
            return View(prods);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
