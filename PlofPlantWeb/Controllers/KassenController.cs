using Microsoft.AspNetCore.Mvc;
using PlofPlantData.Models;

namespace PlofPlantWeb.Controllers
{
    public class KassenController : Controller
    {
        private readonly ILogger<KassenController> _logger;
        private readonly PlofPlantDbContext _db;

        public KassenController(ILogger<KassenController> logger, PlofPlantDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Kas(int? kasId)
        {
            var model = new Kas();
            if (kasId.HasValue)
            {
                model = _db.Kassen
                    .Where(m => m.Id == kasId.Value)
                    .FirstOrDefault();
            }

            return View(model);
        }
    }
}
