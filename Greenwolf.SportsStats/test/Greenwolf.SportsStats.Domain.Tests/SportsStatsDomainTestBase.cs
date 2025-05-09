using Volo.Abp.Modularity;

namespace Greenwolf.SportsStats;

/* Inherit from this class for your domain layer tests. */
public abstract class SportsStatsDomainTestBase<TStartupModule> : SportsStatsTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
