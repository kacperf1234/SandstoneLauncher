using System;
using System.Linq;
using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Types
{
    public class PropertyInfoIsDbSetValidator : IPropertyInfoIsDbSetValidator
    {
        public ITypeComparer TypeComparer;
        public ITypeGetter TypeGetter;
        public IDbSetTypeProvider DbSetTypeProvider;
        public IGenericArgumentsGetter GenericArgumentsGetter;
        public IPropertyInfoIsGenericValidator PropertyIsGenericValidator; //todo if system will be works, remove it
        public IPropertyInfoContainsGenericArgumentsValidator ContainsGenericArgumentsValidator;

        public PropertyInfoIsDbSetValidator(ITypeComparer typeComparer, ITypeGetter typeGetter, IDbSetTypeProvider dbSetTypeProvider, IGenericArgumentsGetter genericArgumentsGetter, IPropertyInfoIsGenericValidator propertyIsGenericValidator, IPropertyInfoContainsGenericArgumentsValidator containsGenericArgumentsValidator)
        {
            TypeComparer = typeComparer;
            TypeGetter = typeGetter;
            DbSetTypeProvider = dbSetTypeProvider;
            GenericArgumentsGetter = genericArgumentsGetter;
            PropertyIsGenericValidator = propertyIsGenericValidator;
            ContainsGenericArgumentsValidator = containsGenericArgumentsValidator;
        }

        public bool Validate(PropertyInfo property, Type argumentType)
        {
            if (TypeComparer.Compare(DbSetTypeProvider.ProvideType(), property.PropertyType))
            {
                Type genericType = TypeGetter.GetGenericType(property.PropertyType);

                if (ContainsGenericArgumentsValidator.ContainsGenericArguments(genericType))
                {
                    Type genericArgument = GenericArgumentsGetter.GetGenericArgument(genericType, types => types.Single());

                    if (TypeComparer.Compare(genericArgument, argumentType))
                    {
                        return true;
                    }
                }

                return false;
            }

            return false;
        }
    }
}