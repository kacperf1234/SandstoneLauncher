using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class PropertyInfoIsGenericValidator : IPropertyInfoIsGenericValidator
    {
        public bool IsGenericType(PropertyInfo prop) => prop.PropertyType.IsGenericType;
    }
}