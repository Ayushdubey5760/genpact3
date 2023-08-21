using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppPartialViewExTwo.Models;

namespace WebAppPartialViewExTwo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Product()
        {
            List<Product> Listproducts = new List<Product>
            {
                new Product{Id=1,Name="Mobile",Price=23000,Brand="SamSung"},
                 new Product{Id=2,Name="IPhone",Price=213000,Brand="Apple"},
                  new Product{Id=3,Name="Laptop",Price=25000,Brand="Dell"},
                   new Product{Id=4,Name="Vector",Price=83000,Brand="Dell"},
            };
            return PartialView(Listproducts);
        }

    }
}