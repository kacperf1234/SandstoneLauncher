using System;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types
{
    public class DeveloperTokenGenerator : IDeveloperTokenGenerator
    {
        public IDeveloperTokenExpirationDateTimeGenerator ExpirationDateTimeGenerator;

        public DeveloperTokenGenerator(IDeveloperTokenExpirationDateTimeGenerator expirationDateTimeGenerator)
        {
            ExpirationDateTimeGenerator = expirationDateTimeGenerator;
        }

        public DeveloperToken GenerateToken(Developer developer)
        {
            return new DeveloperToken
            {
                DeveloperId = developer.Id,
                GeneratedAt = DateTime.Now,
                ExpiredAt = ExpirationDateTimeGenerator.GenerateExpirationDateTime(DateTime.Now)
            };
        }

        public DeveloperToken GenerateToken()
        {
            return new DeveloperToken
            {
                GeneratedAt = DateTime.Now,
                ExpiredAt = ExpirationDateTimeGenerator.GenerateExpirationDateTime(DateTime.Now)
            };
        }
    }
}