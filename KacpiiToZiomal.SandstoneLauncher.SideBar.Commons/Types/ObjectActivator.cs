using System;
using System.Windows.Controls;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types
{
    public class ObjectActivator<TActivateBase> : IObjectActivator<TActivateBase>
    {
        public T Activate<T>() where T : TActivateBase
        {
            return Activator.CreateInstance<T>();
        }
    }
}