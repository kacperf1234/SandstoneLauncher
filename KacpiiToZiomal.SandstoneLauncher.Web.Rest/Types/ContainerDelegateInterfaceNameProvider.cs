using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Types
{
    public class ContainerDelegateInterfaceNameProvider : IContainerDelegateInterfaceNameProvider
    {
        public string ProvideName() => typeof(IContainerDelegate).Name;
    }
}