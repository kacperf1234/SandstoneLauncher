using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models
{
    public class LauncherProfile
    {
        [JsonProperty("name")] public string Name { get; set; }
    }
}