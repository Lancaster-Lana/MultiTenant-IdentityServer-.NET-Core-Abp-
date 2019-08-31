using Abp.AspNetCore.Mvc.Authorization;
using IS.Controllers;
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