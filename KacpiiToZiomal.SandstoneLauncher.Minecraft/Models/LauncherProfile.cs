using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Models
{
    public class LauncherProfile
    {
        [JsonProperty("name")] public string Name { get; set; }
    }
}