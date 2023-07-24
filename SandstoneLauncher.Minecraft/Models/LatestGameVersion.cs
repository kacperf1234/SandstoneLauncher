using Newtonsoft.Json;

namespace SandstoneLauncher.Minecraft.Models
{
    [Spencer.NET.SingleInstance]
public class LatestGameVersion
    {
        [JsonProperty("release")]
        public string Release { get; set; }

        [JsonProperty("snapshot")]
        public string Snapshot { get; set; }
    }
}