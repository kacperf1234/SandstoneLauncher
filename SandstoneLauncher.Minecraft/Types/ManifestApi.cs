using System.Net.Http;
using SandstoneLauncher.Minecraft.Exceptions;
using SandstoneLauncher.Minecraft.Interfaces;

namespace SandstoneLauncher.Minecraft.Types
{
    public class ManifestApi : IManifestApi
    {
        public readonly string Url = "https://launchermeta.mojang.com/mc/game/version_manifest.json";

        public IHttpClient Http;
        public IResponseValidator Validator;

        public ManifestApi(IHttpClient http, IResponseValidator validator)
        {
            Http = http;
            Validator = validator;
        }

        public string GetJson()
        {
            HttpResponseMessage r = Http.GetResponse(Url, HttpMethod.Get);

            if (Validator.Validate(r))
                return r.Content.ReadAsStringAsync().Result;

            throw new HttpException(r);
        }
    }
}