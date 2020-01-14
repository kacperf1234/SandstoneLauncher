using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Types
{
    public class DeveloperCredentialsFinder : IDeveloperCredentialsFinder
    {
        public DatabaseContext DatabaseContext;

        public DeveloperCredentialsFinder(DatabaseContext database_context)
        {
            DatabaseContext = database_context;
        }

        public DeveloperCredentials GetByCredentials(string clientId, string clientSecret) =>
            DatabaseContext.DeveloperCredentials
                .Where(dev => dev.ClientId == clientId)
                .Where(dev => dev.ClientSecret == clientSecret)
                .SingleOrDefault();

        public DeveloperCredentials GetById(string credentialsId) =>
            DatabaseContext.DeveloperCredentials.SingleOrDefault(dev => dev.Id == credentialsId);
    }
}