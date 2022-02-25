using Microsoft.AspNetCore.Mvc;
using PlofPlantWeb.Models;
using System.Diagnostics;

namespace PlofPlantWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PlofPlantDbContext _db;

        public HomeController(ILogger<HomeController> logger, PlofPlantDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            var model = new HomePage();

            model.Kassen = _db.Kassen.ToList();

            return View(model);
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