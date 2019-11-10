using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Delegates;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class HttpDownloader : IHttpDownloader
    {
        public static HttpDownloader Default => new HttpDownloader(new HttpBytesReader(), new FileCreator(new FileNameRemover()));
        
        public IHttpBytesReader BytesReader;
        public IFileCreator FileCreator;

        private bool CanRetry = true;

        public HttpDownloader(IHttpBytesReader bytesReader, IFileCreator fileCreator)
        {
            BytesReader = bytesReader;
            FileCreator = fileCreator;
        }

        private void DownloadFile(string url, string destination)
        {
            byte[] bytes = BytesReader.ReadBytes(url);
            FileCreator.Create(destination, bytes);
        }

        public void Download(string url, string destination)
        {
            DownloadFile(url, destination);
        }

        public void DownloadAsync(string url, string destination, Action<string, string, bool> act = null)
        {
            Thread thread = new Thread((x) => DownloadFile(url, destination));
            thread.Start();
        }
    }
}