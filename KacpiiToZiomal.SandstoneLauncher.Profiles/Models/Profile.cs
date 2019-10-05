using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;
using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Models
{
    public class Profile
    {
        [JsonProperty("profile_name")]
        public string ProfileName { get; set; }
        
        [JsonProperty("profile_version")]
        public string ProfileVersion { get; set; }
        
        [JsonProperty("game_directory")]
        public string GameDirectory { get; set; }
        
        [JsonProperty("resolution")]
        public Resolution Resolution { get; set; }
        
        [JsonProperty("game_version")]
        public GameVersion GameVersion { get; set; }
        
        [JsonProperty("java_settings")]
        public JavaSettings JavaSettings { get; set; }
    }
}