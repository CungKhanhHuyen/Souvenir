using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Souvenir.Models;

namespace Souvenir.Controllers
{
    public class HomeController : Controller
    {
        private readonly SouvenirShopDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(SouvenirShopDbContext context ,ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.service = _context.Services.ToList();
            ViewBag.categoryProduct = _context.Categories.ToList();
            return View();
        }
        public IActionResult Product()
        {
            return View();
        }
        public IActionResult Blog()
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
