using Microsoft.AspNetCore.Mvc;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Controllers
{
    [Route("launch_settings")]
    public class LaunchSettingsController : Controller
    {
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Content("");

        [HttpGet]
        [Route("list/user/{id}")]
        public IActionResult ListOfUser(string id) => Content("wsadz se chuja w dupe");

        [HttpGet]
        [Route("list/developer/{id}")]
        public IActionResult ListOfDeveloper(string id) => Content("");
    }
}