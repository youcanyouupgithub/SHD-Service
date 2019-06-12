using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SHD.Configuration;
using SHD.Web;

namespace SHD.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SHDDbContextFactory : IDesignTimeDbContextFactory<SHDDbContext>
    {
        public SHDDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SHDDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SHDDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SHDConsts.ConnectionStringName));

            return new SHDDbContext(builder.Options);
        }
    }
}
