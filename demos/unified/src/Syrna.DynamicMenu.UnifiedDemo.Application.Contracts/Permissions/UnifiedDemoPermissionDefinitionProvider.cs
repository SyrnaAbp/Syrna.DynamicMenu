using Syrna.DynamicMenu.UnifiedDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Syrna.DynamicMenu.UnifiedDemo.Permissions;

public class UnifiedDemoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var accountingPreGroup = context.AddGroup(UnifiedDemoPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(DemoPermissions.MyPermission1, L("Permission:MyPermission1"));

        accountingPreGroup.AddPermission("UnifiedDemo", L("Permission:UnifiedDemo"));

        //var notePermission = accountingPreGroup.AddPermission(DemoPermissions.Note.Default, L("Permission:Note"));
        //notePermission.AddChild(DemoPermissions.Note.Create, L("Permission:Note.Create"));
        //notePermission.AddChild(DemoPermissions.Note.Update, L("Permission:Note.Update"));
        //notePermission.AddChild(DemoPermissions.Note.Delete, L("Permission:Note.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<UnifiedDemoResource>(name);
    }
}
