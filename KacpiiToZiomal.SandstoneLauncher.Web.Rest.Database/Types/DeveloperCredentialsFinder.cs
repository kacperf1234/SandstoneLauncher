using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types
{
    public class DeveloperCredentialsFinder : IDeveloperCredentialsFinder
    {
        public DatabaseContext DatabaseContext;

        public DeveloperCredentialsFinder(DatabaseContext database_context)
        {
            DatabaseContext = database_context;
        }

        public DeveloperCredentials GetByCredentials(string clientId, string clientSecret)
        {
            return DatabaseContext.DeveloperCredentials
                .Where(dev => dev.ClientId == clientId)
                .Where(dev => dev.ClientSecret == clientSecret)
                .SingleOrDefault();
        }

        public DeveloperCredentials GetById(string credentialsId)
        {
            return DatabaseContext.DeveloperCredentials.SingleOrDefault(dev => dev.Id == credentialsId);
        }
    }
}