using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IS.Candidates.Dto;

namespace IS.Application.Candidates
{
    public interface ICandidateAppService : IApplicationService
    {
        Task<ListResultDto<CandidateListDto>> GetCandidates();

        Task CreateCandidate(CreateCandidateInput input);
    }
}