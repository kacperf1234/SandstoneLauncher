using System;
using System.Net.Http;
using System.Text;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class NetworkClient : IHttpClient
    {
        public string GetContent(string url)
        {
            HttpRequestMessage r = new HttpRequestMessage();
            r.RequestUri = new Uri(url);
            r.Method = HttpMethod.Get;

            HttpClient c = new HttpClient();
            return c.SendAsync(r).Result.Content.ReadAsStringAsync().Result;
        }

        public HttpResponseMessage GetResponse(string url, HttpMethod method)
        {
            HttpRequestMessage r = new HttpRequestMessage();
            r.RequestUri = new Uri(url);
            r.Method = method;

            HttpClient c = new HttpClient();
            return c.SendAsync(r).Result;
        }

        public HttpResponseMessage GetResponse(string url, HttpMethod method, string body)
        {
            HttpClient c = new HttpClient();
            return c.PostAsync(url, new StringContent(body, Encoding.UTF8, "application/json")).Result;
        }
    }
}