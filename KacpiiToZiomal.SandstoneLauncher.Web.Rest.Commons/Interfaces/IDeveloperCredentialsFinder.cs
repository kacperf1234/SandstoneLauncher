using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces
{
    public interface IDeveloperCredentialsFinder
    {
        DeveloperCredentials GetByCredentials(string clientId, string clientSecret);

        DeveloperCredentials GetById(string credentialsId);
    }
}