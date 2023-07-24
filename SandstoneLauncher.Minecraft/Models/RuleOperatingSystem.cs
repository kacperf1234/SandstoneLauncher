using Newtonsoft.Json;

namespace SandstoneLauncher.Minecraft.Models
{
    public class RuleOperatingSystem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}