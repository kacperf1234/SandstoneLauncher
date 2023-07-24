using Newtonsoft.Json;

namespace SandstoneLauncher.Minecraft.Models
{
    [Spencer.NET.SingleInstance]
public class Classifiers
    {
        [JsonProperty("javadoc")]
        public DownloadArtifact Javadoc { get; set; }

        [JsonProperty("natives-linux")]
        public DownloadArtifact Linux { get; set; }

        [JsonProperty("natives-windows")]
        public DownloadArtifact Windows { get; set; }
    }
}