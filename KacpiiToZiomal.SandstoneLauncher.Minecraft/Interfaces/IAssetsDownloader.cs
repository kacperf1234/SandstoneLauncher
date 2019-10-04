using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IAssetsDownloader
    {
        void Download(Assets assets, FullVersion version);
        void DownloadAsync(Assets assets, FullVersion version);
    }
}