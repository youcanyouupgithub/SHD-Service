using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SHD.Controllers
{
    public abstract class SHDControllerBase: AbpController
    {
        protected SHDControllerBase()
        {
            LocalizationSourceName = SHDConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
