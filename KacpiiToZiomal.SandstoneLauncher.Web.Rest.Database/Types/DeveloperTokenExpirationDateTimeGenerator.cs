using System;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types
{
    public class DeveloperTokenExpirationDateTimeGenerator : IDeveloperTokenExpirationDateTimeGenerator
    {
        public DateTime GenerateExpirationDateTime(DateTime basingOn)
        {
            return basingOn.AddHours(1);
        }
    }
}