using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Models
{
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