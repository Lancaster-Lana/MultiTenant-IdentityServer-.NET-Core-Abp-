using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IS.Authorization;

namespace IS
{
    [DependsOn(
        typeof(ISCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ISApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ISAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ISApplicationModule).GetAssembly());
        }
    }
}