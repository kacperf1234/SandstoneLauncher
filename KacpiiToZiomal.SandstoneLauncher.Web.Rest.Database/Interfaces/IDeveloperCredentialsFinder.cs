using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces
{
    public interface IDeveloperCredentialsFinder
    {
        DeveloperCredentials GetByCredentials(string clientId, string clientSecret);

        DeveloperCredentials GetById(string credentialsId);
    }
}