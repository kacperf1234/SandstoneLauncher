using Newtonsoft.Json;

namespace SandstoneLauncher.Minecraft.Models
{
    public class Memory
    {
        [JsonProperty("xmx")]
        public int Xmx { get; set; }

        [JsonProperty("xms")]
        public int Xms { get; set; }
    }
}