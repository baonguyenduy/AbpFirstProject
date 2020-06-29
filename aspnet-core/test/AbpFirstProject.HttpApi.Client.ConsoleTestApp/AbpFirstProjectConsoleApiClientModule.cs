using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AbpFirstProject.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(AbpFirstProjectHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AbpFirstProjectConsoleApiClientModule : AbpModule
    {
        
    }
}
