using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types
{
    public class ContentPropertyValidator : IContentPropertyValidator
    {
        public bool Validate(PropertyInfo info)
        {
            return info != null 
                   && info.PropertyType == typeof(string)
                   && info.GetSetMethod(false) != null;
        }
    }
}