using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
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