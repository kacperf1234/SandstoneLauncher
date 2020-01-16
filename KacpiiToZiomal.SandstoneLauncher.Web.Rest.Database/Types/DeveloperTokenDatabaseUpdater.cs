using System;
using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types
{
    public class DeveloperTokenDatabaseUpdater : IDatabaseUpdater<DeveloperToken>
    {
        public DatabaseContext DatabaseContext;
        public IDeveloperTokensGetter TokensGetter;

        public DeveloperTokenDatabaseUpdater(IDeveloperTokensGetter tokensGetter, DatabaseContext databaseContext)
        {
            TokensGetter = tokensGetter;
            DatabaseContext = databaseContext;
        }

        public void Update(string id, Action<DeveloperToken> act)
        {
            DeveloperToken token = TokensGetter.GetDeveloperToken(f => f.SingleOrDefault(t => t.Id == id));

            act.Invoke(token);

            DatabaseContext.DeveloperTokens.Update(token);
            DatabaseContext.SaveChanges();
        }

        public void Update(string id, Action<DeveloperToken> act, out DeveloperToken t)
        {
            DeveloperToken token = TokensGetter.GetDeveloperToken(f => f.SingleOrDefault(tk => tk.Id == id));

            act.Invoke(token);

            DatabaseContext.DeveloperTokens.Update(token);
            DatabaseContext.SaveChanges();

            t = token;
        }
    }
}