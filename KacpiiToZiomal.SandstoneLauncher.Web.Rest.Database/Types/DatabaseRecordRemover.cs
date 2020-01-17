using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types
{
    public class DatabaseRecordRemover : IDatabaseRecordRemover
    {
        public void Remove<TModel>(DbSet<TModel> dbSet, DbContext context, TModel model) where TModel : class
        {
            dbSet.Remove(model);
            context.SaveChanges();
        }
    }
}