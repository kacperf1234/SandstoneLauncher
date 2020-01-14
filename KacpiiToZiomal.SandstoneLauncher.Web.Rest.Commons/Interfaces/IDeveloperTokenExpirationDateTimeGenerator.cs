using System;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces
{
    public interface IDeveloperTokenExpirationDateTimeGenerator
    {
        DateTime GenerateExpirationDateTime(DateTime basingOn);
    }
}