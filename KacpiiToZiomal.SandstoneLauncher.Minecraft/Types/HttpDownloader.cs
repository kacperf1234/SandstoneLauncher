using System;
using System.Net;
using System.Net.Http;
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

        public static HttpDownloader Default
        {
            get { return new HttpDownloader(new HttpBytesReader(), new FileCreator(new FileNameRemover())); }
        }
        
        public HttpDownloader(IHttpBytesReader bytesReader, IFileCreator fileCreator)
        {
            BytesReader = bytesReader;
            FileCreator = fileCreator;
        }

        public void Download(string url, string destination)
        {
            using (HttpClient http = new HttpClient())
            {
                byte[] bytes = BytesReader.ReadBytes(url);
                FileCreator.Create(destination, bytes);
            }
        }

        public Task DownloadAsync(string url, string destination, Action<string, string, bool> act = null)
        {
            return Task.Run(() =>
            {
                try
                {
                    byte[] bytes = BytesReader.ReadBytes(url);
                    FileCreator.Create(destination, bytes);
                    
                    act?.Invoke(url, destination, true);
                }

                catch (Exception e)
                {
                    act?.Invoke(url, destination, false);
                }
            });
        }
    }
}