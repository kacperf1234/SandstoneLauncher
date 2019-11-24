using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Models
{
    public class LanguageSettings
    {
        [JsonProperty("shortname")]
        public string ShortName { get; set; }

        [JsonProperty("longname")]
        public string LongName { get; set; }
    }
}