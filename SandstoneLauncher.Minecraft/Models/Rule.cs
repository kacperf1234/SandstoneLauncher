using Newtonsoft.Json;

namespace SandstoneLauncher.Minecraft.Models
{
    public class Rule
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("os")]
        public RuleOperatingSystem OperatingSystem { get; set; }
    }
}