using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SHD.MultiTenancy.Dto;

namespace SHD.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

