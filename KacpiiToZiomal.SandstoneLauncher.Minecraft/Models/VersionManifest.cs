using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Models
{
    public class VersionManifest
    {
        [JsonProperty("latest")]
        public LatestGameVersion Latest { get; set; }

        [JsonProperty("versions")]
        public GameVersion[] Versions { get; set; }
    }
}