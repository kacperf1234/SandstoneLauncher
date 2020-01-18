using System;
using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Types
{
    public class PropertyInfoContainsGenericArgumentsValidator : IPropertyInfoContainsGenericArgumentsValidator
    {
        public bool ContainsGenericArguments(Type type) 
            => type.IsGenericType && type.GetGenericArguments().Length > 0;
    }
}