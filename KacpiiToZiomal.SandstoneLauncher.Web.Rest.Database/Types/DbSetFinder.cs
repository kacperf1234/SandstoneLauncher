using System;
using System.Linq;
using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types
{
    public class DbSetFinder : IDbSetFinder
    {
        public ITypeGetter TypeGetter;
        public IPropertyTypeComparer PropertyTypeComparer;
        public IPropertiesFinder PropertiesFinder;

        public DbSetFinder(ITypeGetter typeGetter, IPropertyTypeComparer propertyTypeComparer, IPropertiesFinder propertiesFinder)
        {
            TypeGetter = typeGetter;
            PropertyTypeComparer = propertyTypeComparer;
            PropertiesFinder = propertiesFinder;
        }

        public DbSet<TModel> FindDbSet<TModel>(object contextInstance) where TModel : class
        {
            Type contextType = TypeGetter.GetType(contextInstance);
            Type modelType = TypeGetter.GetType<TModel>();

            PropertyInfo[] properties = PropertiesFinder.FindProperties(contextType, a => a);

            foreach (PropertyInfo contextProperty in properties)
            {
                if (PropertyTypeComparer.Compare(contextProperty, typeof(DbSet<>)))
                {
                    Type firstParameter = contextProperty.PropertyType
                        .GetGenericArguments()
                        .FirstOrDefault();

                    if (firstParameter == modelType)
                    {
                        return (DbSet<TModel>) contextProperty.GetValue(contextInstance);
                    }
                }
            }

            return null;
        }
    }
}