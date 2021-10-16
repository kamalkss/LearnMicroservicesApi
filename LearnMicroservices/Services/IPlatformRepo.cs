using LearnMicroservices.Models;

namespace LearnMicroservices.Services
{
    public interface IPlatformRepo
    {
        public bool SaveChanges();
        public IEnumerable<Platforms> GetAllPlatforms();
        public Platforms GetPlatformById(Guid Id);

        public void CreatePlatform(Platforms platforms);
    }
}
