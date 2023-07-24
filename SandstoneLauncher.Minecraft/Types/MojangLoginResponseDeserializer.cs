using Newtonsoft.Json;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class MojangLoginResponseDeserializer : IJsonDeserializer<MojangLoginResponse>
    {
        public MojangLoginResponse Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<MojangLoginResponse>(json);
        }
    }
}