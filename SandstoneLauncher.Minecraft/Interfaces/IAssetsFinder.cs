using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IAssetsFinder
    {
        Assets GetAssets(string url, FullVersion version);
    }
}