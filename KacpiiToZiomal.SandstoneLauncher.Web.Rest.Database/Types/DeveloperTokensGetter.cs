using System;
using System.Collections.Generic;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types
{
    public class DeveloperTokensGetter : IDeveloperTokensGetter
    {
        public DatabaseContext DatabaseContext;

        public DeveloperTokensGetter(DatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }

        public DeveloperToken GetDeveloperToken(Func<IEnumerable<DeveloperToken>, DeveloperToken> func)
        {
            IEnumerable<DeveloperToken> tokens = DatabaseContext.DeveloperTokens;
            return func(tokens);
        }

        public IEnumerable<DeveloperToken> GetDeveloperTokens(Func<IEnumerable<DeveloperToken>, IEnumerable<DeveloperToken>> func)
        {
            IEnumerable<DeveloperToken> tokens = DatabaseContext.DeveloperTokens;
            return func(tokens);
        }
    }
}