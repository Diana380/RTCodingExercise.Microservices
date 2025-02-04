using Catalog.Domain;

namespace WebMVC.Services
{
    public interface ICatalogService
    {
        Task<IEnumerable<Plate>> GetAll();
    }
}
