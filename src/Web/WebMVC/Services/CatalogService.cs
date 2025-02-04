using WebMVC.Helpers;

namespace WebMVC.Services
{
    public class CatalogService: ICatalogService
    {
        private readonly HttpClient _client;
        public const string BasePath = "/swagger/v1";

        public CatalogService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<Plate>> GetAll()
        {
            var response = await _client.GetAsync("/all");

            return await response.ReadContentAsync<List<Plate>>();
        }
    }
}
