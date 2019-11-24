using System;
using System.Reflection;
using System.Windows.Controls;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types
{
    public class UserControlInitializer : IUserControlInitializer
    {
        public IInitializeMethodFinder MethodFinder;

        public UserControlInitializer(IInitializeMethodFinder methodFinder)
        {
            MethodFinder = methodFinder;
        }

        public void Initialize(object uc)
        {
            MethodInfo method = MethodFinder.FindInitializeMethod(uc);
            method.Invoke(uc, new object[0]);
        }
    }
}