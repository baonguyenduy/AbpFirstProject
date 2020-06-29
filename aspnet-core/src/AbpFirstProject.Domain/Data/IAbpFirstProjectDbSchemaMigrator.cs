using System.Threading.Tasks;

namespace AbpFirstProject.Data
{
    public interface IAbpFirstProjectDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
