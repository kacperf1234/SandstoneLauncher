using System;
using Microsoft.EntityFrameworkCore;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces
{
    public interface IDbSetFinder
    {
        DbSet<TModel> FindDbSet<TModel>(object contextInstance) where TModel : class;
    }
}