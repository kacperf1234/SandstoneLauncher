using Newtonsoft.Json;

namespace SandstoneLauncher.Minecraft.Models
{
    public class DownloadArtifact
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("size")]
        public uint Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}