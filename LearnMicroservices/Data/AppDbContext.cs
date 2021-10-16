using LearnMicroservices.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnMicroservices.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        public virtual DbSet<Platforms> Platforms {  get; set; }
    }
}
