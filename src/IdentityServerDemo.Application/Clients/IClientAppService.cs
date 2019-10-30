using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IS.Clients.Dto;

namespace IS.Application.Clients
{
    public interface IClientAppService : IApplicationService
    {
 
        Task<ListResultDto<ClientListDto>> GetClients();

        Task CreateClient(CreateClientInput input);
    }
}