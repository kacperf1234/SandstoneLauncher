using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types
{
    public class DeveloperCredentialsValidator : IDeveloperCredentialsValidator
    {
        public DatabaseContext DatabaseContext;

        public DeveloperCredentialsValidator(DatabaseContext database_context)
        {
            DatabaseContext = database_context;
        }

        public bool Validate(DeveloperCredentials credentials)
        {
            return credentials != null;
        }
    }
}