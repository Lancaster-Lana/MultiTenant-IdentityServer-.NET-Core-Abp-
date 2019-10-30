using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IS.Configuration;
using IS.Web.Core;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace IS.Web.Startup
{
    [DependsOn(typeof(ISWebCoreModule))]
    public class ISWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ISWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<ISNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ISWebMvcModule).GetAssembly());
        }
    }
}