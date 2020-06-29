using AbpFirstProject.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpFirstProject.Permissions
{
    public class AbpFirstProjectPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpFirstProjectPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpFirstProjectPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpFirstProjectResource>(name);
        }
    }
}
