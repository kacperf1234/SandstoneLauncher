using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class JsonSerializer<T> : IJsonSerializer<T>
    {
        public string Serialize(T arg)
        {
            return JsonConvert.SerializeObject(arg, Formatting.Indented);
        }
    }
}