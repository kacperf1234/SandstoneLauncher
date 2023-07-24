using Newtonsoft.Json;

namespace SandstoneLauncher.Minecraft.Models
{
    public class LauncherProfile
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}