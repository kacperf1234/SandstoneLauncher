using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class ClientPathFinder : IClientPathFinder
    {
        public IMinecraftDirectory MinecraftDirectory;

        public ClientPathFinder(IMinecraftDirectory minecraftDirectory)
        {
            MinecraftDirectory = minecraftDirectory;
        }

        public string GetPath(string version)
        {
            return MinecraftDirectory.GetVersions() + version + "\\" + version + ".jar";
        }
    }
}