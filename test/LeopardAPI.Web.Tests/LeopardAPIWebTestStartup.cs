using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace LeopardAPI
{
    public class LeopardAPIWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<LeopardAPIWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}