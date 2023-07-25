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
            app.AddCommands<VersionCommands>();
        }
        
        static async Task Main(string[] args)
        {
            StaticContainer.Container = ContainerFactory.Container();
            StaticContainer.Container.RegisterAssembly<VersionCommands>();
            
            var app = ConsoleApp.Create(args);
            AddCommands(app);

            await app.RunAsync();
        }
    }
}