using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
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