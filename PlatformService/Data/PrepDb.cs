using PlatformService.Models;
using Microsoft.AspNetCore.Builder;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScoped = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScoped.ServiceProvider.GetService<AppDbContext>());
            }
        }
        private static void SeedData(AppDbContext context)
        {
            if (!context.Platforms.Any())
            {
                Console.WriteLine("-------->Seeding Data");
                context.Platforms.AddRange(
                    new Platforms() { Name = "DotNet", Publisher = "Microsoft", Cost = "Free" },
                    new Platforms() { Name = "SqlServer", Publisher = "Microsoft", Cost = "Free" },
                    new Platforms() { Name = "C#", Publisher = "Microsoft", Cost = "Free" }
                    );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("We Already Have Data");
            }
        }
    }
}
