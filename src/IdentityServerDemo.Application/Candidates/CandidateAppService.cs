
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using IS.Authorization;
using IS.Candidates.Dto;

namespace IS.Application.Candidates
{
    [AbpAuthorize(PermissionNames.Pages_Candidates)]
    public class CandidateAppService : AppServiceBase, ICandidateAppService
    {
        //private readonly IRepository<Candidate, long> _candidateRepository;

        //public ICandidateAppService(
        //    IRepository<Candidate, long> candidateRepository)
        //{
        //    candidateRepository = _candidateRepository;
        //}
        public Task CreateCandidate(CreateCandidateInput input)
        {
            throw new System.NotImplementedException();
        }

        public Task<ListResultDto<CandidateListDto>> GetCandidates()
        {
            throw new System.NotImplementedException();
        }
    }
}