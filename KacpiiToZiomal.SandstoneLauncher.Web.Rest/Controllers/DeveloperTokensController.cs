using System;
using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Controllers
{
    [Route("developer_tokens")]
    public class DeveloperTokensController : Controller
    {
        public IDeveloperCredentialsFinder DeveloperCredentialsFinder;
        public IDeveloperCredentialsValidator DeveloperCredentialsValidator;
        public IDeveloperFinder DeveloperFinder;
        public IDeveloperTokenActiveValidator DeveloperTokenActiveValidator;
        public IDatabaseUpdater<DeveloperToken> DeveloperTokenDatabaseUpdater;
        public IDeveloperTokenGenerator DeveloperTokenGenerator;
        public IDeveloperTokensGetter DeveloperTokensGetter;
        public IDeveloperTokenValidator DeveloperTokenValidator;
        public IDeveloperTokenExpirationDateTimeGenerator ExpirationDateTimeGenerator;
        public IDeveloperTokenRecorderToDatabase RecorderToDatabase;
        public IDeveloperValidator DeveloperValidator;

        public DeveloperTokensController(IDeveloperCredentialsValidator developerCredentialsValidator,
            IDeveloperCredentialsFinder developerCredentialsFinder, IDeveloperFinder developerFinder,
            IDeveloperTokenGenerator developerTokenGenerator, IDeveloperTokenRecorderToDatabase recorderToDatabase,
            IDeveloperTokenValidator developerTokenValidator, IDeveloperTokensGetter developerTokensGetter,
            IDeveloperTokenActiveValidator developerTokenActiveValidator,
            IDeveloperTokenExpirationDateTimeGenerator expirationDateTimeGenerator,
            IDatabaseUpdater<DeveloperToken> developerTokenDatabaseUpdater, IDeveloperValidator developerValidator)
        {
            DeveloperCredentialsValidator = developerCredentialsValidator;
            DeveloperCredentialsFinder = developerCredentialsFinder;
            DeveloperFinder = developerFinder;
            DeveloperTokenGenerator = developerTokenGenerator;
            RecorderToDatabase = recorderToDatabase;
            DeveloperTokenValidator = developerTokenValidator;
            DeveloperTokensGetter = developerTokensGetter;
            DeveloperTokenActiveValidator = developerTokenActiveValidator;
            ExpirationDateTimeGenerator = expirationDateTimeGenerator;
            DeveloperTokenDatabaseUpdater = developerTokenDatabaseUpdater;
            DeveloperValidator = developerValidator;
        }

        [HttpGet]
        [Route("generate")]
        public IActionResult Generate()
        {
            DeveloperToken developerToken = DeveloperTokenGenerator.GenerateToken();

            RecorderToDatabase.Add(developerToken);

            return Json(developerToken);
        }

        [HttpGet]
        [Route("update")]
        public IActionResult Update([FromQuery(Name = "id")] string id, [FromQuery(Name = "developer_id")] string developerId)
        {
            DeveloperToken token =
                DeveloperTokensGetter.GetDeveloperToken(t => t.SingleOrDefault(x => x.Id == id && x.DeveloperId == developerId));

            if (DeveloperTokenValidator.Validate(token))
            {
                if (DeveloperTokenActiveValidator.Validate(token))
                {
                    DeveloperTokenDatabaseUpdater.Update(token.Id, t =>
                    {
                        t.LastUpdatedAt = DateTime.Now;
                        t.ExpiredAt = ExpirationDateTimeGenerator.GenerateExpirationDateTime(DateTime.Now);
                        t.UpdatedTimes += 1;
                    }, out token);

                    return Json(token);
                }
            }

            return BadRequest();
        }

        [HttpPost]
        [Route("authorize")]
        public IActionResult Authorize([FromBody] SimpleDeveloperCredentials credentials, string id)
        {
            Developer developer = DeveloperFinder.GetDeveloper(credentials.ClientId, credentials.ClientSecret);

            if (DeveloperValidator.Validate(developer))
            {
                DeveloperTokenDatabaseUpdater.Update(id, token =>
                {
                    token.Authorized = true;
                    token.AuthorizedAt = DateTime.Now;
                    token.DeveloperId = developer.Id;
                });

                return Ok();
            }

            return BadRequest();
        }

        [HttpPost]
        [Route("unauthorize")]
        public IActionResult Unauthorize([FromBody] SimpleDeveloperCredentials credentials, string id)
        {
            Developer developer = DeveloperFinder.GetDeveloper(credentials.ClientId, credentials.ClientSecret);

            if (DeveloperValidator.Validate(developer))
            {
                DeveloperTokenDatabaseUpdater.Update(id, token =>
                {
                    token.Unauthorized = true;
                    token.UnauthorizedAt = DateTime.Now;
                });

                return Ok();
            }

            return BadRequest();
        }
    }
}