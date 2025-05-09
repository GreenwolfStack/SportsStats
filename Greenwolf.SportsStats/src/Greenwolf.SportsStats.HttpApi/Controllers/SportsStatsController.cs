using Greenwolf.SportsStats.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Greenwolf.SportsStats.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SportsStatsController : AbpControllerBase
{
    protected SportsStatsController()
    {
        LocalizationResource = typeof(SportsStatsResource);
    }
}
