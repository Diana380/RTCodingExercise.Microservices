using Catalog.API.Repositories;

namespace Catalog.API.Controllers
{
    public class PlateController: Controller
    {
        public PlateRepository _plateRepository;
        public PlateController(PlateRepository plateRepository) {
        _plateRepository = plateRepository;
        }
        public IActionResult GetPlates()
        {
            var plates = _plateRepository.GetPlates();
            return View();
        }
    }
}
