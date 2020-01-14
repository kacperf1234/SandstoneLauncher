using System;
using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;
using Microsoft.AspNetCore.Mvc;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Controllers
{
    [Route("developer_tokens")]
    public class DeveloperTokensController : Controller
    {
        public IDeveloperCredentialsValidator DeveloperCredentialsValidator;
        public IDeveloperCredentialsFinder DeveloperCredentialsFinder;
        public IDeveloperFinder DeveloperFinder;
        public IDeveloperTokenGenerator DeveloperTokenGenerator;
        public IDeveloperTokenRecorderToDatabase RecorderToDatabase;

        public DeveloperTokensController(IDeveloperCredentialsValidator developerCredentialsValidator, IDeveloperCredentialsFinder developerCredentialsFinder, IDeveloperFinder developerFinder, IDeveloperTokenGenerator developerTokenGenerator, IDeveloperTokenRecorderToDatabase recorderToDatabase)
        {
            DeveloperCredentialsValidator = developerCredentialsValidator;
            DeveloperCredentialsFinder = developerCredentialsFinder;
            DeveloperFinder = developerFinder;
            DeveloperTokenGenerator = developerTokenGenerator;
            RecorderToDatabase = recorderToDatabase;
        }

        [HttpPost]
        [Route("generate")]
        public IActionResult Generate([FromQuery(Name = "client_id")] string clientId, [FromQuery(Name = "client_secret")] string clientSecret)
        {
            DeveloperCredentials credentials = DeveloperCredentialsFinder.GetByCredentials(clientId, clientSecret);

            if (DeveloperCredentialsValidator.Validate(credentials))
            {
                Developer developer = DeveloperFinder.Find(credentials);
                DeveloperToken developerToken = DeveloperTokenGenerator.GenerateToken(developer);
                
                RecorderToDatabase.Add(developerToken);

                return Json(developerToken);
            }

            return Unauthorized();
        }
    }
}