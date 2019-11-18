using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Models
{
    public class LanguageData
    {
        [JsonProperty("short_name")]
        public string ShortName { get; set; }
        
        [JsonProperty("long_name")]
        public string LongName { get; set; }
        
        [JsonProperty("country_name")]
        public string CountryName { get; set; }
    }
}