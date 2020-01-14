using System.Reflection;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces
{
    public interface IAssemblyLoader
    {
        Assembly Load(AssemblyName name);
    }
}