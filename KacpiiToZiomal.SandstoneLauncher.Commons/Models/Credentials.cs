using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Models
{
    public class Credentials
    {
        [JsonProperty("username")]
        public string Username { get; set; }
        
        [JsonProperty("password")]
        public string Password { get; set; }
        
        [JsonProperty("is_online")]
        public bool IsOnline { get; set; }
    }
}