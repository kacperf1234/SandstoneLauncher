using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models
{
    public class Downloads
    {
        [JsonProperty("client")]
        public DownloadObject Client { get; set; }

        [JsonProperty("server")]
        public DownloadObject Server { get; set; }
    }
}