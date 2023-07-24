using Newtonsoft.Json;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Types
{
    public class FullVersionParser : IJsonParser<FullVersion>
    {
        public FullVersion Parse(string json)
        {
            return TryParse(json);
        }

        public FullVersion TryParse(string json)
        {
            FullVersion full = JsonConvert.DeserializeObject<FullVersion>(json);

            return full;
        }
    }
}