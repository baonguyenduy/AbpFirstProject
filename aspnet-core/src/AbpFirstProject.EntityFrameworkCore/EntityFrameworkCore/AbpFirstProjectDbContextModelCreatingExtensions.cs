using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AbpFirstProject.EntityFrameworkCore
{
    public static class AbpFirstProjectDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpFirstProject(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AbpFirstProjectConsts.DbTablePrefix + "YourEntities", AbpFirstProjectConsts.DbSchema);

            //    //...
            //});
            builder.Entity<Todo>(t =>
            {
                t.ToTable("Todos", AbpFirstProjectConsts.DbSchema);
            });
        }
    }
}