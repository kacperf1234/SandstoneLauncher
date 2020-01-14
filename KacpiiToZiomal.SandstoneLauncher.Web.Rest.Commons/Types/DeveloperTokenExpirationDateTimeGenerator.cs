using System;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Types
{
    public class DeveloperTokenExpirationDateTimeGenerator : IDeveloperTokenExpirationDateTimeGenerator
    {
        public DateTime GenerateExpirationDateTime(DateTime basingOn) => basingOn.AddHours(1);
    }
}