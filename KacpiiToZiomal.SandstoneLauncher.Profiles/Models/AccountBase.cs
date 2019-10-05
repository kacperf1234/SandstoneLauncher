using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Models
{
    public abstract class AccountBase
    {
        [JsonProperty("username")]
        public string GameUsername { get; set; }
        
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("uuid")]
        public string UUID { get; set; }
    }
}