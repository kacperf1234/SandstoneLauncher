using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models
{
    public class Rule
    {
        [JsonProperty("action")] public string Action { get; set; }

        [JsonProperty("os")] public RuleOperatingSystem OperatingSystem { get; set; }
    }
}