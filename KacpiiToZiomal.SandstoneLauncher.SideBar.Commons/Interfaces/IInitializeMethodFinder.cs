using System.Reflection;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces
{
    public interface IInitializeMethodFinder
    {
        MethodInfo FindInitializeMethod(object @object);
    }
}