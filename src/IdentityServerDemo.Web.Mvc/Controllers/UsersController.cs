using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using IS.Authorization;
using IS.Controllers;
using IS.Users;
using Microsoft.AspNetCore.Mvc;

namespace IS.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class UsersController : ISControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _userAppService.GetUsers();
            return View(output);
        }
    }
}