using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
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