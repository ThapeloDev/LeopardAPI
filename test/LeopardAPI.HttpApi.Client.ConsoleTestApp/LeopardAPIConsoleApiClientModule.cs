using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace LeopardAPI.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(LeopardAPIHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class LeopardAPIConsoleApiClientModule : AbpModule
    {
        
    }
}
