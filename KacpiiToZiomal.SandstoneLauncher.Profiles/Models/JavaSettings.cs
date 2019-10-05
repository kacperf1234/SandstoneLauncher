using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Models
{
    public class JavaSettings
    {
        [JsonProperty("java_executable")]
        public string JavaExecutable { get; set; }
        
        [JsonProperty("java_arguments")]
        public string Arguments { get; set; }
        
        [JsonProperty("java_memory")]
        public JavaMemory Memory { get; set; }
        
        [JsonProperty("main")]
        public string MainClass { get; set; }
        
        [JsonProperty("runas")]
        public bool RunAs { get; set; }
    }
}