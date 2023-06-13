using Microsoft.AspNetCore.Mvc;
using MVCIntroDemoo.Models;
using System.Diagnostics;

namespace MVCIntroDemoo.Controllers
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
            ViewBag.Mesaage = "Hello Worlds from ViewBag!";
            ViewData["Msg"] = "Hello Worlds from ViewData!";
            ViewData["People"] = new string[]{ "Pesho", "Mariq", "Ivan" };
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "This is an ASP.NET Core MVC app.";

            return View();
        }

        public IActionResult Numbers()
        {
            return View();
        }

        public IActionResult NumbersToN(int count = -1)
        {
            ViewData["Count"] = count;

            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}