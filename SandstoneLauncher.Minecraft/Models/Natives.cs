using Newtonsoft.Json;

namespace SandstoneLauncher.Minecraft.Models
{
    
public class Natives
    {
        [JsonProperty("windows")]
        public string Windows { get; set; }

        [JsonProperty("linux")]
        public string Linux { get; set; }
    }
}