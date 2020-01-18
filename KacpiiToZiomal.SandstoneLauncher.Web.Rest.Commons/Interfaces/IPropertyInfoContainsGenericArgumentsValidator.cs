using System;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces
{
    public interface IPropertyInfoContainsGenericArgumentsValidator
    {
        bool ContainsGenericArguments(Type type);
    }
}