using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IClientDownloader
    {
        void Download(DownloadObject client, string versionid);
    }
}