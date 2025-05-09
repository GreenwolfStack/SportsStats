using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Greenwolf.SportsStats.Data;

/* This is used if database provider does't define
 * ISportsStatsDbSchemaMigrator implementation.
 */
public class NullSportsStatsDbSchemaMigrator : ISportsStatsDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
