using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IClientDownloader
    {
        void Download(DownloadObject client, string versionid);
    }
}