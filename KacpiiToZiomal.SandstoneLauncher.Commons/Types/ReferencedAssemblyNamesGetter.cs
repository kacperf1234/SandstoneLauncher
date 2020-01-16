using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class ReferencedAssemblyNamesGetter : IReferencedAssemblyNamesGetter
    {
        public AssemblyName[] GetReferencedAssemblyNames(Assembly assembly)
        {
            return assembly.GetReferencedAssemblies();
        }
    }
}