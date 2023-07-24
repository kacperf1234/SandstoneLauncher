using Newtonsoft.Json;
using SandstoneLauncher.Minecraft.Interfaces;

namespace SandstoneLauncher.Minecraft.Types
{
    public class JsonSerializer<T> : IJsonSerializer<T>
    {
        public string Serialize(T arg)
        {
            return JsonConvert.SerializeObject(arg, Formatting.Indented);
        }
    }
}