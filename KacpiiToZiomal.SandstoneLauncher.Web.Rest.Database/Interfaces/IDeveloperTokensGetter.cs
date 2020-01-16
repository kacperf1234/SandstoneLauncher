using System;
using System.Collections.Generic;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces
{
    public interface IDeveloperTokensGetter
    {
        DeveloperToken GetDeveloperToken(Func<IEnumerable<DeveloperToken>, DeveloperToken> func);

        IEnumerable<DeveloperToken> GetDeveloperTokens(Func<IEnumerable<DeveloperToken>, IEnumerable<DeveloperToken>> func);
    }
}