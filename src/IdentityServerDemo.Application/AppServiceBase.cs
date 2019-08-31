using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Abp.Runtime.Session;
using Abp.IdentityFramework;
using Abp.Application.Services;
using IS.MultiTenancy;
using IS.Authorization.Users;

namespace IS
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class AppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected AppServiceBase()
        {
            LocalizationSourceName = ISConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId().ToString());
            if (user == null)
            {
                throw new Exception("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}