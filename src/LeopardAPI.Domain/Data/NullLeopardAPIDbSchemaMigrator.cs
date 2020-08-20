using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LeopardAPI.Data
{
    /* This is used if database provider does't define
     * ILeopardAPIDbSchemaMigrator implementation.
     */
    public class NullLeopardAPIDbSchemaMigrator : ILeopardAPIDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}