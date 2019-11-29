using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types
{
    public class PropertyValueRemover : IPropertyValueRemover
    {
        public void Remove(PropertyInfo info, object instance, object val = null)
        {
            info.SetValue(instance, val);
        }
    }
}