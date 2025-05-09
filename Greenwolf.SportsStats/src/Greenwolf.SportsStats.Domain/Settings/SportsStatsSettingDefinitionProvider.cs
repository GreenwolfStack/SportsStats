using Volo.Abp.Settings;

namespace Greenwolf.SportsStats.Settings;

public class SportsStatsSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SportsStatsSettings.MySetting1));
    }
}
