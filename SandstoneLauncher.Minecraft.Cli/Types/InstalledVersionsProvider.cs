using System.Collections.Generic;
using System.IO;
using System.Linq;
using SandstoneLauncher.Minecraft.Types;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Cli.Types
{
    [SingleInstance]
    public class InstalledVersionsProvider
    {
        public IEnumerable<string> GetInstalledVersionsDirs()
        {
            return Directory.GetDirectories(new MinecraftDirectory().GetVersions());
        }
    }
}