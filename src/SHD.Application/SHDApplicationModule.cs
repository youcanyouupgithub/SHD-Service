using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SHD.Authorization;

namespace SHD
{
    [DependsOn(
        typeof(SHDCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SHDApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SHDAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SHDApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
