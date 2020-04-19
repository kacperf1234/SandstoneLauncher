using System.Net.Http;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IHttpClient
    {
        HttpResponseMessage GetResponse(string url, HttpMethod method);

        string GetContent(string url);
        HttpResponseMessage GetResponse(string url, HttpMethod method, string body);
    }
}