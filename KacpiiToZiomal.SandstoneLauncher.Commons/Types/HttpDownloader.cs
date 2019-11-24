using System;
using System.Threading;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class HttpDownloader : IHttpDownloader
    {
        public IHttpBytesReader BytesReader;
        public IFileCreator FileCreator;

        public HttpDownloader(IHttpBytesReader bytesReader, IFileCreator fileCreator)
        {
            BytesReader = bytesReader;
            FileCreator = fileCreator;
        }

        public static HttpDownloader Default =>
            new HttpDownloader(new HttpBytesReader(), new FileCreator(new FileNameRemover()));

        public void Download(string url, string destination)
        {
            DownloadFile(url, destination);
        }

        public void DownloadAsync(string url, string destination, Action<string> doAfter = null)
        {
            Thread thread = new Thread(x => DownloadFile(url, destination));
            thread.Start();
        }

        private void DownloadFile(string url, string destination)
        {
            byte[] bytes = BytesReader.ReadBytes(url);
            FileCreator.Create(destination, bytes);
        }
    }
}