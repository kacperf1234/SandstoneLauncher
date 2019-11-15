using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IClientDownloader
    {
        void Download(DownloadObject client, string versionid);
    }
}