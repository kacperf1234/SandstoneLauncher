using System;
using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types
{
    public class GenericArgumentsGetter : IGenericArgumentsGetter
    {
        public Type GetGenericArgument(Type type, Func<Type[], Type> func) => func(type.GetGenericArguments());

        public Type GetGenericArgument(PropertyInfo property, Func<Type[], Type> func) => func(property.PropertyType.GetGenericArguments());
    }
}