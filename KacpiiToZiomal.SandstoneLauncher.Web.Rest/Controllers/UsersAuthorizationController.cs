using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;
using Microsoft.AspNetCore.Mvc;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Controllers
{
    [Route("authorization")]
    public class UsersAuthorizationController : Controller
    {
        [HttpPost]
        [Route("login")]
        public IActionResult Login(
            [FromQuery (Name = "token_id")] string tokenId,
            [FromBody] SimpleDeveloperCredentials developerCredentials)
        {
            return Content(tokenId);
        }
    }
}