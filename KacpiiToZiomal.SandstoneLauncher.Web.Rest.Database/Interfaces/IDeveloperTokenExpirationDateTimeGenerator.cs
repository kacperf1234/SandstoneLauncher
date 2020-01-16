using System;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces
{
    public interface IDeveloperTokenExpirationDateTimeGenerator
    {
        DateTime GenerateExpirationDateTime(DateTime basingOn);
    }
}