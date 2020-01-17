using System;
using System.Collections.Generic;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types
{
    public class DbTool : IDbTool
    {
        private ITypeGetter TypeGetter;
        private IDbSetFinder DbSetFinder;
        private IDatabaseRecordAdder RecordAdder;
        private IDatabaseRecordRemover RecordRemover;
        private IDatabaseRecordUpdater RecordUpdater;
        private IDatabaseRecordGetter RecordGetter;

        public DbTool(ITypeGetter typeGetter, IDbSetFinder dbSetFinder, IDatabaseRecordAdder recordAdder, IDatabaseRecordRemover recordRemover, IDatabaseRecordUpdater recordUpdater, IDatabaseRecordGetter recordGetter)
        {
            TypeGetter = typeGetter;
            DbSetFinder = dbSetFinder;
            RecordAdder = recordAdder;
            RecordRemover = recordRemover;
            RecordUpdater = recordUpdater;
            RecordGetter = recordGetter;
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

            RecordRemover.Remove(dbSet, dbContext, model);
        }

        public TModel Get<TModel>(DbContext dbContext, Func<IEnumerable<TModel>, TModel> func) where TModel : class
        {
            DbSet<TModel> dbSet = DbSetFinder.FindDbSet<TModel>(dbContext);
            return func(dbSet);
        }
    }
}