using System;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types
{
    public class InitializeMethodNameProvider : IInitializeMethodNameProvider
    {
        public string ProvideName(Type type) => "InitializeComponent";
    }
}