using Newtonsoft.Json;

namespace SandstoneLauncher.Minecraft.Models
{
    [Spencer.NET.SingleInstance]
public class Downloads
    {
        [JsonProperty("client")]
        public DownloadObject Client { get; set; }

        [JsonProperty("server")]
        public DownloadObject Server { get; set; }
    }
}