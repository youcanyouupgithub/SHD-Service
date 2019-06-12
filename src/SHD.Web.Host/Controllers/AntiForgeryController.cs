using Microsoft.AspNetCore.Antiforgery;
using SHD.Controllers;

namespace SHD.Web.Host.Controllers
{
    public class AntiForgeryController : SHDControllerBase
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
