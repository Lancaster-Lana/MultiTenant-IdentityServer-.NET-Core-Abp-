﻿using Abp.Authorization;
using Abp.Configuration;
using Abp.Domain.Uow;
using IS.Authorization.Roles;
using IS.Authorization.Users;
using IS.MultiTenancy;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace IS.Identity
{
    public class SignInManager : AbpSignInManager<Tenant, Role, User>
    {
        public SignInManager(
            UserManager userManager, 
            IHttpContextAccessor contextAccessor,
            UserClaimsPrincipalFactory claimsFactory, 
            IOptions<IdentityOptions> optionsAccessor, 
            ILogger<SignInManager<User>> logger,
            IUnitOfWorkManager unitOfWorkManager,
            ISettingManager settingManager,
            IAuthenticationSchemeProvider schemes
        ) : base(
            userManager, 
            contextAccessor, 
            claimsFactory, 
            optionsAccessor, 
            logger,
            unitOfWorkManager,
            settingManager,
            schemes)
        {
        }
    }
}
