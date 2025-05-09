using Greenwolf.SportsStats.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Greenwolf.SportsStats.Permissions;

public class SportsStatsPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SportsStatsPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(SportsStatsPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SportsStatsResource>(name);
    }
}
