#region

using System.Net.Http;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces
{
    public interface IHttpClient
    {
        HttpResponseMessage GetResponse(string url, HttpMethod method);

        string GetContent(string url);
        HttpResponseMessage GetResponse(string url, HttpMethod method, string body);
    }
}