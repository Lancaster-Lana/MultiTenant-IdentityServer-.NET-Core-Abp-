using IS.Configuration;
using IS.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace IS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ISDbContextFactory : IDesignTimeDbContextFactory<ISDbContext>
    {
        public ISDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ISDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder(), addUserSecrets: true);

            ISDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ISConsts.ConnectionStringName));

            return new ISDbContext(builder.Options);
        }
    }
}