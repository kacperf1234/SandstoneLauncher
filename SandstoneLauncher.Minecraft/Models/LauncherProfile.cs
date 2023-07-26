using Newtonsoft.Json;

namespace SandstoneLauncher.Minecraft.Models
{
    public class LauncherProfile
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gameDir")]
        public string GameDir { get; set; }

        [JsonProperty("lastVersionId")]
        public string LastVersionId { get; set; }

        [JsonProperty("javaDir")]
        public string JavaDir { get; set; }

        [JsonProperty("javaArgs")]
        public string JavaArgs { get; set; }

        [JsonProperty("resolution")]
        public Resolution Resolution { get; set; }
        
        [JsonProperty("launcherVisibilityOnGameClose")]
        public string LauncherVisibilityOnGameClose { get; set; }
    }
}