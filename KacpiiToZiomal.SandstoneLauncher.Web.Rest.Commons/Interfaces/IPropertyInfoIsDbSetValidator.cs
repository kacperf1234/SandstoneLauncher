using System;
using System.Reflection;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces
{
    public interface IPropertyInfoIsDbSetValidator
    {
        bool Validate(PropertyInfo property, Type argumentType);
    }
}