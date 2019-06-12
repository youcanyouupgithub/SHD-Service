using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SHD.Configuration.Dto;

namespace SHD.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SHDAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
