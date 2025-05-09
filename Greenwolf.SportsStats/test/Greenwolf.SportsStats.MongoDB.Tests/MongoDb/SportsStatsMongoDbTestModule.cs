using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;
using Volo.Abp.Uow;

namespace Greenwolf.SportsStats.MongoDB;

[DependsOn(
    typeof(SportsStatsApplicationTestModule),
    typeof(SportsStatsMongoDbModule)
)]
public class SportsStatsMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = SportsStatsMongoDbFixture.GetRandomConnectionString();
        });
    }
}
