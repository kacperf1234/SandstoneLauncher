using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Profiles.Models
{
    public class Profile
    {
        [JsonProperty("manifest")]
        public string ManifestPath { get; set; }

        [JsonProperty("xmx")]
        public int Xmx { get; set; }

        [JsonProperty("xms")]
        public int Xms { get; set; }

        [JsonProperty("java_executable")]
        public string JavaExecutable { get; set; }

        [JsonProperty("java_arguments")]
        public string JavaArguments { get; set; }

        [JsonProperty("game_directory")]
        public string GameDirectory { get; set; }
    }
}