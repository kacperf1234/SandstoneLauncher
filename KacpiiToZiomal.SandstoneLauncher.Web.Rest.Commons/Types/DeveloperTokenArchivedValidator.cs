using System;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Types
{
    public class DeveloperTokenArchivedValidator : IDeveloperTokenArchivedValidator
    {
        public bool Validate(DeveloperToken token)
        {
            return token.ExpiredAt != null && (!(token.Archived) && DateTime.Compare((DateTime) token.ExpiredAt, DateTime.Now) > 0);
        }
    }
}