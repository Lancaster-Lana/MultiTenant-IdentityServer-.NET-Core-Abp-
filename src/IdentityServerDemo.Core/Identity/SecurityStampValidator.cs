using Abp.Authorization;
using IS.Authorization.Roles;
using IS.Authorization.Users;
using IS.MultiTenancy;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authentication;

namespace IS.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options, 
            SignInManager signInManager,
            ISystemClock systemClock) 
            :  base(options, signInManager, systemClock)
        {
        }
    }
}