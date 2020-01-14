using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class AssemblyLoader : IAssemblyLoader
    {
        public Assembly Load(AssemblyName name)
        {
            return Assembly.Load(name);
        }
    }
}