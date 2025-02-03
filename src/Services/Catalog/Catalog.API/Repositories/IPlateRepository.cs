using Catalog.Domain;

namespace Catalog.API.Repositories

{
    public interface IPlateRepository
    {
        public List<Plate> GetPlates();
    }
}
