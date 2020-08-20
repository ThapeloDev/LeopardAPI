using LeopardAPI.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LeopardAPI
{
    [DependsOn(
        typeof(LeopardAPIEntityFrameworkCoreTestModule)
        )]
    public class LeopardAPIDomainTestModule : AbpModule
    {

    }
}