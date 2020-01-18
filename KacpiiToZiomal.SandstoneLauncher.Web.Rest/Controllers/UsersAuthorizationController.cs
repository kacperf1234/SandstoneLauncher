using System;
using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces;
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
        public DatabaseContext Database;
        public IDbModelValidator DbModelValidator;
        public IDeveloperTokenActiveValidator TokenActiveValidator;
        public IStringComparer StringComparer;
        public IRestRequestGenerator RestRequestGenerator;
        
        public UsersAuthorizationController(DbTool dbTool, DatabaseContext database, IDbModelValidator dbModelValidator, IDeveloperTokenActiveValidator tokenActiveValidator, IStringComparer stringComparer, IRestRequestGenerator restRequestGenerator)
        {
            DbTool = dbTool;
            Database = database;
            DbModelValidator = dbModelValidator;
            TokenActiveValidator = tokenActiveValidator;
            StringComparer = stringComparer;
            RestRequestGenerator = restRequestGenerator;
        }

        [HttpPost]
        [Route("authorize")]
        public IActionResult Authorize(
            [FromQuery(Name = "token_id")] string tokenId,
            [FromBody] SimpleDeveloperCredentials developerCredentials,
            [FromQuery(Name = "return_url")] string returnUrl,
            [FromQuery(Name = "cancel_url")] string cancelUrl)
        {
            DeveloperToken token = DbTool.Resolve<DeveloperToken>(Database,
                tokens => tokens.SingleOrDefault(t => t.Id == tokenId));

            DeveloperCredentials credentials = DbTool.ResolveMany<DeveloperCredentials>(Database, c => c
                    .Where(x => x.ClientId == developerCredentials.ClientId)
                    .Where(x => x.ClientSecret == developerCredentials.ClientSecret))
                .SingleOrDefault();

            if (TokenActiveValidator.Validate(token) && DbModelValidator.Validate(credentials) && DbModelValidator.Validate(token))
            {
                if (StringComparer.Compare(credentials.DeveloperId, token.DeveloperId))
                {
                    RestRequest restRequest = RestRequestGenerator.Generate(credentials, token, returnUrl, cancelUrl);
                    
                    DbTool.Add(Database, restRequest);

                    return RedirectToAction("LoginForm", new {request_id = restRequest.Id});
                }
            }

            return Forbid();
        }

        [HttpGet]
        [Route("login/form")]
        public IActionResult LoginForm([FromQuery(Name = "request_id")] string requestId)
        {
            RestRequest request = DbTool.Resolve<RestRequest>(Database, requests => requests.Single(x => x.Id == requestId));

            return View(request);
        }
    }
}