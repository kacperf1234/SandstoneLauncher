using System;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types
{
    public class DbSetTypeProvider : IDbSetTypeProvider
    {
        public Type ProvideType() => typeof(DbSet<>);
    }
}