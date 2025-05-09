using System.Threading.Tasks;

namespace Greenwolf.SportsStats.Data;

public interface ISportsStatsDbSchemaMigrator
{
    Task MigrateAsync();
}
