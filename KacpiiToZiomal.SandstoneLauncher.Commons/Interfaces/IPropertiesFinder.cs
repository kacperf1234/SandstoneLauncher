using System;
using System.Reflection;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces
{
    public interface IPropertiesFinder
    {
        PropertyInfo[] FindProperties(Type type, Func<PropertyInfo[], PropertyInfo[]> filter);

        PropertyInfo FindProperty(Type type, Func<PropertyInfo[], PropertyInfo> filter);
    }
}