using Abp.AspNetCore.Mvc.Authorization;
using IS.Web.Core.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace IS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ISControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}