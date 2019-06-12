using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SHD.Roles.Dto;
using SHD.Users.Dto;

namespace SHD.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
