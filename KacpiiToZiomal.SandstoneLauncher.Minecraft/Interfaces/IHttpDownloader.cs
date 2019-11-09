using System.Threading.Tasks;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IHttpDownloader
    {
        void Download(string url, string destination);

        Task DownloadAsync(string url, string destination);
    }
}