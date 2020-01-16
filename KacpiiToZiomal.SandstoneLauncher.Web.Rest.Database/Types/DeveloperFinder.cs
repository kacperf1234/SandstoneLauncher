using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types
{
    public class DeveloperFinder : IDeveloperFinder
    {
        public DatabaseContext DatabaseContext;
        public IDeveloperCredentialsValidator CredentialsValidator;

        public DeveloperFinder(DatabaseContext databaseContext, IDeveloperCredentialsValidator credentialsValidator)
        {
            DatabaseContext = databaseContext;
            CredentialsValidator = credentialsValidator;
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

        public Developer GetDeveloper(string clientId, string clientSecret)
        {
            DeveloperCredentials devCredentials =
                DatabaseContext.DeveloperCredentials.SingleOrDefault(
                    c => c.ClientId == clientId && c.ClientSecret == clientSecret);

            return CredentialsValidator.Validate(devCredentials) ? DatabaseContext.Developers.SingleOrDefault(dev => dev.CredentialsId == devCredentials.Id) : null;
        }
    }
}