using Newtonsoft.Json;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Types
{
    public class LauncherProfilesSerializator : IJsonBuilder<LauncherProfiles>
    {
        public string Build(LauncherProfiles arg)
        {
            return JsonConvert.SerializeObject(arg);
        }
    }
}