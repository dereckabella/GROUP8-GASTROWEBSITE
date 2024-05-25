using GastroWebsiteNew.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GastroWebsiteNew.Controllers
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

        public IActionResult NewDishes()
        {
            return View("~/Views/Home/NewDishes.cshtml");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult DishLessons()
        {
            return View("~/Views/Home/DishLessons.cshtml");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
