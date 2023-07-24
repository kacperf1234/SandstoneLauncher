using Newtonsoft.Json;
using SandstoneLauncher.Minecraft.Enums;

namespace SandstoneLauncher.Minecraft.Models
{
    
public class MojangLoginResponse
    {
        public MojangLoginResponse()
        {
        }

        public MojangLoginResponse(AuthenticationState state)
        {
            State = state;
        }

        public AuthenticationState State { get; set; } = AuthenticationState.NONE;

        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        [JsonProperty("clientToken")]
        public string ClientToken { get; set; }

        [JsonProperty("user")]
        public MojangUser User { get; set; }

        [JsonProperty("selectedProfile")]
        public MojangProfile SelectedProfile { get; set; }
    }
}