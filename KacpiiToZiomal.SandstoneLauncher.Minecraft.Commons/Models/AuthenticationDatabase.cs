using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models
{
    public class AuthenticationDatabase
    {
        [JsonProperty("displayName")] public string DisplayName { get; set; }

        [JsonProperty("accessToken")] public string AccessToken { get; set; }

        [JsonProperty("userid")] public string UserId { get; set; }

        [JsonProperty("username")] public string Username { get; set; }

        [JsonProperty("uuid")] public string Uuid { get; set; }
    }
}