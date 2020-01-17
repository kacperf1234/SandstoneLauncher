using System.Collections.Generic;
using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types;
using Microsoft.AspNetCore.Mvc;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Controllers
{
    [Route("authorization")]
    public class UsersAuthorizationController : Controller
    {
        public DbTool Tool;
        public DatabaseContext Context;

        public UsersAuthorizationController(DbTool tool, DatabaseContext context)
        {
            Tool = tool;
            Context = context;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(
            [FromQuery (Name = "token_id")] string tokenId,
            [FromBody] SimpleDeveloperCredentials developerCredentials)
        {
            return Content(tokenId);
        }

        [HttpGet]
        [Route("get")]
        public IActionResult Get()
        {
            IEnumerable<User> users = Tool.Get<User>(Context, a => a);

            return Json(users);
        }
    }
}