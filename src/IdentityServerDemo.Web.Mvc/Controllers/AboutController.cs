using IS.Controllers;
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