using AbpFirstProject.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpFirstProject.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpFirstProjectEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpFirstProjectApplicationContractsModule)
        )]
    public class AbpFirstProjectDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
