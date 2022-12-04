using AjaxDragAndDropExample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AjaxDragAndDropExample.Controllers
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
        public IActionResult Hotel()
        {
            return View();
        }
        public IActionResult Hotel2()
        {
            return View();
        } public IActionResult Hotel3()
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
    }
}