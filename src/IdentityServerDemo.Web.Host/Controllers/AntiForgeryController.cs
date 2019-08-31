using IS.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace IS.Web.Host.Controllers
{
    public class AntiForgeryController : ISControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}