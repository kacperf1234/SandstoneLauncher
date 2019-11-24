using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Models
{
    public class MojangUser
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("registerIp")]
        public string RegisterIp { get; set; }

        [JsonProperty("registeredAt")]
        public ulong RegisteredAt { get; set; }

        [JsonProperty("passwordChangedAt")]
        public ulong PasswordChangedAt { get; set; }

        [JsonProperty("dateOfBirth")]
        public ulong DateOfBirth { get; set; }

        [JsonProperty("suspensed")]
        public bool Suspensed { get; set; }

        [JsonProperty("blocked")]
        public bool Blocked { get; set; }

        [JsonProperty("secured")]
        public bool Secured { get; set; }

        [JsonProperty("migrated")]
        public bool Migrated { get; set; }

        [JsonProperty("emailVerified")]
        public bool EmailVerified { get; set; }

        [JsonProperty("legacyUser")]
        public bool LegacyUser { get; set; }

        [JsonProperty("verifiedByParent")]
        public bool VerifiedByParent { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("fromMigratedUser")]
        public bool FromMigratedUser { get; set; }
    }
}