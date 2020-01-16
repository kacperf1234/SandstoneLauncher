using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types
{
    public class DeveloperTokenValidator : IDeveloperTokenValidator
    {
        public bool Validate(DeveloperToken obj)
        {
            return obj != null;
        }
    }
}