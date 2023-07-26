using Newtonsoft.Json;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class LauncherProfilesDeserializer : IJsonDeserializer<LauncherProfiles>
    {
        public LauncherProfiles Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<LauncherProfiles>(json);
        }
    }
}