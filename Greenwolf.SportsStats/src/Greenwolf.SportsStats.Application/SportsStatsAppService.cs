using Greenwolf.SportsStats.Localization;
using Volo.Abp.Application.Services;

namespace Greenwolf.SportsStats;

/* Inherit your application services from this class.
 */
public abstract class SportsStatsAppService : ApplicationService
{
    protected SportsStatsAppService()
    {
        LocalizationResource = typeof(SportsStatsResource);
    }
}
