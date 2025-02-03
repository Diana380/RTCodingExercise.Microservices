using Catalog.Domain;
using RabbitMQ.Client.Events;
using Serilog;
using System.Runtime.CompilerServices;

namespace Catalog.API.Repositories
{
    
    public class PlateRepository : IPlateRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly Serilog.ILogger _logger;

        public PlateRepository(ApplicationDbContext context, Serilog.ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        public List<Plate> GetPlates()
        {
            return _context.Plates.ToList();
        }
    }
}
