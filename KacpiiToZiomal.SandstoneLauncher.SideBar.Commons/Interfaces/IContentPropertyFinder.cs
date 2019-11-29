using System;
using System.Reflection;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces
{
    public interface IContentPropertyFinder
    {
        PropertyInfo FindAndThrowIfDontValid(Type type);
    }
}