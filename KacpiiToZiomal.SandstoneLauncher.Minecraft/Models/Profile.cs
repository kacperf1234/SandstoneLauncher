using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Models
{
    public class Profile
    {
        [JsonProperty("version")]
        public FullVersion Version { get; set; }

        [JsonProperty("xmx")]
        public int Xmx { get; set; }

        [JsonProperty("xms")]
        public int Xms { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("java_executable")]
        public string JavaExecutable { get; set; }

        [JsonProperty("java_arguments")]
        public string JavaArguments { get; set; }

        [JsonProperty("game_directory")]
        public string GameDirectory { get; set; }
    }
}