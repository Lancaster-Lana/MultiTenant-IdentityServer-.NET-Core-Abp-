using Abp.IdentityServer4;
using Abp.Zero.EntityFrameworkCore;
using IS.Authorization.Roles;
using IS.Authorization.Users;
using IS.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace IS.EntityFrameworkCore
{
    public class ISDbContext : AbpZeroDbContext<Tenant, Role, User, ISDbContext>, IAbpPersistedGrantDbContext
    {
        /* Define an IDbSet for each entity of the application */

        public DbSet<PersistedGrantEntity> PersistedGrants { get; set; }

        public ISDbContext(DbContextOptions<ISDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigurePersistedGrantEntity();
        }
    }
}
