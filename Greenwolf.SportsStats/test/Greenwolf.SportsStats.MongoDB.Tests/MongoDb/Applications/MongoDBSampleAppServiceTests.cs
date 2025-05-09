using Greenwolf.SportsStats.MongoDB;
using Greenwolf.SportsStats.Samples;
using Xunit;

namespace Greenwolf.SportsStats.MongoDb.Applications;

[Collection(SportsStatsTestConsts.CollectionDefinitionName)]
public class MongoDBSampleAppServiceTests : SampleAppServiceTests<SportsStatsMongoDbTestModule>
{

}
