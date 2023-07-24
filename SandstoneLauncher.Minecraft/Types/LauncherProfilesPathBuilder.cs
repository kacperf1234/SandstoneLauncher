using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
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