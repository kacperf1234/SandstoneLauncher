using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types
{
    public class DatabaseRecordUpdater : IDatabaseRecordUpdater
    {
        public void Update<TModel>(DbSet<TModel> dbSet, DbContext context, TModel model) where TModel : class
        {
            dbSet.Update(model);
            context.SaveChanges();
        }
    }
}