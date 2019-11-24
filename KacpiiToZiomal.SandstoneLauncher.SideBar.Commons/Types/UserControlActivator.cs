using System;
using System.Windows.Controls;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types
{
    public class UserControlActivator : IUserControlActivator
    {
        public T Activate<T>() where T : UserControl
        {
            return Activator.CreateInstance<T>();
        }
    }
}