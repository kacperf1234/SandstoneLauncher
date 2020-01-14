using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces
{
    public interface IDeveloperCredentialsValidator
    {
        bool Validate(DeveloperCredentials credentials);
    }
}