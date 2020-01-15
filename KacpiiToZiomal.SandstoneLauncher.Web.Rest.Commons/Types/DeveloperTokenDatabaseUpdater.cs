using System;
using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Types
{
    public class DeveloperTokenDatabaseUpdater : IDatabaseUpdater<DeveloperToken>
    {
        public IDeveloperTokensGetter TokensGetter;
        public DatabaseContext DatabaseContext;

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