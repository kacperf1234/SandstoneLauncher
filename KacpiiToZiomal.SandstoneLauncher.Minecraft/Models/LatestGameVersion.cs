using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Models
{
    public class LatestGameVersion
    {
        [JsonProperty("release")]
        public string Release { get; set; }

        [JsonProperty("snapshot")]
        public string Snapshot { get; set; }
    }
}