using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using IS.Authorization;
using IS.Candidates;
using IS.Controllers;
using IS.Users;
using Microsoft.AspNetCore.Mvc;

namespace IS.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Candidates)]
    public class CandidatesController : ISControllerBase
    {
        private readonly ICandidateAppService _candidateAppService;

        public CandidatesController(ICandidateAppService candidateAppService)
        {
            _candidateAppService = candidateAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _candidateAppService.GetCandidates();
            return View(output);
        }
    }
}