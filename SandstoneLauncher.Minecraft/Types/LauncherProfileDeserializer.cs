using Newtonsoft.Json;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class LauncherProfileDeserializer : IJsonDeserializer<LauncherProfile>
    {
        public LauncherProfile Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<LauncherProfile>(json);
        }
    }
}