using Newtonsoft.Json;
using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class JsonSerializer<T> : IJsonSerializer<T>
    {
        public string Serialize(T arg)
        {
            return JsonConvert.SerializeObject(arg, Formatting.Indented);
        }
    }
}