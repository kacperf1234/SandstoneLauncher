using System;
using System.Threading.Tasks;
using ConsoleAppFramework;
using SandstoneLauncher.Minecraft.Cli.Commands;
using SandstoneLauncher.Minecraft.Cli.Types;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Cli
{
    class Program
    {
        static void AddCommands(ConsoleApp app)
        {
            app.AddSubCommands<VersionCommands>();
            app.AddSubCommands<DownloadCommands>();
            app.AddSubCommands<PlayCommands>();
            app.AddSubCommands<LauncherProfilesCommands>();
        }
        
        static async Task Main(string[] args)
        {
            StaticContainer.Container = ContainerFactory.Container();
            // register current assembly .Cli
            StaticContainer.Container.RegisterAssembly<VersionCommands>();
            // register SandstoneLauncher.Minecraft assembly.
            StaticContainer.Container.RegisterAssembly<Minecraft>();
            
            var app = ConsoleApp.Create(args);
            AddCommands(app);
            
            await app.RunAsync();
        }
    }
}