using System.Net;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Delegates;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class HttpDownloader : IHttpDownloader
    {
        public IDirectoryCreator Creator;

        public DownloadFile DownloadFile;

        public HttpDownloader(IDirectoryCreator creator)
        {
            Creator = creator;
        }

        public static HttpDownloader Default => new HttpDownloader(new DirectoryCreator(new FileNameRemover()));

        public void Download(string url, string destination)
        {
            Creator.Create(destination);

            using (WebClient wb = new WebClient())
            {
                wb.DownloadFile(url, destination);

                if (DownloadFile != null)
                {
                    DownloadFile.Invoke(url, destination);
                }
            }
        }
    }
}