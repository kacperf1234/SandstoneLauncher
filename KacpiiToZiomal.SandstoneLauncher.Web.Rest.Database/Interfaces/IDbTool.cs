using System;
using System.Collections;
using System.Collections.Generic;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces
{
    public interface IDbTool
    {
        void Add<TModel>(DbContext dbContext, TModel model)
            where TModel : class;

        void Remove<TModel>(DbContext dbContext, Func<IEnumerable<TModel>, TModel> func)
            where TModel : class;

        void Update<TModel>(DbContext dbContext, TModel model)
            where TModel : class;

        void Update<TModel>(DbContext dbContext, Func<IEnumerable<TModel>, TModel> func, Action<TModel> action)
            where TModel : class;

        void Update<TModel>(DbContext dbContext, string id, Action<TModel> action)
            where TModel : class, IIdentificable;
        
        void Update<TModel>(DbContext dbContext, TModel model, Action<TModel> action) 
            where TModel : class;

        TModel Resolve<TModel>(DbContext dbContext, Func<IEnumerable<TModel>, TModel> func)
            where TModel : class;

        IEnumerable<TModel> ResolveMany<TModel>(DbContext dbContext, Func<IEnumerable<TModel>, IEnumerable<TModel>> func)
            where TModel : class;
    }
}