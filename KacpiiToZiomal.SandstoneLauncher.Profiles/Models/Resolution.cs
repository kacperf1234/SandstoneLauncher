using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Models
{
    public class Resolution
    {
        [JsonProperty("w")]
        public int Width { get; set; }
        
        [JsonProperty("h")]
        public int Height { get; set; }
    }
}