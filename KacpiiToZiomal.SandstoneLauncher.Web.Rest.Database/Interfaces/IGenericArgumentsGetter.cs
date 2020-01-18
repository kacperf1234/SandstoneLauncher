using System;
using System.Reflection;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces
{
    public interface IGenericArgumentsGetter
    {
        Type GetGenericArgument(Type type, Func<Type[], Type> func);

        Type GetGenericArgument(PropertyInfo property, Func<Type[], Type> func);
    }
}