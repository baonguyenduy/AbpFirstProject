using Volo.Abp.Modularity;

namespace AbpFirstProject
{
    [DependsOn(
        typeof(AbpFirstProjectApplicationModule),
        typeof(AbpFirstProjectDomainTestModule)
        )]
    public class AbpFirstProjectApplicationTestModule : AbpModule
    {

    }
}