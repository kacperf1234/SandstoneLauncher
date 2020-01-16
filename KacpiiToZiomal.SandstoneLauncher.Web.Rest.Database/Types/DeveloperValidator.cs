using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types
{
    public class DeveloperValidator : IDeveloperValidator
    {
        public bool Validate(Developer dev)
        {
            return dev != null;
        }
    }
}