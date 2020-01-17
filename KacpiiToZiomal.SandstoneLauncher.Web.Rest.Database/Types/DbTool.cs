using System;
using System.Collections.Generic;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types
{
    public class DbTool : IDbTool
    {
        private IDbSetFinder DbSetFinder;
        private IDatabaseRecordAdder RecordAdder;
        private IDatabaseRecordRemover RecordRemover;
        private IDatabaseRecordUpdater RecordUpdater;

        public DbTool(IDbSetFinder dbSetFinder, IDatabaseRecordAdder recordAdder, IDatabaseRecordRemover recordRemover, IDatabaseRecordUpdater recordUpdater)
        {
            DbSetFinder = dbSetFinder;
            RecordAdder = recordAdder;
            RecordRemover = recordRemover;
            RecordUpdater = recordUpdater;
        }

        public void Add<TModel>(DbContext dbContext, TModel model) where TModel : class
        {
            DbSet<TModel> dbSet = DbSetFinder.FindDbSet<TModel>(dbContext);
            
            RecordAdder.Add(dbSet, dbContext, model);
        }

        public void Remove<TModel>(DbContext dbContext, Func<IEnumerable<TModel>, TModel> func) where TModel : class
        {
            DbSet<TModel> dbSet = DbSetFinder.FindDbSet<TModel>(dbContext);
            TModel model = func(dbSet);

            RecordRemover.Remove(dbSet, dbContext, model);
        }

        public void Update<TModel>(DbContext dbContext, TModel model) where TModel : class
        {
            DbSet<TModel> dbSet = DbSetFinder.FindDbSet<TModel>(dbContext);

            RecordUpdater.Update(dbSet, dbContext, model);
        }

        public TModel Get<TModel>(DbContext dbContext, Func<IEnumerable<TModel>, TModel> func) where TModel : class
        {
            DbSet<TModel> dbSet = DbSetFinder.FindDbSet<TModel>(dbContext);
            return func(dbSet);
        }

        public IEnumerable<TModel> Get<TModel>(DbContext dbContext, Func<IEnumerable<TModel>, IEnumerable<TModel>> func) where TModel : class
        {
            DbSet<TModel> dbSet = DbSetFinder.FindDbSet<TModel>(dbContext);
            return func(dbSet);
        }
    }
}