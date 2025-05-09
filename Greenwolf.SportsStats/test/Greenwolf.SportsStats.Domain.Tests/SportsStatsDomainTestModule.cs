using Volo.Abp.Modularity;

namespace Greenwolf.SportsStats;

[DependsOn(
    typeof(SportsStatsDomainModule),
    typeof(SportsStatsTestBaseModule)
)]
public class SportsStatsDomainTestModule : AbpModule
{

}
