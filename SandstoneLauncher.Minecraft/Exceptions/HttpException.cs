using System;
using System.Net.Http;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Exceptions
{
    public class HttpException : Exception
    {
        public HttpResponseMessage ResponseMessage;

        public HttpException(HttpResponseMessage r) : base("Exception: HttpException -- " +
                                                           r.Content.ReadAsStringAsync().Result)
        {
            ResponseMessage = r;
        }
    }
}