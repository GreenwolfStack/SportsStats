using Greenwolf.SportsStats.Samples;
using Xunit;

namespace Greenwolf.SportsStats.MongoDB.Domains;

[Collection(SportsStatsTestConsts.CollectionDefinitionName)]
public class MongoDBSampleDomainTests : SampleDomainTests<SportsStatsMongoDbTestModule>
{

}
