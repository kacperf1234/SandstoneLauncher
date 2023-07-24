using Newtonsoft.Json;

namespace SandstoneLauncher.Minecraft.Models
{
    
public class MojangProfile
    {
        [JsonProperty("agent")]
        public string Agent { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("createdAt")]
        public ulong CreatedAt { get; set; }

        [JsonProperty("legacyProfile")]
        public bool LegacyProfile { get; set; }

        [JsonProperty("suspended")]
        public bool Suspended { get; set; }

        [JsonProperty("tokenId")]
        public string TokenId { get; set; }

        [JsonProperty("paid")]
        public bool Paid { get; set; }

        [JsonProperty("migrated")]
        public bool Migrated { get; set; }
    }
}