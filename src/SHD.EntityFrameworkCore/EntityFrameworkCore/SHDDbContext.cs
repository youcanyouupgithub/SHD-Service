using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SHD.Authorization.Roles;
using SHD.Authorization.Users;
using SHD.MultiTenancy;

namespace SHD.EntityFrameworkCore
{
    public class SHDDbContext : AbpZeroDbContext<Tenant, Role, User, SHDDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SHDDbContext(DbContextOptions<SHDDbContext> options)
            : base(options)
        {
        }
    }
}
