using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using IS.Authorization;
using IS.Clients;
using IS.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace IS.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Clients)]
    public class ClientsController : ISControllerBase
    {
        private readonly IClientAppService _clientAppService;

        public ClientsController(IClientAppService clientAppService)
        {
            _clientAppService = clientAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _clientAppService.GetClients();
            return View(output);
        }
    }
}