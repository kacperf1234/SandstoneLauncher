using System;
using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Models
{
    public class ProfileMetadata
    {
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        
        [JsonProperty("edited_at")]
        public DateTime EditedAt { get; set; }
    }
}