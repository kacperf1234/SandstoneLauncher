using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
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