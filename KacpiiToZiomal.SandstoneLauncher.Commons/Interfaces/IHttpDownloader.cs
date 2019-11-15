#region

using System;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces
{
    public interface IHttpDownloader
    {
        void Download(string url, string destination);

        void DownloadAsync(string url, string destination, Action<string, string, bool> act = null);
    }
}