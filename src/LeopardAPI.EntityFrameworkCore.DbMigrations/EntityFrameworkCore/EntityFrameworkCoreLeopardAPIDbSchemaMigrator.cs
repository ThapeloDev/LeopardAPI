using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LeopardAPI.Data;
using Volo.Abp.DependencyInjection;

namespace LeopardAPI.EntityFrameworkCore
{
    public class EntityFrameworkCoreLeopardAPIDbSchemaMigrator
        : ILeopardAPIDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreLeopardAPIDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the LeopardAPIMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<LeopardAPIMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}