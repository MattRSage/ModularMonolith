using Microsoft.AspNetCore.Mvc;

namespace ModularMonolith.Modules.Portfolios.Api.Controllers
{
    [ApiController]
    [Route(BasePath + "/[controller]")]
    internal abstract class BaseController : ControllerBase
    {
        protected const string BasePath = "portfolios-module";
    }
}