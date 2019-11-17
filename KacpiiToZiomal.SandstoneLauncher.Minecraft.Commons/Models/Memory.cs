using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models
{
    public class Memory
    {
        [JsonProperty("xmx")]
        public int Xmx { get; set; }
        
        [JsonProperty("xms")]
        public int Xms { get; set; }
    }
}