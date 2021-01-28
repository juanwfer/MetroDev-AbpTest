using Abp.Application.Services;
using MetroDev.Boilerplate.MultiTenancy.Dto;

namespace MetroDev.Boilerplate.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

