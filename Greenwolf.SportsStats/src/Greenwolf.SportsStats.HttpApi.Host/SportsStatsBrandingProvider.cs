using Microsoft.Extensions.Localization;
using Greenwolf.SportsStats.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Greenwolf.SportsStats;

[Dependency(ReplaceServices = true)]
public class SportsStatsBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<SportsStatsResource> _localizer;

    public SportsStatsBrandingProvider(IStringLocalizer<SportsStatsResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
