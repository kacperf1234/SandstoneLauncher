using Newtonsoft.Json;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class LauncherProfileSerializer : IJsonSerializer<LauncherProfile>
    {
        public string Serialize(LauncherProfile arg)
        {
            return JsonConvert.SerializeObject(arg);
        }
    }
}