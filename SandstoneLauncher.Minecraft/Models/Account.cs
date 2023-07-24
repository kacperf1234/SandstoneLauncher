using Newtonsoft.Json;

namespace SandstoneLauncher.Minecraft.Models
{
    [Spencer.NET.SingleInstance]
public class Account
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("client_token")]
        public string ClientToken { get; set; }
    }
}