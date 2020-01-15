using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces
{
    public interface IDeveloperFinder
    {
        Developer GetDeveloper(DeveloperCredentials credentials);

        Developer GetDeveloper(string credentialsId);
    }
}