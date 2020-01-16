using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types
{
    public class DeveloperTokenRecorderToDatabase : IDeveloperTokenRecorderToDatabase
    {
        public DatabaseContext DatabaseContext;

        public DeveloperTokenRecorderToDatabase(DatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }

        public void Add(DeveloperToken developerToken)
        {
            DatabaseContext.DeveloperTokens.Add(developerToken);
            DatabaseContext.SaveChanges();
        }
    }
}