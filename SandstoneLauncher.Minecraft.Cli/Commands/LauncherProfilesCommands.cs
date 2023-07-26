using ConsoleAppFramework;
using SandstoneLauncher.Minecraft.Cli.Response;
using SandstoneLauncher.Minecraft.Models;
using SandstoneLauncher.Minecraft.Services.Profiles;

namespace SandstoneLauncher.Minecraft.Cli.Commands
{
    [Command("launcher_profiles")]
    public class LauncherProfilesCommands : ConsoleAppBase
    {
        private LauncherProfilesService ProfilesService = StaticContainer.Container.Resolve<LauncherProfilesService>();

        [Command("create")]
        public void Create(
            [Option("name", "Profile Name")] string name,
            [Option("gameDir", "Game Directory .minecraft")] string gameDir,
            [Option("javaDir", "Java Directory")] string javaDir,
            [Option("javaArgs", "Java Arguments")] string javaArgs,
            [Option("width", "Resolution Width")] int width,
            [Option("height", "Resolution Height")] int height,
            [Option("lastVersionId")] string lastVersionId
        )
        {
            var profile = new LauncherProfile
            {
                Name = name,
                Resolution = new Resolution(width, height),
                GameDir = gameDir,
                JavaDir = javaDir,
                JavaArgs = javaArgs,
                LastVersionId = lastVersionId,
                LauncherVisibilityOnGameClose = "N/A"
            };


            ProfilesService.PutProfile(profile);

            OperationResponse.PrintNew("launcher_profiles create", true);
        }

        [Command("delete")]
        public void Delete([Option("name")] string name)
        {
            OperationResponse.PrintNew("launcher_profiles delete", ProfilesService.DeleteProfile(name));
        }
        
        [Command("update")]
        public void Update(
            [Option("name", "Profile Name")] string name,
            [Option("gameDir", "Game Directory .minecraft")] string gameDir,
            [Option("javaDir", "Java Directory")] string javaDir,
            [Option("javaArgs", "Java Arguments")] string javaArgs,
            [Option("width", "Resolution Width")] int width,
            [Option("height", "Resolution Height")] int height,
            [Option("lastVersionId")] string lastVersionId
        )
        {
            var profile = new LauncherProfile
            {
                Name = name,
                Resolution = new Resolution(width, height),
                GameDir = gameDir,
                JavaDir = javaDir,
                JavaArgs = javaArgs,
                LastVersionId = lastVersionId,
                LauncherVisibilityOnGameClose = "N/A"
            };


            ProfilesService.UpdateProfile(profile);

            OperationResponse.PrintNew("launcher_profiles update", true);
        }

        [Command("list")]
        public void List()
        {
            var profiles = ProfilesService.GetLauncherProfiles();
            OperationResponse.PrintNew("launcher_profiles list", profiles);
        }
    }
}