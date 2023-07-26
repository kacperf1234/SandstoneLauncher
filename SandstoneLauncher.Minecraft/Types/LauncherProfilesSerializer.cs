using Newtonsoft.Json;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class LauncherProfilesSerializer : IJsonSerializer<LauncherProfiles>
    {
        public string Serialize(LauncherProfiles arg)
        {
            return JsonConvert.SerializeObject(arg);
        }
    }
}