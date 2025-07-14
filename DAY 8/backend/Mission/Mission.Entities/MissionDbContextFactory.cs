using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;


namespace Mission.Entities
{
    public class MissionDbContextFactory : IDesignTimeDbContextFactory<MissionDbContext>
    {
        public MissionDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // assumes appsettings.json is here
                .AddJsonFile("appsettings.json", optional: true)
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<MissionDbContext>();

            var connectionString = configuration.GetConnectionString("DefaultConnection")
                ?? "Host=localhost;Database=mission2;Username=postgres;Password=pjyoti";

            optionsBuilder.UseNpgsql(connectionString);

            return new MissionDbContext(optionsBuilder.Options);
        }
    }
}
