using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SHD.Authorization.Roles;
using SHD.Authorization.Users;
using SHD.MultiTenancy;
using SHD.DomainEntity;

namespace SHD.EntityFrameworkCore
{
    public class SHDDbContext : AbpZeroDbContext<Tenant, Role, User, SHDDbContext>
    {
        public DbSet<ShdDish> Dish { get; set; }

        public SHDDbContext(DbContextOptions<SHDDbContext> options)
            : base(options)
        {
        }
    }
}
