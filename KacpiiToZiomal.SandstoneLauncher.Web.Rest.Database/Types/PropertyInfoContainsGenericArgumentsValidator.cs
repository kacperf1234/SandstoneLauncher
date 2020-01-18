using System;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Types
{
    public class PropertyInfoContainsGenericArgumentsValidator : IPropertyInfoContainsGenericArgumentsValidator
    {
        public bool ContainsGenericArguments(Type type) 
            => type.GetGenericArguments().Length > 0;
    }
}