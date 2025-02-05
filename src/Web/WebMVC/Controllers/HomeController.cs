using RTCodingExercise.Microservices.Models;
using System.Diagnostics;
using WebMVC.Helpers;
using WebMVC.Services;

namespace RTCodingExercise.Microservices.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICatalogService _catalogService;
    
        public HomeController(ILogger<HomeController> logger, ICatalogService catalogService)
        {
            _logger = logger;
            _catalogService = catalogService;
        }

        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            var results = await _catalogService.GetAll();
            ViewData["PriceSortParam"] = String.IsNullOrEmpty(sortOrder) ? "sale_price" : "";        
            ViewData["CurrentFilter"] = searchString;
            if (!String.IsNullOrEmpty(searchString))
            {
                results = results.Where(s => s.Registration.Contains(searchString.ToUpper()));
            }
            switch (sortOrder)
            {
                case "sale_price":
                    results = results.OrderBy(r => r.SalePrice);
                    break;               
                default:
                    break;
            }
            return View(results);
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