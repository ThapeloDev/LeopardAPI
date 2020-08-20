using Volo.Abp.Modularity;

namespace LeopardAPI
{
    [DependsOn(
        typeof(LeopardAPIApplicationModule),
        typeof(LeopardAPIDomainTestModule)
        )]
    public class LeopardAPIApplicationTestModule : AbpModule
    {

    }
}