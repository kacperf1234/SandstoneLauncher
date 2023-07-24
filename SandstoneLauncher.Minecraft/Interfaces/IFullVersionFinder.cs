using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IFullVersionFinder
    {
        FullVersion Find(string url);
    }
}