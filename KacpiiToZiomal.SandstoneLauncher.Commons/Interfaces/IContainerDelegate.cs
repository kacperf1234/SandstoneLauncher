using Autofac;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces
{
    public interface IContainerDelegate
    {
        void ConfigureContainer(ContainerBuilder builder);

        void RegisterGenerics(ContainerBuilder builder);
    }
}