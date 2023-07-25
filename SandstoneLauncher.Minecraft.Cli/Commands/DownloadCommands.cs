using System;
using System.Threading.Tasks;
using ConsoleAppFramework;
using SandstoneLauncher.Minecraft.Cli.Response;
using SandstoneLauncher.Minecraft.Cli.Services.Download;
using SandstoneLauncher.Minecraft.Enums;

namespace SandstoneLauncher.Minecraft.Cli.Commands
{
    [Command("download")]
    public class DownloadCommands : ConsoleAppBase
    {
        private DownloadService DownloadService = StaticContainer.Container.Resolve<DownloadService>();
        
        [Command("assets")]
        public async Task DownloadAssets([Option("v", "Game Version ID")] string version)
        {
            await DownloadService.DownloadAssets(version);
            OperationResponse.PrintNew("download assets", true);
        }

        private OS? GetOsFromString(string osStr)
        {
            return osStr.ToLower() switch
            {
                "windows" => OS.WINDOWS,
                "linux" => OS.LINUX,
                _ => null
            };
        }

        [Command("game")]
        public async Task DownloadEverything([Option("v", "Game Version ID")] string version, [Option("os", "Operating system WINDOWS/LINUX")] string operatingSystem)
        {
            OS os = GetOsFromString(operatingSystem) ?? throw new Exception("Invalid 'os' parameter");
            var result = await DownloadService.DownloadGame(version, os);
            OperationResponse.PrintNew("download game", result);
        }
    }
}