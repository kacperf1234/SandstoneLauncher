using System;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Types
{
    public class GenericArgumentsGetter : IGenericArgumentsGetter
    {
        public Type GetGenericArgument(Type type, Func<Type[], Type> func) => func(type.GetGenericArguments());
    }
}