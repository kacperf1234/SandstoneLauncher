using System;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces
{
    public interface IGenericArgumentsGetter
    {
        Type GetGenericArgument(Type type, Func<Type[], Type> func);
    }
}