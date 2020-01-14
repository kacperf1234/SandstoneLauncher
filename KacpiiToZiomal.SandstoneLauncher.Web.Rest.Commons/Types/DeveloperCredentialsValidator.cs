using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Types
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