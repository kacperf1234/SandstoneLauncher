using Newtonsoft.Json;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
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