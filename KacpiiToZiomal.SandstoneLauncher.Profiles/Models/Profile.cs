using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Models
{
    public class Profile
    {
        [JsonProperty("profile_name")]
        public string ProfileName { get; set; }
        
        [JsonProperty("profile_version")]
        public string ProfileVersion { get; set; }
    }
}