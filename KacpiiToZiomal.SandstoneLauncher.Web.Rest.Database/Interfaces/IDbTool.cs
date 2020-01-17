using System;
using System.Collections;
using System.Collections.Generic;
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

        TModel Get<TModel>(DbContext dbContext, Func<IEnumerable<TModel>, TModel> func)
            where TModel : class;
    }
}