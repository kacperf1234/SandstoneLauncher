using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using SandstoneLauncher.Minecraft.Cli.Types;
using SandstoneLauncher.Minecraft.Types;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Cli.Services.Version
{
    [SingleInstance]
    public class VersionService
    {
        private InstalledVersionsProvider InstalledVersionsProvider;
        private VersionPathProvider VersionPathProvider;
        
        public VersionService(InstalledVersionsProvider installedVersionsProvider, VersionPathProvider versionPathProvider)
        {
            InstalledVersionsProvider = installedVersionsProvider;
            VersionPathProvider = versionPathProvider;
        }
        
        public IEnumerable<string> GetVersionNames()
        {
            return InstalledVersionsProvider.GetInstalledVersionsDirs().Select(Path.GetFileName);
        }

        public IEnumerable<string> GetVersionDirectories()
        {
            return InstalledVersionsProvider.GetInstalledVersionsDirs();
        }

        public Task<bool> DeleteVersion(string versionName)
        {
            try
            {
                var versionPath = VersionPathProvider.ProvideVersionPath(versionName);
                Directory.Delete(versionPath, true);
                return Task.FromResult(true);
            }
            catch (IOException)
            {
                return Task.FromResult(false);
            }
        }
    }
}