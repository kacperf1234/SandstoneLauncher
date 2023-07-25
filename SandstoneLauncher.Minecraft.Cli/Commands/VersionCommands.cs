using System;
using System.Threading.Tasks;
using ConsoleAppFramework;
using SandstoneLauncher.Minecraft.Cli.Response;
using SandstoneLauncher.Minecraft.Cli.Services.Version;

namespace SandstoneLauncher.Minecraft.Cli.Commands
{
    [Command("version")]
    public class VersionCommands : ConsoleAppBase
    {
        private VersionService VersionService = StaticContainer.Container.Resolve<VersionService>();
        
        [Command("list-dir")]
        public void ListVersionDirs()
        {
            var directories = VersionService.GetVersionDirectories();
            OperationResponse.PrintNew("version list-dir", directories);
        }
        
        [Command("list")]
        public void ListVersionNames()
        {
            var names = VersionService.GetVersionNames();
            OperationResponse.PrintNew("version list", names);
        }

        [Command("delete")]
        public async Task DeleteVersionByName([Option(0, "Version name")] string versionName)
        {
            OperationResponse.PrintNew("version delete", await VersionService.DeleteVersion(versionName));
        }
    }
}