using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Models
{
    public class RuleOperatingSystem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}