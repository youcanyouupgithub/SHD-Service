using System.Threading.Tasks;
using SHD.Configuration.Dto;

namespace SHD.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
