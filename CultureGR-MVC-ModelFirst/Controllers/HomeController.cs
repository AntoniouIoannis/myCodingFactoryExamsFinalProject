using System.Diagnostics;
using CultureGR_MVC_ModelFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace CultureGR_MVC_ModelFirst.Controllers
{
    public class HomeController : Controller
    {
        public string? CurrentDay { get; set; }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel();
            model.OnGet(); // in Models subfolder

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
