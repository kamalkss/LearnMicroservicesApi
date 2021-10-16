using LearnMicroservices.Data;
using LearnMicroservices.Models;

namespace LearnMicroservices.Services
{
    public class PlatformRepo : IPlatformRepo
    {

        private readonly ILogger _logger;
        private readonly AppDbContext _context;

        public PlatformRepo(ILogger logger, AppDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public void CreatePlatform(Platforms platforms)
        {
            if(platforms == null)
            {
                return null;
            }
        }

        public IEnumerable<Platforms> GetAllPlatforms()
        {
            return _context.Platforms.ToList();
        }

        public Platforms GetPlatformById(Guid Id)
        {
            return _context.Platforms.FirstOrDefault(p => p.PlatformId == Id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
