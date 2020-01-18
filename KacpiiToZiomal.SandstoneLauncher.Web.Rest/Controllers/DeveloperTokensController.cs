using System;
using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Builders;
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
        public IDeveloperFinder DeveloperFinder;
        public IDeveloperTokenActiveValidator DeveloperTokenActiveValidator;
        public IDeveloperTokenGenerator DeveloperTokenGenerator;
        public IDeveloperTokensGetter DeveloperTokensGetter;
        public IDeveloperTokenValidator DeveloperTokenValidator;
        public IDeveloperTokenExpirationDateTimeGenerator ExpirationDateTimeGenerator;
        public IDeveloperTokenRecorderToDatabase RecorderToDatabase;
        public IDeveloperValidator DeveloperValidator;

        public IDbTool DbTool;
        public DatabaseContext Database;

        public DeveloperTokensController(IDeveloperFinder developerFinder,
            IDeveloperTokenGenerator developerTokenGenerator, IDeveloperTokenRecorderToDatabase recorderToDatabase,
            IDeveloperTokenValidator developerTokenValidator, IDeveloperTokensGetter developerTokensGetter,
            IDeveloperTokenActiveValidator developerTokenActiveValidator,
            IDeveloperTokenExpirationDateTimeGenerator expirationDateTimeGenerator, IDeveloperValidator developerValidator, DatabaseContext database, IDbTool dbTool)
        {
            DeveloperFinder = developerFinder;
            DeveloperTokenGenerator = developerTokenGenerator;
            RecorderToDatabase = recorderToDatabase;
            DeveloperTokenValidator = developerTokenValidator;
            DeveloperTokensGetter = developerTokensGetter;
            DeveloperTokenActiveValidator = developerTokenActiveValidator;
            ExpirationDateTimeGenerator = expirationDateTimeGenerator;
            DeveloperValidator = developerValidator;
            Database = database;
            DbTool = dbTool;
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
            DeveloperToken token = DbTool.Resolve<DeveloperToken>(Database,
                t => t.SingleOrDefault(x => x.Id == id && x.DeveloperId == developerId));

            if (DeveloperTokenValidator.Validate(token))
            {
                if (DeveloperTokenActiveValidator.Validate(token))
                {
                    DbTool.Update<DeveloperToken>(Database, token, t =>
                    {
                        new DeveloperTokenBuilder(token)
                            .AddUpdatedTimes()
                            .SetExpiredAt(ExpirationDateTimeGenerator.GenerateExpirationDateTime(DateTime.Now))
                            .SetLastUpdatedAt()
                            .Build();
                    });

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
                DbTool.Update<DeveloperToken>(Database, id, token =>
                {
                    new DeveloperTokenBuilder(token)
                        .SetAuthorized()
                        .SetAuthorizedAt()
                        .Build();
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
                DbTool.Update<DeveloperToken>(
                    dbContext: Database,
                    func: tokens => tokens.Single(x => x.Id == id),
                    action: token =>
                    {
                        new DeveloperTokenBuilder(token)
                            .SetArchived()
                            .SetUnauthorized()
                            .SetUnauthorizedAt()
                            .Build();
                    }
                );

                return Ok();
            }

            return BadRequest();
        }
    }
}