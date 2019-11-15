using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models
{
    public class RuleOperatingSystem
    {
        [JsonProperty("name")] public string Name { get; set; }
    }
}