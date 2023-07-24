using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IAssetsDownloader
    {
        void Download(Assets assets, FullVersion version);
    }
}