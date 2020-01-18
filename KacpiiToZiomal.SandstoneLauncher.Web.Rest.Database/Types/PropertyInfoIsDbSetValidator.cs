using System;
using System.Linq;
using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types
{
    public class PropertyInfoIsDbSetValidator : IPropertyInfoIsDbSetValidator
    {
        public ITypeComparer TypeComparer;
        public ITypeGetter TypeGetter;
        public IDbSetTypeProvider DbSetTypeProvider;
        public IGenericArgumentsGetter GenericArgumentsGetter;
        public IPropertyInfoContainsGenericArgumentsValidator ContainsGenericArgumentsValidator;

        public PropertyInfoIsDbSetValidator(ITypeComparer typeComparer, ITypeGetter typeGetter, IDbSetTypeProvider dbSetTypeProvider, IGenericArgumentsGetter genericArgumentsGetter, IPropertyInfoContainsGenericArgumentsValidator containsGenericArgumentsValidator)
        {
            TypeComparer = typeComparer;
            TypeGetter = typeGetter;
            DbSetTypeProvider = dbSetTypeProvider;
            GenericArgumentsGetter = genericArgumentsGetter;
            ContainsGenericArgumentsValidator = containsGenericArgumentsValidator;
        }

        public bool Validate(PropertyInfo property, Type argumentType)
        {
            Type dbSetType = DbSetTypeProvider.ProvideType();
            Type propertyType = property.PropertyType;

            if (propertyType.IsGenericType) {
                Type genericType = TypeGetter.GetGenericType(propertyType);
            
                if (TypeComparer.Compare(dbSetType, genericType))
                {
                    if (ContainsGenericArgumentsValidator.ContainsGenericArguments(propertyType))
                    {
                        Type genericArgument = GenericArgumentsGetter.GetGenericArgument(property, types => types.First());

                        if (TypeComparer.Compare(genericArgument, argumentType))
                        {
                            return true;
                        }
                    }

                    return false;
                }
            }

            return false;
        }
    }
}