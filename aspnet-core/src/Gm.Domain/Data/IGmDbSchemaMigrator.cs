using System.Threading.Tasks;

namespace Gm.Data;

public interface IGmDbSchemaMigrator
{
    Task MigrateAsync();
}
