using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AbpFirstProject.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpFirstProjectEntityFrameworkCoreModule)
        )]
    public class AbpFirstProjectEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpFirstProjectMigrationsDbContext>();
        }
    }
}
