using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace LeopardAPI.EntityFrameworkCore
{
    public static class LeopardAPIDbContextModelCreatingExtensions
    {
        public static void ConfigureLeopardAPI(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(LeopardAPIConsts.DbTablePrefix + "YourEntities", LeopardAPIConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}