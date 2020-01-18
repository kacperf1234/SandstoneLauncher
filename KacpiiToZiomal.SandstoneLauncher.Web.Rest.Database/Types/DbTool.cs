using System;
using System.Collections.Generic;
using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces;
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
        
        public void Update<TModel>(DbContext dbContext, TModel model, Action<TModel> action) where TModel : class
        {
            DbSet<TModel> dbSet = DbSetFinder.FindDbSet<TModel>(dbContext);

            action(model);
            
            RecordUpdater.Update(dbSet, dbContext, model);
        }

        public void Update<TModel>(DbContext dbContext, Func<IEnumerable<TModel>, TModel> func, Action<TModel> action) where TModel : class
        {
            DbSet<TModel> dbSet = DbSetFinder.FindDbSet<TModel>(dbContext);
            TModel modelToUpdate = func(dbSet);

            action(modelToUpdate);
            
            RecordUpdater.Update(dbSet, dbContext, modelToUpdate);
        }

        public void Update<TModel>(DbContext dbContext, string id, Action<TModel> action) where TModel : class, IIdentificable
        {
            DbSet<TModel> dbSet = DbSetFinder.FindDbSet<TModel>(dbContext);
            TModel modelToUpdate = dbSet.Single(x => x.Id == id);

            action(modelToUpdate);
            
            RecordUpdater.Update(dbSet, dbContext, modelToUpdate);
        }

        public TModel Resolve<TModel>(DbContext dbContext, Func<IEnumerable<TModel>, TModel> func) where TModel : class
        {
            DbSet<TModel> dbSet = DbSetFinder.FindDbSet<TModel>(dbContext);
            
            return func(dbSet);
        }

        public IEnumerable<TModel> ResolveMany<TModel>(DbContext dbContext, Func<IEnumerable<TModel>, IEnumerable<TModel>> func) where TModel : class
        {
            DbSet<TModel> dbSet = DbSetFinder.FindDbSet<TModel>(dbContext);
            return func(dbSet);
        }
    }
}