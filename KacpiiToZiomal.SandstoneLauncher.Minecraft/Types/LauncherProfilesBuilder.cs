using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class LauncherProfilesBuilder : IBuilder<LauncherProfiles, MojangLoginResponse>
    {
        public string LauncherName = "Minecraft Launcher";
        public int LauncherVersion = 25;

        public LauncherProfilesBuilder()
        {
        }

        public LauncherProfilesBuilder(int launcherVersion, string launcherName)
        {
            LauncherVersion = launcherVersion;
            LauncherName = launcherName;
        }

        public LauncherProfiles Build(MojangLoginResponse arg0)
        {
            LauncherProfiles o = new LauncherProfiles();
            o.AuthenticationDatabase.Add(arg0.AccessToken, new AuthenticationDatabase
            {
                AccessToken = arg0.AccessToken,
                DisplayName = arg0.SelectedProfile.Name,
                UserId = arg0.SelectedProfile.Name,
                Username = arg0.SelectedProfile.Name,
                Uuid = arg0.AccessToken
            });
            o.Profiles.Add(arg0.SelectedProfile.Name, new LauncherProfile {Name = arg0.SelectedProfile.Name});
            o.ClientToken = arg0.ClientToken;
            o.LauncherVersion = new LauncherVersion
            {
                Format = LauncherVersion,
                ProfilesFormat = 1,
                Name = LauncherName
            };
            o.SelectedUser = arg0.SelectedProfile.UserId;

            return o;
        }
    }
}