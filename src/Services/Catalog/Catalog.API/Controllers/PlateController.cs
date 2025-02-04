using Catalog.API.Repositories;
using Catalog.API.Services;

namespace Catalog.API.Controllers
{
    public class PlateController: Controller
    {
        public IPlateService _plateService;
        public PlateController(IPlateService plateService) {
            _plateService = plateService;
        }
        [HttpGet("/all")]
        public  IActionResult GetPlates()
        {
            var plates = _plateService.GetAll();
            return Ok(plates);
        }
    }
}
