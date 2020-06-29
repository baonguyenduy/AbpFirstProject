using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpFirstProject.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class AbpFirstProjectMigrationsDbContextFactory : IDesignTimeDbContextFactory<AbpFirstProjectMigrationsDbContext>
    {
        public AbpFirstProjectMigrationsDbContext CreateDbContext(string[] args)
        {
            AbpFirstProjectEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AbpFirstProjectMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new AbpFirstProjectMigrationsDbContext(builder.Options);
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
