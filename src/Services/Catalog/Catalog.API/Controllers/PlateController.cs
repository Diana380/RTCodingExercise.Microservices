using Catalog.API.Repositories;

namespace Catalog.API.Controllers
{
    public class PlateController: Controller
    {
        public IPlateRepository _plateRepository;
        public PlateController(IPlateRepository plateRepository) {
        _plateRepository = plateRepository;
        }
        [HttpGet("/all")]
        public  IActionResult GetPlates()
        {
            var plates =  _plateRepository.GetPlates();
            return Ok(plates);
        }
    }
}
