using Microsoft.EntityFrameworkCore;

namespace IS.EntityFrameworkCore
{
    public static class ISDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ISDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}