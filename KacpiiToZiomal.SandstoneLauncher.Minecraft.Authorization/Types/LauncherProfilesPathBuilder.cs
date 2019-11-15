using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
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