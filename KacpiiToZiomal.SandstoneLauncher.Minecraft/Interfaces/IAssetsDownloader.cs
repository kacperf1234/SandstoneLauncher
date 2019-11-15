using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IAssetsDownloader
    {
        void Download(Assets assets, FullVersion version);
    }
}