using Microsoft.EntityFrameworkCore;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces
{
    public interface IDatabaseRecordRemover
    {
        void Remove<TModel>(DbSet<TModel> dbSet, DbContext context, TModel model) where TModel : class;
    }
}