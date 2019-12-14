using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class ActuallyLoggedValidator : IActuallyLoggedValidator
    {
        public bool IsActuallyLogged(CredentialsData credentialsData)
        {
            return credentialsData.Actually != null;
        }
    }
}