using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Types
{
    public class DeveloperFinder : IDeveloperFinder
    {
        public DatabaseContext DatabaseContext;

        public DeveloperFinder(DatabaseContext database_context)
        {
            DatabaseContext = database_context;
        }

        public Developer Find(DeveloperCredentials credentials) =>
            DatabaseContext.Developers
                .SingleOrDefault(dev => dev.CredentialsId == credentials.Id);

        public Developer Find(string credentialsId) => DatabaseContext.Developers
            .SingleOrDefault(dev => dev.CredentialsId == credentialsId);
    }
}