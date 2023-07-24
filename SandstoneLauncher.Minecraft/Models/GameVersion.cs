using Newtonsoft.Json;

namespace SandstoneLauncher.Minecraft.Models
{
    public class GameVersion
    {
        public GameVersion()
        {
        }

        private GameVersion(string id)
        {
            Id = id;
        }

        private GameVersion(string id, string type, string url, string time, string releaseTime)
        {
            Id = id;
            Type = type;
            Url = url;
            Time = time;
            ReleaseTime = releaseTime;
        }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("releaseTime")]
        public string ReleaseTime { get; set; }

        public static GameVersion CreateVersion(string id)
        {
            return new GameVersion(id);
        }

        public static GameVersion CreateVersion(string id = "", string type = "", string url = "", string time = "", string releaseTime = "")
        {
            return new GameVersion(id, type, url, time, releaseTime);
        }
    }
}