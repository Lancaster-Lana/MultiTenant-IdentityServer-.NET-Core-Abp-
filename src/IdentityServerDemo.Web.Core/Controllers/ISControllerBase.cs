using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using IS.Core;
using Microsoft.AspNetCore.Identity;

namespace IS.Web.Core.Controllers
{
    public abstract class ISControllerBase: AbpController
    {
        protected ISControllerBase()
        {
            LocalizationSourceName = ISConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}