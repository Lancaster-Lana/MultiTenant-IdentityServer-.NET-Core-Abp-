using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using IS.Authorization;
using IS.Web.Core.Controllers;
using IS.Application.Contracts;

namespace IS.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Contracts)]
    public class ContractsController : ISControllerBase
    {
        private readonly IContractAppService _contractAppService;

        public ContractsController(IContractAppService contractAppService)
        {
            _contractAppService = contractAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _contractAppService.GetContracts();
            return View(output);
        }
    }
}