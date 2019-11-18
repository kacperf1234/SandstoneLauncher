using System.Collections.Generic;
using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Models
{
    public class Language
    {
        [JsonProperty("strings")]
        public Dictionary<string, string> Strings { get; set; }
        
        [JsonProperty("data")]
        public LanguageData Data { get; set; }
        
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}