using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Languages.Models
{
    public class ActuallyLanguage
    {
        [JsonProperty("short_name")]
        public string ShortName { get; set; }
    }
}