using Newtonsoft.Json;

namespace SandstoneLauncher.Minecraft.Models
{
    
public class LauncherVersion
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("format")]
        public int Format { get; set; }

        [JsonProperty("profilesFormat")]
        public int ProfilesFormat { get; set; }
    }
}