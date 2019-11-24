using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models
{
    public class DownloadObject
    {
        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("size")]
        public uint Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}