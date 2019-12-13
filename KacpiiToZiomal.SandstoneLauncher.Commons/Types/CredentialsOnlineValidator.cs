using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class CredentialsOnlineValidator : ICredentialsOnlineValidator
    {
        public bool IsOnlineCredentials(Credentials credentials)
        {
            return credentials.IsOnline;
        }
    }
}