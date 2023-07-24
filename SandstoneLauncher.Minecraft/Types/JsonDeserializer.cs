using Newtonsoft.Json;
using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class JsonDeserializer<T> : IJsonDeserializer<T>
    {
        public T Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}