using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Gm.Data;

/* This is used if database provider does't define
 * IGmDbSchemaMigrator implementation.
 */
public class NullGmDbSchemaMigrator : IGmDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
