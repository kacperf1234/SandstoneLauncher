using System;
using System.Linq;
using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class PropertiesFinder : IPropertiesFinder
    {
        public PropertyInfo[] FindProperties(Type type, Func<PropertyInfo[], PropertyInfo[]> filter) => filter(type.GetProperties());

        public PropertyInfo FindProperty(Type type, Func<PropertyInfo[], PropertyInfo> filter) => filter(type.GetProperties());
    }
}