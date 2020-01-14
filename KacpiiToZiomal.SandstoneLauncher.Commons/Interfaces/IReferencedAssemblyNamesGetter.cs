using System.Reflection;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces
{
    public interface IReferencedAssemblyNamesGetter
    {
        AssemblyName[] GetReferencedAssemblyNames(Assembly assembly);
    }
}