using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class GamePathBuilder : IGamePathBuilder
    {
        public IMinecraftDirectory Minecraft;

        public GamePathBuilder(IMinecraftDirectory minecraft)
        {
            Minecraft = minecraft;
        }

        public string GetAbsolutePath(string versionid)
        {
            return Minecraft.GetVersions() + versionid + "\\" + versionid + ".jar";
        }
    }
}