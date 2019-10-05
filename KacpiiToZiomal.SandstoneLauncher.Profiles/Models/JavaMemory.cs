using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Models
{
    public class JavaMemory
    {
        [JsonProperty("xmx")]
        public int Xmx { get; set; }
        
        [JsonProperty("xms")]
        public int Xms { get; set; }
    }
}