using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using IS.Authorization;
using IS.Clients.Dto;

namespace IS.Clients
{
    [AbpAuthorize(PermissionNames.Pages_Clients)]
    public class ClientAppService : AppServiceBase, IClientAppService
    {
        //private readonly IRepository<Client, long> _clientRepository;

        //public ClientAppService(
        //    IRepository<Client, long> clientRepository)
        //{
        //    _clientRepository = clientRepository;
        //}
        public Task CreateClient(CreateClientInput input)
        {
            //_clientRepository.Create(input);
            throw new System.NotImplementedException();
        }

        public Task<ListResultDto<ClientListDto>> GetClients()
        {
            //_clientRepository.GetAll();
            throw new System.NotImplementedException();
        }
    }
}