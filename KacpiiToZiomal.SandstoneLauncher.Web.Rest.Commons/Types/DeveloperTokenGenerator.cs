using System;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Types
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
            return new DeveloperToken()
            {
                DeveloperId = developer.Id,
                GeneratedAt = DateTime.Now,
                ExpiredAt = ExpirationDateTimeGenerator.GenerateExpirationDateTime(DateTime.Now)
            };
        }
    }
}