using AbpFirstProject.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpFirstProject
{
    [DependsOn(
        typeof(AbpFirstProjectEntityFrameworkCoreTestModule)
        )]
    public class AbpFirstProjectDomainTestModule : AbpModule
    {

    }
}