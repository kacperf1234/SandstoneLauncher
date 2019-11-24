using System;
using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types
{
    public class InitializeMethodFinder : IInitializeMethodFinder
    {
        public IInitializeMethodNameProvider NameProvider;

        public InitializeMethodFinder(IInitializeMethodNameProvider nameProvider)
        {
            NameProvider = nameProvider;
        }

        public MethodInfo FindInitializeMethod(object @object)
        {
            Type type = @object.GetType();
            string name = NameProvider.ProvideName(type);
            return type.GetMethod(name);
        }
    }
}