using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces
{
    public interface IDeveloperValidator
    {
        bool Validate(Developer dev);
    }
}