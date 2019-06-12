using System.Threading.Tasks;
using Abp.Application.Services;
using SHD.Sessions.Dto;

namespace SHD.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
