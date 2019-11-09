using System;
using System.Threading.Tasks;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IHttpDownloader
    {
        void Download(string url, string destination);

        Task DownloadAsync(string url, string destination, Action<string, string, bool> act = null);
    }
}