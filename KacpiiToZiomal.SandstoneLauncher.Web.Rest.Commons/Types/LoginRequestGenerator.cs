using System;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Types
{
    public class LoginRequestGenerator : ILoginRequestGenerator
    {
        public LoginRequest Generate(Developer developer, DeveloperToken developerToken, string returnUrl, string cancelUrl) =>
            new LoginRequest()
            {
                Id = Guid.NewGuid().ToString(),
                TokenId = developerToken.Id,
                DeveloperId = developer.Id,
                CancelUrl = cancelUrl,
                ReturnUrl = returnUrl,
                GeneratedAt = DateTime.Now
            };
    }
}