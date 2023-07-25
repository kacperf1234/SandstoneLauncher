using System.Linq;
using System.Threading.Tasks;
using SandstoneLauncher.Minecraft.Models;
using SandstoneLauncher.Minecraft.Types;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Cli.Services.Play
{
    [SingleInstance]
    public class PlayService
    {
        [Inject]
        public LaunchArgumentsBuilder LaunchArgumentsBuilder;

        [Inject]
        public FullVersionFinder FullVersionFinder;

        [Inject]
        public ManifestGetter ManifestGetter;

        [Inject]
        public LaunchCommandBuilder CommandBuilder;

        [Inject]
        public JavaLauncher JavaLauncher;
        
        public Task Launch(string version, string username, int width, int height, int xmx, int xms)
        {
            return Task.Run(() =>
            {
                var versionUrl = ManifestGetter.GetManifest().Versions.FirstOrDefault(x => x.Id == version).Url;
                var fullVersion = FullVersionFinder.Find(versionUrl);
                Dimensions windowDimensions = new Dimensions()
                {
                    Height = 854,
                    Width = 480
                };
                var launchArguments = LaunchArgumentsBuilder.Create(windowDimensions, fullVersion, "Kacperek");
                var command = CommandBuilder.GetCommand(launchArguments);
                JavaLauncher.Launch(command);
                
                // TODO: Redirect the output to launcher...
            });
        }
    }
}