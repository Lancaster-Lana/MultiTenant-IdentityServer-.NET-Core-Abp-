using Abp.IdentityServer4;
using IS.Authorization.Users;
using IS.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IS.IdentityServer
{
    public static class IdentityServerRegistrar
    {
        public static void Register(IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddIdentityServer()
                .AddDeveloperSigningCredential()
                .AddInMemoryIdentityResources(IdentityServerConfig.GetIdentityResources())
                .AddInMemoryApiResources(IdentityServerConfig.GetApiResources())
                .AddInMemoryClients(IdentityServerConfig.GetClients(configuration))
                .AddAbpPersistedGrants<ISDbContext>()
                .AddAbpIdentityServer<User>();
        }
    }
}
