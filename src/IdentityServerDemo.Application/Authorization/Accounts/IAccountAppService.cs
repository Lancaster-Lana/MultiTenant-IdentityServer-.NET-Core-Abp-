using System.Threading.Tasks;
using Abp.Application.Services;
using IS.Authorization.Accounts.Dto;

namespace IS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
