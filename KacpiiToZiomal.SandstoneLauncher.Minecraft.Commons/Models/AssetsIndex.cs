using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models
{
    public class AssetsIndex
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("size")]
        public uint Size { get; set; }

        [JsonProperty("totalSize")]
        public uint TotalSize { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}