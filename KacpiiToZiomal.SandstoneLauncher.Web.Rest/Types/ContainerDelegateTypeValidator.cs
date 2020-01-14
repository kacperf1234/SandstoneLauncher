using System;
using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Types
{
    public class ContainerDelegateTypeValidator : IContainerDelegateTypeValidator
    {
        public IContainerDelegateInterfaceNameProvider NameProvider;

        public ContainerDelegateTypeValidator(IContainerDelegateInterfaceNameProvider nameProvider)
        {
            NameProvider = nameProvider;
        }

        public bool Validate(Type type)
        {
            return type.IsClass
                   && type.GetInterface(NameProvider.ProvideName(), true) != null;
        }
    }
}