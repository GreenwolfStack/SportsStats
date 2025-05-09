using Volo.Abp.Data;
using Volo.Abp.MongoDB;
using MongoDB.Driver;

namespace Greenwolf.SportsStats.MongoDB;

[ConnectionStringName("Default")]
public class SportsStatsMongoDbContext : AbpMongoDbContext
{

    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        //builder.Entity<YourEntity>(b =>
        //{
        //    //...
        //});
    }
}
