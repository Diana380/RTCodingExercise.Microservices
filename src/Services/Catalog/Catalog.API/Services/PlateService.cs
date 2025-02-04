using Catalog.API.Repositories;

namespace Catalog.API.Services
{
    public class PlateService: IPlateService
    {
        private readonly IPlateRepository _plateRepository;

    public  PlateService(IPlateRepository plateRepository)
        {
            _plateRepository = plateRepository;
        }
        public List<Plate> GetAll() 
        { 
        
            var plates =  _plateRepository.GetPlates();
            // add 20% markup

            foreach (var plate in plates) {
                plate.SalePrice = plate.SalePrice * 1.2m;
            }

            return plates;
        
        }
        
    }
}
