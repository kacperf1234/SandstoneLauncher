using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IAsynchronosGameFilesDownloader
    {
        void DownloadAsync(GameVersion gameVersion, OS sys);
    }
}