using System.Reflection;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces
{
    public interface IPropertyInfoIsGenericValidator
    {
        bool IsGenericType(PropertyInfo prop);
    }
}