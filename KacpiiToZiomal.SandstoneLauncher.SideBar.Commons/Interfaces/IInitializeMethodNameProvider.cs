using System;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces
{
    public interface IInitializeMethodNameProvider
    {
        string ProvideName(Type type);
    }
}