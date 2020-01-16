using System;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types
{
    public class DeveloperTokenActiveValidator : IDeveloperTokenActiveValidator
    {
        public bool Validate(DeveloperToken token)
        {
            bool x = token.ExpiredAt != null && !token.Archived && DateTime.Compare((DateTime) token.ExpiredAt, DateTime.Now) > 0;
            bool y = !token.Unauthorized;

            return x && y;
        }
    }
}