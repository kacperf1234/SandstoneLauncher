using System.Reflection;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces
{
    public interface IPropertyValueRemover
    {
        void Remove(PropertyInfo info, object instance, object val = null);
    }
}