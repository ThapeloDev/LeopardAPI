using System.Threading.Tasks;

namespace LeopardAPI.Data
{
    public interface ILeopardAPIDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
