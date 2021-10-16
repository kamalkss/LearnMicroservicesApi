using PlatformService.Data;
using PlatformService.Models;

namespace PlatformService.Services
{
    public class PlatformRepo : IPlatformRepo
    {

       
        private readonly AppDbContext _context;

        public PlatformRepo(AppDbContext context)
        {
            _context = context;
            
        }

        public void CreatePlatform(Platforms platforms)
        {
            if(platforms == null)
            {
                throw new ArgumentNullException(nameof(platforms));
            }
            _context.Platforms.Add(platforms);
            SaveChanges();

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
