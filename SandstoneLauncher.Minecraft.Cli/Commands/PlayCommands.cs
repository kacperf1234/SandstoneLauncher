#nullable enable
using System;
using ConsoleAppFramework;
using SandstoneLauncher.Minecraft.Cli.Services.Play;

namespace SandstoneLauncher.Minecraft.Cli.Commands
{
    [Command("play")]
    public class PlayCommands : ConsoleAppBase
    {
        private PlayService PlayService = StaticContainer.Container.Resolve<PlayService>();
        
        [Command("launch")]
        public void Launch(
            [Option("v", "Game Version ID")] string version,
            [Option("username")] string username,
            [Option("width")] int width,
            [Option("height")] int height,
            [Option("xmx")] int xmx,
            [Option("xms")] int xms
        )
        {
            PlayService.Launch(version, username, width, height, xmx, xms);
        }

        [Command("launch-with-args")]
        public void LaunchWithArgs(
            [Option("v", "Game Version ID")] string version,
            [Option("username")] string username,
            [Option("width")] int width,
            [Option("height")] int height,
            [Option("xmx")] int xmx,
            [Option("xms")] int xms,
            [Option("launcherBrand")] string launcherBrand,
            [Option("gameDir")] string? gameDir = null,
            [Option("javaDir")] string? javaDir = null,
            [Option("javaArgs")] string? javaArgs = null
            )
        {
            PlayService.Launch(version, username, width, height, xmx, xms, gameDir, javaDir, javaArgs, launcherBrand);
        }
    }
}