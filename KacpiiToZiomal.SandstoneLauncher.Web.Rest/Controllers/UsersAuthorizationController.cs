using System.Collections.Generic;
using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types;
using Microsoft.AspNetCore.Mvc;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Controllers
{
    [Route("auth")]
    public class UsersAuthorizationController : Controller
    {
        public DbTool DbTool;
        public DatabaseContext Context;
        public IDbModelValidator DbModelValidator;
        public IDeveloperTokenActiveValidator TokenActiveValidator;
        public IStringComparer StringComparer; // todo

        public UsersAuthorizationController(DbTool dbTool, DatabaseContext context)
        {
            DbTool = dbTool;
            Context = context;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(
            [FromQuery(Name = "token_id")] string tokenId,
            [FromBody] SimpleDeveloperCredentials developerCredentials,
            [FromQuery(Name = "return_url")] string returnUrl,
            [FromQuery(Name = "cancel_url")] string cancelUrl)
        {
            DeveloperToken token = DbTool.Get<DeveloperToken>(Context,
                tokens => tokens.SingleOrDefault(t => t.Id == tokenId));

            DeveloperCredentials credentials = DbTool.Get<DeveloperCredentials>(Context, c => c
                    .Where(x => x.ClientId == developerCredentials.ClientId)
                    .Where(x => x.ClientSecret == developerCredentials.ClientSecret))
                .SingleOrDefault();

            if (TokenActiveValidator.Validate(token) && DbModelValidator.Validate(credentials))
            {
                if (StringComparer.Compare(credentials.DeveloperId, token.DeveloperId))
                {
                    return RedirectToAction("LoginForm", new {request_id = });
                }
            }

            return BadRequest();
        }

        [HttpGet]
        [Route("login/form")]
        public IActionResult LoginForm([FromQuery(Name = "request_id")] string requestId)
        {
            
        }
    }
}