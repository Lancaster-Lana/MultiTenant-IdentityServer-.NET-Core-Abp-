using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using IS.Authorization;
using IS.Clients.Dto;
using IS.Contracts.Dto;

namespace IS.Application.Contracts
{
    [AbpAuthorize(PermissionNames.Pages_Contracts)]
    public class ContractAppService : AppServiceBase, IContractAppService
    {
        //private readonly IRepository<Contract, long> _contractRepository;

        //public ClientAppService(
        //    IRepository<Contract, long> contractRepository)
        //{
        //    _contractRepository = contractRepository;
        //}
        public Task CreateContract(CreateContractInput input)
        {
            //_contractRepository.Create(input);
            throw new System.NotImplementedException();
        }

        public Task<ListResultDto<ContractListDto>> GetContracts()
        {
            //contractRepository.GetAll();
            throw new System.NotImplementedException();
        }
    }
}