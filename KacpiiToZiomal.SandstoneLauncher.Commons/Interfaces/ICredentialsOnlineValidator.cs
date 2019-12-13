using KacpiiToZiomal.SandstoneLauncher.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces
{
    public interface ICredentialsOnlineValidator
    {
        bool IsOnlineCredentials(Credentials credentials);
    }
}