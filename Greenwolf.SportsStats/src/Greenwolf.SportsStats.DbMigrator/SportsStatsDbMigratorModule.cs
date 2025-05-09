using Greenwolf.SportsStats.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Greenwolf.SportsStats.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SportsStatsMongoDbModule),
    typeof(SportsStatsApplicationContractsModule)
)]
public class SportsStatsDbMigratorModule : AbpModule
{
}
