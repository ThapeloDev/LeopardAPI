using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace LeopardAPI.EntityFrameworkCore
{
    [DependsOn(
        typeof(LeopardAPIEntityFrameworkCoreModule)
        )]
    public class LeopardAPIEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<LeopardAPIMigrationsDbContext>();
        }
    }
}
