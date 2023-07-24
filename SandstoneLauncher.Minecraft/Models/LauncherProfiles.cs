using System.Collections.Generic;
using Newtonsoft.Json;

namespace SandstoneLauncher.Minecraft.Models
{
    public class LauncherProfiles
    {
        public LauncherProfiles()
        {
            Profiles = new Dictionary<string, LauncherProfile>();
            AuthenticationDatabase = new Dictionary<string, AuthenticationDatabase>();
        }

        [JsonProperty("profiles")]
        public Dictionary<string, LauncherProfile> Profiles { get; set; }

        [JsonProperty("selectedProfile")]
        public string SelectedProfile { get; set; }

        [JsonProperty("clientToken")]
        public string ClientToken { get; set; }

        [JsonProperty("authenticationDatabase")]
        public Dictionary<string, AuthenticationDatabase> AuthenticationDatabase { get; set; }

        [JsonProperty("selectedUser")]
        public string SelectedUser { get; set; }

        [JsonProperty("launcherVersion")]
        public LauncherVersion LauncherVersion { get; set; }
    }
}