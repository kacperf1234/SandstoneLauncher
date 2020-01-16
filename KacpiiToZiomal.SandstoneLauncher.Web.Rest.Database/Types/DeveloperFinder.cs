using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types
{
    public class DeveloperFinder : IDeveloperFinder
    {
        public DatabaseContext DatabaseContext;

        public DeveloperFinder(DatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }

        public Developer GetDeveloper(DeveloperCredentials credentials)
        {
            return DatabaseContext.Developers
                .SingleOrDefault(dev => dev.CredentialsId == credentials.Id);
        }

        public Developer GetDeveloper(string credentialsId)
        {
            return DatabaseContext.Developers
                .SingleOrDefault(dev => dev.CredentialsId == credentialsId);
        }
    }
}