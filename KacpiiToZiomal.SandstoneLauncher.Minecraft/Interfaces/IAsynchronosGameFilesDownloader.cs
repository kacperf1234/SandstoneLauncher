using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IAsynchronosGameFilesDownloader
    {
        void DownloadAsync(GameVersion gameVersion, OS sys);
    }
}