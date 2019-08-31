using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IS.MultiTenancy.Dto;

namespace IS.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
