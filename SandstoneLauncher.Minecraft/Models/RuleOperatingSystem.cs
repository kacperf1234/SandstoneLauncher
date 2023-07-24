using Newtonsoft.Json;

namespace SandstoneLauncher.Minecraft.Models
{
    [Spencer.NET.SingleInstance]
public class RuleOperatingSystem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}