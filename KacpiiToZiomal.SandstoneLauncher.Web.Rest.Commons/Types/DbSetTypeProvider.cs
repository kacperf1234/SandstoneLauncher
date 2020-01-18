using System;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Types
{
    public class DbSetTypeProvider : IDbSetTypeProvider
    {
        public Type ProvideType() => typeof(DbSet<>);
    }
}