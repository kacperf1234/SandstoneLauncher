using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Models
{
    public class Downloads
    {
        [JsonProperty("client")]
        public DownloadObject Client { get; set; }

        [JsonProperty("server")]
        public DownloadObject Server { get; set; }
    }
}