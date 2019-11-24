using System;
using System.Reflection;
using System.Windows.Controls;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types
{
    public class UserControlInitializer : IUserControlInitializer
    {
        public void Initialize(UserControl uc)
        {
            Type type = typeof(UserControl);
            MethodInfo methodInfo = type.GetMethod("InitializeComponent");
            methodInfo?.Invoke(uc, new object[0]);
        }
    }
}