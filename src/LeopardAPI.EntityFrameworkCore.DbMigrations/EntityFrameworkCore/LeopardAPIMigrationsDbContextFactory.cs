using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace LeopardAPI.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class LeopardAPIMigrationsDbContextFactory : IDesignTimeDbContextFactory<LeopardAPIMigrationsDbContext>
    {
        public LeopardAPIMigrationsDbContext CreateDbContext(string[] args)
        {
            LeopardAPIEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<LeopardAPIMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new LeopardAPIMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
