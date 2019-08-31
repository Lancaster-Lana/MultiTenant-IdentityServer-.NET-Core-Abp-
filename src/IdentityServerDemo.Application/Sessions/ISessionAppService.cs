using System.Threading.Tasks;
using Abp.Application.Services;
using IS.Sessions.Dto;

namespace IS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
