using System;
using System.Reflection;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces
{
    public interface IPropertyInfoIsDbSetValidator
    {
        bool Validate(PropertyInfo property, Type argumentType);
    }
}