using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IS.Contracts.Dto;

namespace IS.Application.Contracts
{
    public interface IContractAppService : IApplicationService
    {
        Task<ListResultDto<ContractListDto>> GetContracts();

        Task CreateContract(CreateContractInput input);
    }
}