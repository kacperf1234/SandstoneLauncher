using System;
using System.Net;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class AsynchronousDownloader : IHttpDownloader
    {
        public bool WaitForEnd { get; set; } = false;

        public void Download(string url, string destination)
        {
            using (WebClient web = new WebClient())
            {
                if (WaitForEnd)
                {
                    web.DownloadFile(url, destination);
                }

                else
                {
                    web.DownloadFileAsync(new Uri(url), destination);
                }
            }
        }
    }
}