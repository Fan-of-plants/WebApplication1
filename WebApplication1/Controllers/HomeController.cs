using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        static List<Product> products = new()
        {
            new Product { Id = 1, Price = 199, Title = "Smartphone", Category = "Electronics", Quantity = "10" },
            new Product { Id = 2, Price = 50, Title = "T-shirt", Category = "Clothing", Quantity = "25" },
            new Product { Id = 3, Price = 899, Title = "Laptop", Category = "Electronics", Quantity = "5" },
            new Product { Id = 4, Price = 19, Title = "Mug", Category = "Kitchen", Quantity = "50" },
            new Product { Id = 5, Price = 120, Title = "Headphones", Category = "Electronics", Quantity = "30" }
        };

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

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult AdminPanel()
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            return RedirectToAction("AdminPanel");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
