using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using IS.Localization;
using Abp.Zero.Configuration;
using IS.MultiTenancy;
using IS.Authorization.Roles;
using IS.Authorization.Users;
using IS.Configuration;
using IS.Timing;

namespace IS
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class ISCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            //Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            ISLocalizationConfigurer.Configure(Configuration.Localization);

            //Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = ISConsts.MultiTenancyEnabled;

            //Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ISCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}