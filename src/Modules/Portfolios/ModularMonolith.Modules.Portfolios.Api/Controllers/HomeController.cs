using Microsoft.AspNetCore.Mvc;

namespace ModularMonolith.Modules.Portfolios.Api.Controllers
{
    [Route(BasePath)]
    internal class HomeController : BaseController
    {
        [HttpGet]
        public ActionResult<string> Get() => "Portfolios Module";
    }
}