using System.Reflection;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces
{
    public interface IContentPropertyValidator
    {
        bool Validate(PropertyInfo info);
    }
}