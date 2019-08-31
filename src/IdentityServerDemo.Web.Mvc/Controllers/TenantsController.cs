using Abp.AspNetCore.Mvc.Authorization;
using IS.Authorization;
using IS.Controllers;
using IS.MultiTenancy;
using Microsoft.AspNetCore.Mvc;

namespace IS.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : ISControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}