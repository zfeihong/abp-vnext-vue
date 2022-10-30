using Gm.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Gm.Permissions;

public class GmPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(GmPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(GmPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<GmResource>(name);
    }
}
