
using IS.Web.Core.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace IS.Web.Controllers
{
    public class AboutController : ISControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}