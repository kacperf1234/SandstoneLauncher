using System;
using System.Net.Http;
using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class ResponseValidator : IResponseValidator
    {
        public Func<HttpResponseMessage, bool> Func;

        public ResponseValidator()
        {
        }

        public ResponseValidator(Func<HttpResponseMessage, bool> func)
        {
            Func = func;
        }

        public bool Validate(HttpResponseMessage r)
        {
            if (Func == null)
                return r.IsSuccessStatusCode;
            return Func(r);
        }
    }
}