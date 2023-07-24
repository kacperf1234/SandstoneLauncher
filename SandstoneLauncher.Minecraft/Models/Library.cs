using Newtonsoft.Json;

namespace SandstoneLauncher.Minecraft.Models
{
    public class Library
    {
        [JsonProperty("downloads")]
        public DownloadLibrary Download { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("natives")]
        public Natives Natives { get; set; }

        [JsonProperty("rules")]
        public Rule[] Rules { get; set; }
    }
}