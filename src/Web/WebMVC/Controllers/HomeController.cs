using Catalog.API.Repositories;
using RTCodingExercise.Microservices.Models;
using System.Diagnostics;

namespace RTCodingExercise.Microservices.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IPlateRepository _plateRepository;
    
        public HomeController(ILogger<HomeController> logger, IPlateRepository plateRepository)
        {
            _logger = logger;
            _plateRepository = plateRepository;
        }

        public async Task<IActionResult> Index()
        {
            
            return  View( _plateRepository.GetPlates());
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