using System.Threading.Tasks;
using Abp.Application.Services;
using SHD.Authorization.Accounts.Dto;

namespace SHD.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
