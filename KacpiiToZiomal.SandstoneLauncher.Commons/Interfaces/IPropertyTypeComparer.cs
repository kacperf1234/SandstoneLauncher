using System;
using System.Reflection;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces
{
    public interface IPropertyTypeComparer
    {
        bool Compare(PropertyInfo property, Type exceptedType);
    }
}