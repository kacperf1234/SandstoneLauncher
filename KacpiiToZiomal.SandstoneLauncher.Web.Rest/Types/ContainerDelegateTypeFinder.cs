using System;
using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Types
{
    public class ContainerDelegateTypeFinder : IContainerDelegateTypeFinder
    {
        public IContainerDelegateTypeValidator DelegateTypeValidator;

        public ContainerDelegateTypeFinder(IContainerDelegateTypeValidator delegateTypeValidator)
        {
            DelegateTypeValidator = delegateTypeValidator;
        }

        public Type Find(Assembly assembly)
        {
            foreach (Type type in assembly.GetTypes())
                if (DelegateTypeValidator.Validate(type))
                    return type;

            return null;
        }
    }
}