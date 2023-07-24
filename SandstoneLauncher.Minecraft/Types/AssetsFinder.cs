using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Types
{
    public class AssetsFinder : IAssetsFinder
    {
        public IJsonDeserializer<Assets> Deserializer;
        public IHttpClient Http;

        public AssetsFinder(IHttpClient http, IJsonDeserializer<Assets> deserializer)
        {
            Http = http;
            Deserializer = deserializer;
        }

        public Assets GetAssets(string url, FullVersion version)
        {
            string json = Http.GetContent(url);
            Assets assets = Deserializer.Deserialize(json);
            assets.BaseJson = json;
            assets.Version = version;

            return assets;
        }
    }
}