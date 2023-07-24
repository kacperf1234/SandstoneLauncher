using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IAssetsExtractor
    {
        Asset Get(Assets assets, string name);
    }
}