using Volo.Abp.Modularity;

namespace Greenwolf.SportsStats;

public abstract class SportsStatsApplicationTestBase<TStartupModule> : SportsStatsTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
