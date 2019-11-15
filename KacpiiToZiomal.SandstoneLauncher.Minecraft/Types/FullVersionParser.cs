using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
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