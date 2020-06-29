using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpFirstProject.Data;
using Volo.Abp.DependencyInjection;

namespace AbpFirstProject.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpFirstProjectDbSchemaMigrator
        : IAbpFirstProjectDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpFirstProjectDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpFirstProjectMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpFirstProjectMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}