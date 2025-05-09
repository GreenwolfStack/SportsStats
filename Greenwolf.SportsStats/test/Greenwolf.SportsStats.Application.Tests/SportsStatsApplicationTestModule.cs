using Volo.Abp.Modularity;

namespace Greenwolf.SportsStats;

[DependsOn(
    typeof(SportsStatsApplicationModule),
    typeof(SportsStatsDomainTestModule)
)]
public class SportsStatsApplicationTestModule : AbpModule
{

}
