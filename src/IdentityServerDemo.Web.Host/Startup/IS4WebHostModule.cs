using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IS.Configuration;

namespace IS.Web.Host.Startup
{
    [DependsOn(typeof(ISWebCoreModule))]
    public class IS4WebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public IS4WebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IS4WebHostModule).GetAssembly());
        }
    }
}
