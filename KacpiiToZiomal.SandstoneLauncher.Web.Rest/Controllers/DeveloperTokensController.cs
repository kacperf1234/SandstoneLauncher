using System;
using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models;
using Microsoft.AspNetCore.Mvc;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Controllers
{
    [Route("developer_tokens")]
    public class DeveloperTokensController : Controller
    {
        public IDeveloperCredentialsFinder DeveloperCredentialsFinder;
        public IDeveloperCredentialsValidator DeveloperCredentialsValidator;
        public IDeveloperFinder DeveloperFinder;
        public IDeveloperTokenArchivedValidator DeveloperTokenArchivedValidator;
        public IDatabaseUpdater<DeveloperToken> DeveloperTokenDatabaseUpdater;
        public IDeveloperTokenGenerator DeveloperTokenGenerator;
        public IDeveloperTokensGetter DeveloperTokensGetter;
        public IDeveloperTokenValidator DeveloperTokenValidator;
        public IDeveloperTokenExpirationDateTimeGenerator ExpirationDateTimeGenerator;
        public IDeveloperTokenRecorderToDatabase RecorderToDatabase;

        public DeveloperTokensController(IDeveloperCredentialsValidator developerCredentialsValidator,
            IDeveloperCredentialsFinder developerCredentialsFinder, IDeveloperFinder developerFinder,
            IDeveloperTokenGenerator developerTokenGenerator, IDeveloperTokenRecorderToDatabase recorderToDatabase,
            IDeveloperTokenValidator developerTokenValidator, IDeveloperTokensGetter developerTokensGetter,
            IDeveloperTokenArchivedValidator developerTokenArchivedValidator,
            IDeveloperTokenExpirationDateTimeGenerator expirationDateTimeGenerator,
            IDatabaseUpdater<DeveloperToken> developerTokenDatabaseUpdater)
        {
            DeveloperCredentialsValidator = developerCredentialsValidator;
            DeveloperCredentialsFinder = developerCredentialsFinder;
            DeveloperFinder = developerFinder;
            DeveloperTokenGenerator = developerTokenGenerator;
            RecorderToDatabase = recorderToDatabase;
            DeveloperTokenValidator = developerTokenValidator;
            DeveloperTokensGetter = developerTokensGetter;
            DeveloperTokenArchivedValidator = developerTokenArchivedValidator;
            ExpirationDateTimeGenerator = expirationDateTimeGenerator;
            DeveloperTokenDatabaseUpdater = developerTokenDatabaseUpdater;
        }

        [HttpGet]
        [Route("generate")]
        public IActionResult Generate([FromQuery(Name = "client_id")] string clientId,
            [FromQuery(Name = "client_secret")] string clientSecret)
        {
            DeveloperCredentials credentials = DeveloperCredentialsFinder.GetByCredentials(clientId, clientSecret);

            if (DeveloperCredentialsValidator.Validate(credentials))
            {
                Developer developer = DeveloperFinder.GetDeveloper(credentials);
                DeveloperToken developerToken = DeveloperTokenGenerator.GenerateToken(developer);

                RecorderToDatabase.Add(developerToken);

                return Json(developerToken);
            }

            return Unauthorized();
        }

        [HttpGet]
        [Route("update")]
        public IActionResult Update([FromQuery(Name = "id")] string id, [FromQuery(Name = "developer_id")] string developerId)
        {
            DeveloperToken token =
                DeveloperTokensGetter.GetDeveloperToken(t => t.SingleOrDefault(x => x.Id == id && x.DeveloperId == developerId));

            if (DeveloperTokenValidator.Validate(token))
            {
                if (DeveloperTokenArchivedValidator.Validate(token))
                {
                    DeveloperTokenDatabaseUpdater.Update(token.Id, t =>
                    {
                        t.LastUpdatedAt = DateTime.Now;
                        t.ExpiredAt = ExpirationDateTimeGenerator.GenerateExpirationDateTime(DateTime.Now);
                        t.UpdatedTimes += 1;
                    }, out token);

                    return Json(token);
                }

                return BadRequest();
            }

            return BadRequest();
        }
    }
}