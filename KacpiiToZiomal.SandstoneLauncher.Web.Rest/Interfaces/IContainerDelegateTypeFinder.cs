using System;
using System.Reflection;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Interfaces
{
    public interface IContainerDelegateTypeFinder
    {
        Type Find(Assembly assembly);
    }
}