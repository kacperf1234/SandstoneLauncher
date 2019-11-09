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
        public IHttpBytesReader BytesReader;
        public IFileCreator FileCreator;

        public static HttpDownloader Default => new HttpDownloader(new HttpBytesReader(), new FileCreator(new FileNameRemover()));

        public HttpDownloader(IHttpBytesReader bytesReader, IFileCreator fileCreator)
        {
            BytesReader = bytesReader;
            FileCreator = fileCreator;
        }

        public void Download(string url, string destination)
        {
            byte[] bytes = BytesReader.ReadBytes(url);
            FileCreator.Create(destination, bytes);
        }

        public void DownloadAsync(string url, string destination, Action<string, string, bool> act = null)
        {
            new Thread(() =>
            {
                byte[] bytes = BytesReader.ReadBytes(url);
                FileCreator.Create(destination, bytes);
            }).Start();
        }
    }
}