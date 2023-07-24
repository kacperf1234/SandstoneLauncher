using Newtonsoft.Json;

namespace SandstoneLauncher.Minecraft.Models
{
    [Spencer.NET.SingleInstance]
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