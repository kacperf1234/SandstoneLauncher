using KacpiiToZiomal.SandstoneLauncher.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces
{
    public interface IActuallyLoggedValidator
    {
        bool IsActuallyLogged(CredentialsData credentialsData);
    }
}