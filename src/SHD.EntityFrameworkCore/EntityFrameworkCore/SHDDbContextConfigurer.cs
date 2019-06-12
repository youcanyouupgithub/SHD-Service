using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SHD.EntityFrameworkCore
{
    public static class SHDDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SHDDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SHDDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
