using System;
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
            try
            {
                return type.IsClass
                       && type.GetInterface(NameProvider.ProvideName(), true) != null;
            }

            catch (NullReferenceException exception)
            {
                return false;
            }

            catch
            {
                throw;
            }
        }
    }
}