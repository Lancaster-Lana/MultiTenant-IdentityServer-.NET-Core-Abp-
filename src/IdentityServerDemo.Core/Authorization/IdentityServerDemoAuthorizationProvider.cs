using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace IS.Authorization
{
    public class ISAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            //Common permissions
            var pages = context.GetPermissionOrNull(PermissionNames.Pages);
            if (pages == null)
            {
                pages = context.CreatePermission(PermissionNames.Pages, L("Pages"));
            }

            //Host permissions
            var tenants = pages.CreateChildPermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            var users = pages.CreateChildPermission(PermissionNames.Pages_Users, L("Users"));

            //user (in the tenant) permissions
            //var userProfile = users.CreateChildPermission(PermissionNames.Pages_UserProfile, L("UserProfile"));
            var clients = users.CreateChildPermission(PermissionNames.Pages_Clients, L("Clients"), multiTenancySides: MultiTenancySides.Tenant);
            var candidates = context.CreatePermission(PermissionNames.Pages_Candidates, L("Candidates"), multiTenancySides: MultiTenancySides.Tenant);
            var contracts = context.CreatePermission(PermissionNames.Pages_Contracts, L("Contracts"), multiTenancySides: MultiTenancySides.Tenant);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, ISConsts.LocalizationSourceName);
        }
    }
}
