using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Types
{
    public class LauncherProfilesPathBuilder : IBuilder<string>
    {
        public IMinecraftDirectory Minecraft;

        public LauncherProfilesPathBuilder(IMinecraftDirectory minecraft)
        {
            Minecraft = minecraft;
        }

        public string Build()
        {
            return Minecraft.GetMinecraft() + "launcher_profiles.json";
        }
    }
}