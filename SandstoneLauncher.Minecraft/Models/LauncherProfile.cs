using Newtonsoft.Json;

namespace SandstoneLauncher.Minecraft.Models
{
    [Spencer.NET.SingleInstance]
public class LauncherProfile
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}