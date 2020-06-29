using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpFirstProject.Data
{
    /* This is used if database provider does't define
     * IAbpFirstProjectDbSchemaMigrator implementation.
     */
    public class NullAbpFirstProjectDbSchemaMigrator : IAbpFirstProjectDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}