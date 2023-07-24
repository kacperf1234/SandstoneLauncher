using Newtonsoft.Json;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class LauncherProfilesSerializator : IJsonBuilder<LauncherProfiles>
    {
        public string Build(LauncherProfiles arg)
        {
            return JsonConvert.SerializeObject(arg);
        }
    }
}