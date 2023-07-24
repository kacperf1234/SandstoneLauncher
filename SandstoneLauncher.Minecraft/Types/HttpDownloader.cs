using System;
using System.Threading;
using SandstoneLauncher.Minecraft.Interfaces;

namespace SandstoneLauncher.Minecraft.Types
{
    // TODO: This 'async' HttpDownload it's fucking joke.
    
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

        public void DownloadAsync(string url, string destination, Action<string, string, bool> act = null)
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