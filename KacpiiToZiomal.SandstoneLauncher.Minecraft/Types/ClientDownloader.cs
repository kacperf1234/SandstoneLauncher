using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class ClientDownloader : IClientDownloader
    {
        public IHttpDownloader Downloader;
        public IClientPathFinder PathFinder;

        public ClientDownloader(IClientPathFinder pathFinder, IHttpDownloader downloader)
        {
            PathFinder = pathFinder;
            Downloader = downloader;
        }

        public void Download(DownloadObject client, string versionid)
        {
            string destination = PathFinder.GetPath(versionid);
            Downloader.Download(client.Url, destination);
        }
    }
}