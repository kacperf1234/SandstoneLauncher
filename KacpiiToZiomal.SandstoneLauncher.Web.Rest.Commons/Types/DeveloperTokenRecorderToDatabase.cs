using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Types
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