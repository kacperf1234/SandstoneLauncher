using System;
using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class PropertyTypeComparer : IPropertyTypeComparer
    {
        public bool Compare(PropertyInfo property, Type exceptedType) => property.PropertyType == exceptedType;
    }
}