using SandstoneLauncher.Minecraft.Interfaces;

namespace SandstoneLauncher.Minecraft.Types
{
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