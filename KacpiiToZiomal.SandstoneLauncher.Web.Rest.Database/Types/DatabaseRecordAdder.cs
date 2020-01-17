using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types
{
    public class DatabaseRecordAdder : IDatabaseRecordAdder
    {
        public void Add<TModel>(DbSet<TModel> dbSet, DbContext context, TModel model) where TModel : class
        {
            dbSet.Add(model);
            context.SaveChanges();
        }
    }
}