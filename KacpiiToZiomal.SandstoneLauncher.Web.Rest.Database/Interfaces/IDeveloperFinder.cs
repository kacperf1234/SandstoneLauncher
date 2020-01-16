using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces
{
    public interface IDeveloperFinder
    {
        Developer GetDeveloper(DeveloperCredentials credentials);

        Developer GetDeveloper(string credentialsId);

        Developer GetDeveloper(string clientId, string clientSecret);
    }
}