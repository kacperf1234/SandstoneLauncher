using Microsoft.EntityFrameworkCore;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces
{
    public interface IDatabaseRecordGetter
    {
        TModel Get<TModel>(DbSet<TModel> dbSet) where TModel : class;
    }
}