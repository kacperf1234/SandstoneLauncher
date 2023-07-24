using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;
using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class LauncherProfilesSerializator : IJsonBuilder<LauncherProfiles>
    {
        public string Build(LauncherProfiles arg)
        {
            return JsonConvert.SerializeObject(arg);
        }
    }
}