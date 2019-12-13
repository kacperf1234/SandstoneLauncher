using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Models
{
    public class CredentialsData
    {
        [JsonProperty("actually")]
        public Credentials Actually { get; set; }
        
        [JsonProperty("stored")]
        public Credentials[] Stored { get; set; }
    }
}